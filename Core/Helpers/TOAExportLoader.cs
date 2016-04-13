using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransformerAssessment.Core.Managers;

namespace TransformerAssessment.Core.Helpers {
    class TOAExportLoader {
        #region [Variables] Class variables
        private static string[] exportsPathList;// array of file name + extention ("equipment.csv")
        private static string exportsDirectory; // folder location selected by default or by user
        private static string[] fileNameList;   // file names without extention ("equipment", "test data")
        private static TestData[] testData;     // list of TestData objects, each representing an individual test
        private static List<Transformer> equipment = new List<Transformer>();   // list of Equipment objects, each representing an individual piece of equipment
                                                                            //  (one transformer and respective LTC/SEL/DIV
        private static List<TestData> rawTestData;      // raw TestData read from 'test data.csv'
        private static List<string[]> equipmentToParse = new List<string[]>();    // raw Equipment read from 'equipment.csv'

        public static List<string> headerNames = new List<string>();    // list of header names from 'equipment.csv' (row 1 values)

        // vars to separate equipment types before combining into Tranformer objects
        public static List<string[]> xfmrs = new List<string[]>();
        public static List<string[]> divs = new List<string[]>();
        public static List<string[]> sels = new List<string[]>();
        public static List<string[]> ltcs = new List<string[]>();
        
        // vars used to improve performance
        public static int equipnumIndex;
        public static int region_nameIndex;
        public static int owner_nameIndex;
        public static int apprtypeIndex;
        public static int designationIndex;
        public static int substn_nameIndex;
        public static int mfrIndex;
        public static int norm_nameIndex;

        public static int sampledateIndex = 0;

        // vars used for index of variables in Norms
        private static List<int> normVarIndixes = new List<int>();

        #region [Instance Variables] Vars used for test data
        public static List<string> dataHeaders = new List<string>();    // list of header names from 'test data.csv'
        public static List<string[] > rawData = new List<string[]>();   // list of unparsed data rows

        public static int data_equipnumIndex;
        public static int data_apprtypeIndex;
        public static int data_norm_nameIndex;
        #endregion
        #endregion

        public static void initializeTOAExports() {
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            string PROG_PATH = Application.StartupPath;
            try {
                exportsDirectory = Path.Combine(PROG_PATH, @"TOAExports");
                exportsPathList = Directory.GetFiles(exportsDirectory, "*.csv");
                createEquipmentToParse(exportsDirectory + @"\equipment.csv");
            } catch (Exception e) {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
                throw;
            }
        }

        public static void updateTOAExports(string folder) {
            exportsDirectory = folder;
            exportsPathList = Directory.GetFiles(exportsDirectory, "*.csv");
            /*fileNameList = new string[exportsPathList.Length];
                for (int i = 0; i < exportsPathList.Length; i++)
                    fileNameList[i] = Path.GetFileNameWithoutExtension(exportsPathList[i]);
            * */
            //createTOAExports();
        }

        private static void createTOAExports() {
            throw new NotImplementedException();
        }

        private static void createRawTestData(string filePath) {
            // create list of TestData objects from 'test data.csv' and put in rawTestData
            bool isFirstLine = true;
            char[] delimiters = new char[] { ',' };
            using (StreamReader reader = new StreamReader(filePath)) {
                while (true) {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    if (!string.IsNullOrWhiteSpace(line)) {
                        string[] splitRow = line.Split(delimiters); // split csv row into array
                        if (isFirstLine) {
                            foreach (string header in splitRow) // add header values into List headerNames
                                dataHeaders.Add(header);
                            data_equipnumIndex = dataHeaders.IndexOf("equipnum");
                            data_apprtypeIndex = dataHeaders.IndexOf("apprtype");
                            data_norm_nameIndex = dataHeaders.IndexOf("norm_name");
                            
                            isFirstLine = false;
                        }
                        if (isValidData(splitRow))
                            rawData.Add(splitRow);
                        else
                            Console.WriteLine("EQUIPMENT apprtype doesn't match:]\t{0}", splitRow[apprtypeIndex]);
                    }
                }
            }
            // add rawData to the transformers
            addDataToTransformers();
        }

        private static void addDataToTransformers() {
            // cycle through transformer list and for each one, go through rawData and add it to the xfmr
            for (int i = 0; i < equipment.Count; i++) {

            }
        }

        private static void createEquipmentToParse(string filePath) {
            // create list of string[] and add them to the list to parse after file is read
            bool isFirstLine = true;
            char[] delimiters = new char[] { ',' };
            using (StreamReader reader = new StreamReader(filePath)) {
                while (true) {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    if (!string.IsNullOrWhiteSpace(line)) {
                        string[] splitRow = line.Split(delimiters); // split csv row into array
                        if (isFirstLine) {
                            foreach (string header in splitRow) // add header values into List headerNames
                                headerNames.Add(header);
                            equipnumIndex = headerNames.IndexOf("equipnum");
                            region_nameIndex = headerNames.IndexOf("region_name");
                            owner_nameIndex = headerNames.IndexOf("owner_name");
                            apprtypeIndex = headerNames.IndexOf("apprtype");
                            designationIndex = headerNames.IndexOf("designation");
                            substn_nameIndex = headerNames.IndexOf("substn_name");
                            norm_nameIndex = headerNames.IndexOf("norm_name");
                            mfrIndex = headerNames.IndexOf("mfr");

                            isFirstLine = false;
                        }
                        if (isValidEquipment(splitRow))
                                if (splitRow[apprtypeIndex].Equals("XFMR"))
                                    xfmrs.Add(splitRow);
                                else if (splitRow[apprtypeIndex].Equals("LTC"))
                                    ltcs.Add(splitRow);
                                else if (splitRow[apprtypeIndex].Equals("SEL"))
                                    sels.Add(splitRow);
                                else if (splitRow[apprtypeIndex].Equals("DIV"))
                                    divs.Add(splitRow);
                                else
                                    Console.WriteLine("EQUIPMENT apprtype doesn't match:]\t{0}", splitRow[apprtypeIndex]);
                    }
                }
            }
            parseRawEquiment();
        }

        private static bool isValidEquipment(string[] equipmentRow) {
            return (equipmentRow[region_nameIndex].Equals("OLTC") || equipmentRow[region_nameIndex].Equals("161/69"))
                    && !equipmentRow[owner_nameIndex].Equals("Customer")
                    && !equipmentRow[apprtypeIndex].Equals("OLTC REACTOR")
                    && !equipmentRow[designationIndex].Contains("FAILED")
                    && !equipmentRow[substn_nameIndex].Contains("FAILED")
                    && !equipmentRow[substn_nameIndex].Contains("DISPOSED");
        }

        private static bool isValidData(string[] dataRow) {
            return xfmrsContains(dataRow[data_equipnumIndex]);
        }

        private static void parseRawEquiment() {
            /*Console.WriteLine("Number of rows added to 'xfmrs' = " + xfmrs.Count);
            Console.WriteLine("Number of rows added to 'ltcs' = " + ltcs.Count);
            Console.WriteLine("Number of rows added to 'sels' = " + sels.Count);
            Console.WriteLine("Number of rows added to 'divs' = " + divs.Count);
            Console.WriteLine("Number of total rows added = {0}", xfmrs.Count + ltcs.Count + sels.Count + divs.Count);*/

            //checkForMissingEquipment(); // cycle through LTCs, SELs, & DIVs and make sure all have a corresponding XFMR (for Debugging)

            // cycle through XFMRs and compare equimentID to those in LTCs, SELs, & DIVs to know what to use when creating Equipment object
            string[] LTC;    // create empty strings for use in Tranformer object creation
            string[] SEL;
            string[] DIV;
            for (int i = 0; i < xfmrs.Count; i++) {
                // reset LTC equipment strings[][]
                LTC = new string[] { };
                SEL = new string[] { };
                DIV = new string[] { };
                // if there is LTC from 'equipment.csv', add to Transformer obj
                for (int j = 0; j < ltcs.Count; j++)
                    if (xfmrs[i][equipnumIndex] == ltcs[j][equipnumIndex])
                        LTC = ltcs[j];
                // if there is SEL from 'equipment.csv', add to Transformer obj
                for (int j = 0; j < sels.Count; j++)
                    if (xfmrs[i][equipnumIndex] == sels[j][equipnumIndex])
                        SEL = sels[j];
                // if there is DIV from 'equipment.csv', add to Transformer obj
                for (int j = 0; j < divs.Count; j++)
                    if (xfmrs[i][equipnumIndex] == divs[j][equipnumIndex])
                        DIV = divs[j];
                equipment.Add(new Transformer(xfmrs[i], LTC, SEL, DIV));
            }
        }

        private static void checkForMissingEquipment() {
            for (int i = 0; i < ltcs.Count; i++)
                if (!xfmrsContains(ltcs[i][equipnumIndex]))
                    Console.WriteLine("{0} {1} LTC ({2}) does not have corresponding XFMR", ltcs[i][substn_nameIndex]
                                                                                          , ltcs[i][designationIndex]
                                                                                          , ltcs[i][equipnumIndex]);
            for (int i = 0; i < sels.Count; i++)
                if (!xfmrsContains(sels[i][equipnumIndex]))
                    Console.WriteLine("{0} {1} SEL ({2}) does not have corresponding XFMR", sels[i][substn_nameIndex]
                                                                                          , sels[i][designationIndex]
                                                                                          , sels[i][equipnumIndex]);
            for (int i = 0; i < divs.Count; i++)
                if (!xfmrsContains(divs[i][equipnumIndex]))
                    Console.WriteLine("{0} {1} DIV ({2}) does not have corresponding XFMR", divs[i][substn_nameIndex]
                                                                                          , divs[i][designationIndex]
                                                                                          , divs[i][equipnumIndex]);
        }

        private static bool xfmrsContains(string id) {
            for (int i = 0; i < xfmrs.Count; i++)
                if (xfmrs[i][equipnumIndex].Equals(id))
                    return true;
            return false;
        }

        #region [Methods] Getters
        public static string[] getTOAExportsList() { return exportsPathList; }
        public static string getExportsDir() { return exportsDirectory; }
        public static string[] getFileNameList() { return fileNameList; }
        public static TestData[] getTestData() { return testData; }
        public static List<Transformer> getEquipment() { return equipment; }
        #endregion
    }
}

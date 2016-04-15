using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformerAssessment.Core.Managers;
using TransformerAssessment;
using System.Windows.Forms;
using System.IO;

namespace TransformerAssessment.Core.Helpers {
    class EquipmentLoader {
        #region [Variables] Class variables
        private static string[] equipmentPathList;// array of file name + extention ("equipment.csv")
        private static string equipmentDirectory; // folder location selected by default or by user
        private static string[] xfmrNameList;   // file names without extention ("equipment", "test data")
        private static TestData[] testData;     // list of TestData objects, each representing an individual test
        public static List<Transformer> equipment = new List<Transformer>();   // list of Equipment objects, each representing an individual piece of equipment
        //  (one transformer and respective LTC/SEL/DIV
        private static List<TestData> rawTestData;      // raw TestData read from 'test data.csv'
        private static List<string[]> equipmentToParse = new List<string[]>();    // raw Equipment read from 'equipment.csv'

        public static List<string> headers = new List<string>();    // list of header names from 'equipment.csv' (row 1 values)

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
        public static int year_mfgIndex;

        // vars used for index of variables in Norms
        private static List<int> normVarIndixes = new List<int>();

        #endregion

        public static void initializeEquipment() {
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            string PROG_PATH = Application.StartupPath;
            try {
                equipmentDirectory = Path.Combine(PROG_PATH, @"TOAExports");
                equipmentPathList = Directory.GetFiles(equipmentDirectory, "*.csv");
                createEquipmentToParse(equipmentDirectory + @"\equipment.csv");
            } catch (Exception e) {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
                throw;
            }
        }

        public static void updateEquipment(string folder) {
            equipmentDirectory = folder;
            equipmentPathList = Directory.GetFiles(equipmentDirectory, "*.csv");
            /*fileNameList = new string[equipmentPathList.Length];
                for (int i = 0; i < equipmentPathList.Length; i++)
                    fileNameList[i] = Path.GetFileNameWithoutExtension(equipmentPathList[i]);
            * */
            //createTOAExports();
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
                            foreach (string header in splitRow) // add header values into List headers
                                headers.Add(header);
                            equipnumIndex = headers.IndexOf("equipnum");
                            region_nameIndex = headers.IndexOf("region_name");
                            owner_nameIndex = headers.IndexOf("owner_name");
                            apprtypeIndex = headers.IndexOf("apprtype");
                            designationIndex = headers.IndexOf("designation");
                            substn_nameIndex = headers.IndexOf("substn_name");
                            norm_nameIndex = headers.IndexOf("norm_name");
                            mfrIndex = headers.IndexOf("mfr");
                            year_mfgIndex = headers.IndexOf("year_mfg");

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
            // creat xfmrNameList (array of XFMR locations & designations)
            xfmrNameList = new string[equipment.Count];
            for (int i = 0; i < equipment.Count; i++)
                xfmrNameList[i] = equipment[i].getLocation() + " " + equipment[i].getPosition();
        }

        private static bool isValidEquipment(string[] equipmentRow) {
            return (equipmentRow[region_nameIndex].Equals("OLTC") || equipmentRow[region_nameIndex].Equals("161/69"))
                    && !equipmentRow[owner_nameIndex].Equals("Customer")
                    && !equipmentRow[apprtypeIndex].Equals("OLTC REACTOR")
                    && !equipmentRow[designationIndex].Contains("FAILED")
                    && !equipmentRow[substn_nameIndex].Contains("FAILED")
                    && !equipmentRow[substn_nameIndex].Contains("DISPOSED");
        }

        #region [Methods] Getters
        public static string[] getEquipmentPathList() { return equipmentPathList; }
        public static string getEquipmentDir() { return equipmentDirectory; }
        public static string[] getXFMRNameList() { return xfmrNameList; }
        public static List<Transformer> getTransformers() { return equipment; }
        #endregion
    }
}

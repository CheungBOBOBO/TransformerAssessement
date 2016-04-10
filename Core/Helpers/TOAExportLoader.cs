using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransformerAssessment.Core.Managers;

namespace TransformerAssessment.Core.Helpers
{
    class TOAExportLoader
    {
        private static string[] exportsPathList;// array of file name + extention ("equipment.csv")
        private static string exportsDirectory; // folder location selected by default or by user
        private static string[] fileNameList;   // file names without extention ("equipment", "test data")
        private static TestData[] testData;     // list of TestData objects, each representing an individual test
        private static Equipment[] equipment;   // list of Equipment objects, each representing an individual piece of equipment
                                                //  (one transformer and respective LTC/SEL/DIV
        private static List<TestData> rawTestData;      // raw TestData read from 'test data.csv'
        private static List<string[]> equipmentToParse = new List<string[]>();    // raw Equipment read from 'equipment.csv'

        public static List<string> headerNames = new List<string>(); // list of header names from 'equipment.csv' (row 1 values)

        // variables to separate equipment types before combining into Equipment objects
        private static List<string[]> xfmrs = new List<string[]>();
        private static List<string[]> divs = new List<string[]>();
        private static List<string[]> sels = new List<string[]>();
        private static List<string[]> ltcs = new List<string[]>();
        
        // vars used to improve performance
        private static int region_nameIndex = 0;
        private static int owner_nameIndex = 0;
        private static int apprtypeIndex = 0;
        private static int designationIndex = 0;
        private static int locationIndex = 0;

        public static void initializeTOAExports()
        {
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            string PROG_PATH = Application.StartupPath;
            try
            {
                exportsDirectory = Path.Combine(PROG_PATH, @"TOAExports");
                exportsPathList = Directory.GetFiles(exportsDirectory, "*.csv");
                /*fileNameList = new string[exportsPathList.Length];
                for (int i = 0; i < exportsPathList.Length; i++)
                    fileNameList[i] = Path.GetFileNameWithoutExtension(exportsPathList[i]);
                * */
                createEquipmentToParse(exportsDirectory + @"\equipment.csv");
                //createRawTestData();
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
            }
        }

        public static void updateTOAExports(string folder)
        {
            exportsDirectory = folder;
            exportsPathList = Directory.GetFiles(exportsDirectory, "*.csv");
            /*fileNameList = new string[exportsPathList.Length];
                for (int i = 0; i < exportsPathList.Length; i++)
                    fileNameList[i] = Path.GetFileNameWithoutExtension(exportsPathList[i]);
            * */
            //createTOAExports();
        }

        private static void createTOAExports()
        {
            throw new NotImplementedException();
        }

        private static void createRawTestData()
        {
            // create list of TestData objects from 'test data.csv' and put in rawTestData
            
        }

        private static void createEquipmentToParse(string filePath)
        {
            // create list of string[] and add them to the list to parse after file is read
            bool isFirstLine = true;
            char[] delimiters = new char[] { ',' };
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] splitRow = line.Split(delimiters); // split csv row into array
                        if (isFirstLine)
                        {
                            foreach (string header in splitRow) // add header values into List headerNames
                                headerNames.Add(header);
                            region_nameIndex = headerNames.IndexOf("region_name");
                            owner_nameIndex = headerNames.IndexOf("owner_name");
                            apprtypeIndex = headerNames.IndexOf("apprtype");
                            designationIndex = headerNames.IndexOf("designation");
                            locationIndex = headerNames.IndexOf("location");

                            isFirstLine = false;
                        }
                        if (isValidEquipment(splitRow))
                                if (splitRow[apprtypeIndex].Equals("XFMR"))
                                    xfmrs.Add(splitRow);
                                else if (splitRow[headerNames.IndexOf("apprtype")].Equals("LTC"))
                                    ltcs.Add(splitRow);
                                else if (splitRow[headerNames.IndexOf("apprtype")].Equals("SEL"))
                                    sels.Add(splitRow);
                                else if (splitRow[headerNames.IndexOf("apprtype")].Equals("DIV"))
                                    divs.Add(splitRow);
                                else
                                    Console.WriteLine("EQUIPMENT apprtype doesn't match:]\t{0}", splitRow[headerNames.IndexOf("apprtype")]);
                    }
                }
            }
            parseRawEquiment();
        }

        private static bool isValidEquipment(string[] equipmentRow)
        {
            return (equipmentRow[region_nameIndex].Equals("OLTC") || equipmentRow[region_nameIndex].Equals("161/69"))
                    && !equipmentRow[owner_nameIndex].Equals("Customer")
                    && !equipmentRow[apprtypeIndex].Equals("OLTC REACTOR")
                    && !equipmentRow[designationIndex].Contains("FAILED")
                    && !equipmentRow[locationIndex].Contains("FAILED");
        }

        private static void parseRawEquiment()
        {
            /*Console.WriteLine("Number of rows added to 'xfmrs' = " + xfmrs.Count);
            Console.WriteLine("Number of rows added to 'ltcs' = " + ltcs.Count);
            Console.WriteLine("Number of rows added to 'sels' = " + sels.Count);
            Console.WriteLine("Number of rows added to 'divs' = " + divs.Count);*/

            // add transformers to equipment (since in order to have an LTC, must have XFMR first
        }

        public static string[] getTOAExportsList() { return exportsPathList; }

        public static string getExportsDir() { return exportsDirectory; }

        public static string[] getFileNameList() { return fileNameList; }

        public static TestData[] getTestData() { return testData; }

        public static Equipment[] getEquipment() { return equipment; }
    }
}

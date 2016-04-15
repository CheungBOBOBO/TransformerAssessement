using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransformerAssessment.Core.Managers;
using TransformerAssessment.Core.Helpers;
using TransformerAssessment;
using LumenWorks.Framework.IO.Csv;

namespace TransformerAssessment.Core.Helpers {
    class TestDataLoader {
        #region [Variables] Class variables
        private static string[] testDataPathList;// array of file name + extention ("equipment.csv")
        private static string testDataDirectory; // folder location selected by default or by user
        private static string[] xfmrNameList;   // file names without extention ("equipment", "test data")
        private static TestData[] testData;     // list of TestData objects, each representing an individual test
        private static List<TestData> rawTestData;      // raw TestData read from 'test data.csv'

        // vars used for index of variables in Norms
        private static List<int> normVarIndixes = new List<int>();

        #region [Instance Variables] Vars used for test data
        public static string[] headers;    // list of header names from 'test data.csv'
        public static List<string[]> rawData = new List<string[]>();   // list of unparsed data rows

        public static int equipnumIndex;
        public static int apprtypeIndex;
        public static int norm_nameIndex;
        public static int sampledateIndex;
        #endregion
        #endregion

        public static void initializeTestData() {
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            string PROG_PATH = Application.StartupPath;
            try {
                testDataDirectory = Path.Combine(PROG_PATH, @"TOAExports");
                testDataPathList = Directory.GetFiles(testDataDirectory, "*.csv");
                createRawTestData(testDataDirectory + @"\test_data.csv");
            } catch (Exception e) {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
                throw;
            }
        }

        private static void createRawTestData(string filePath) {
            // create list of TestData objects from 'test data.csv' and put in rawTestData
            bool isFirstLine = true;
            // open the file "data.csv" which is a CSV file with headers
            using (CsvReader csv = new CsvReader(new StreamReader(filePath), true)) {
                csv.MissingFieldAction = MissingFieldAction.ReplaceByEmpty; // replace empty fields with ""
                int fieldCount = csv.FieldCount;    // fieldCount = num columns/fields
                headers = csv.GetFieldHeaders();   // string[] of column headers
                while (csv.ReadNextRecord()) {
                    if (isFirstLine) {
                        equipnumIndex = csv.GetFieldIndex("equipnum");
                        apprtypeIndex = csv.GetFieldIndex("apprtype");
                        norm_nameIndex = csv.GetFieldIndex("norm_used");
                        isFirstLine = false;
                    }
                    if (!isFirstLine && isValidData(csv)) {
                        string[] tempRow = new string[fieldCount];
                        for (int j = 0; j < tempRow.Length; j++)
                            tempRow[j] = csv[j];
                        rawData.Add(tempRow);
                    }
                }
            }
            // add rawData to the transformers
            // cycle through rawData list and for each one, go through equipment and add it to the xfmr
            for (int i = 0; i < rawData.Count; i++) {
                for (int j = 0; j < EquipmentLoader.equipment.Count; j++) {
                    if (rawData[i][equipnumIndex].Contains(EquipmentLoader.equipment[j].getID())) {
                        EquipmentLoader.equipment[j].addData(rawData[i]);
                        break;
                    }
                }
            }
        }

        private static bool isValidData(string[] dataRow) {
            return xfmrsContains(dataRow[equipnumIndex]);
        }

        private static bool isValidData(CsvReader csvRow) {
            return xfmrsContains(csvRow[equipnumIndex]);
        }

        #region [Debug Methods]
        private static void checkForMissingEquipment() {
            for (int i = 0; i < EquipmentLoader.ltcs.Count; i++)
                if (!xfmrsContains(EquipmentLoader.ltcs[i][equipnumIndex]))
                    Console.WriteLine("{0} {1} LTC ({2}) does not have corresponding XFMR", EquipmentLoader.ltcs[i][EquipmentLoader.substn_nameIndex]
                                                                                          , EquipmentLoader.ltcs[i][EquipmentLoader.designationIndex]
                                                                                          , EquipmentLoader.ltcs[i][EquipmentLoader.equipnumIndex]);
            for (int i = 0; i < EquipmentLoader.sels.Count; i++)
                if (!xfmrsContains(EquipmentLoader.sels[i][equipnumIndex]))
                    Console.WriteLine("{0} {1} SEL ({2}) does not have corresponding XFMR", EquipmentLoader.sels[i][EquipmentLoader.substn_nameIndex]
                                                                                          , EquipmentLoader.sels[i][EquipmentLoader.designationIndex]
                                                                                          , EquipmentLoader.sels[i][EquipmentLoader.equipnumIndex]);
            for (int i = 0; i < EquipmentLoader.divs.Count; i++)
                if (!xfmrsContains(EquipmentLoader.divs[i][equipnumIndex]))
                    Console.WriteLine("{0} {1} DIV ({2}) does not have corresponding XFMR", EquipmentLoader.divs[i][EquipmentLoader.substn_nameIndex]
                                                                                          , EquipmentLoader.divs[i][EquipmentLoader.designationIndex]
                                                                                          , EquipmentLoader.divs[i][EquipmentLoader.equipnumIndex]);
        }
        #endregion

        private static bool xfmrsContains(string id) {
            for (int i = 0; i < EquipmentLoader.equipment.Count; i++)
                if (id.Contains(EquipmentLoader.equipment[i].getID()))
                    return true;
            return false;
        }

        #region [Methods] Getters
        public static string[] getTestDataPathList() { return testDataPathList; }
        public static string getTestDataDir() { return testDataDirectory; }
        public static TestData[] getTestData() { return testData; }
        #endregion
    }
}

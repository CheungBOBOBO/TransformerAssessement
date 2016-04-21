using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using LumenWorks.Framework.IO.Csv;

namespace TransformerAssessment.Core.Loaders {
    class TestDataLoader {
        #region [Variables] Class variables
        private static string testDataFile;   // file path (".....\test_data.csv")

        public static string[] headers;    // list of header names from 'test data.csv'
        public static List<string[]> rawData = new List<string[]>();   // list of unparsed data rows
        // Test Data value indices
        public static int date_index;
        public static int opCount_index;
        public static int h2_index;
        public static int o2_index;
        public static int n2_index;
        public static int ch4_index;
        public static int co_index;
        public static int co2_index;
        public static int c2h4_index;
        public static int c2h6_index;
        public static int c2h2_index;
        public static int d1816_2_index;
        public static int furfural_index;
        public static int acidnum_index;
        public static int relSat_index;
        public static int water_index;
        public static int visual_index;
        public static int color_index;
        public static int ift_index;
        public static int sg_index;
        public static int c2h4_c2h2_index;
        public static int c2h6_ch4_index;
        public static int o2_n2_index;
        public static int temp_index;
        public static int[] wantedIndices = new int[23];  // 23 indexes that we want 


        public static int equipnumIndex;
        public static int apprtypeIndex;
        public static int norm_nameIndex;
        #endregion

        public static void initializeTestData() {
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            rawData = new List<string[]>();
            string PROG_PATH = Application.StartupPath;
            try {
                testDataFile = TransformerAssessment.testDataFile;
                createRawTestData(testDataFile);
            } catch (Exception e) {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
                throw;
            }
        }

        public static void updateTestData() {
            // reset rawData List
            rawData = new List<string[]>();
            testDataFile = TransformerAssessment.testDataFile;
            createRawTestData(testDataFile);
        }

        private static void createRawTestData(string filePath) {
            // create list of TestData objects from 'test data.csv' and put in rawTestData
            bool isFirstLine = true;
            // open the test data file which is a CSV file with headers
            using (CsvReader csv = new CsvReader(new StreamReader(filePath), true)) {
                csv.MissingFieldAction = MissingFieldAction.ReplaceByEmpty; // replace empty fields with ""
                int fieldCount = csv.FieldCount;    // fieldCount = num columns/fields
                headers = csv.GetFieldHeaders();   // string[] of column headers
                while (csv.ReadNextRecord()) {
                    if (isFirstLine) {
                        equipnumIndex = csv.GetFieldIndex("equipnum");
                        apprtypeIndex = csv.GetFieldIndex("apprtype");
                        norm_nameIndex = csv.GetFieldIndex("norm_used");

                        date_index = csv.GetFieldIndex("sampledate");
                        opCount_index = csv.GetFieldIndex("opscount");
                        h2_index = csv.GetFieldIndex("h2");
                        o2_index = csv.GetFieldIndex("o2");
                        n2_index = csv.GetFieldIndex("n2");
                        ch4_index = csv.GetFieldIndex("ch4");
                        co_index = csv.GetFieldIndex("co");
                        co2_index = csv.GetFieldIndex("co2");
                        c2h4_index = csv.GetFieldIndex("c2h4");
                        c2h6_index = csv.GetFieldIndex("c2h6");
                        c2h2_index = csv.GetFieldIndex("c2h2");
                        d1816_2_index = csv.GetFieldIndex("d1816_2");
                        furfural_index = csv.GetFieldIndex("furfural"); // ignored in analysis
                        acidnum_index = csv.GetFieldIndex("acidnum");
                        relSat_index = csv.GetFieldIndex("relsaturation");
                        water_index = csv.GetFieldIndex("water");
                        visual_index = csv.GetFieldIndex("visual");
                        color_index = csv.GetFieldIndex("color");
                        ift_index = csv.GetFieldIndex("ift");
                        sg_index = csv.GetFieldIndex("sg");
                        c2h4_c2h2_index = csv.GetFieldIndex("c2h4/c2h2");
                        c2h6_ch4_index = csv.GetFieldIndex("c2h6/ch4");
                        o2_n2_index = csv.GetFieldIndex("o2/n2");
                        temp_index = csv.GetFieldIndex("fluidtempc");

                        wantedIndices[0] = date_index;
                        wantedIndices[1] = opCount_index;
                        wantedIndices[2] = h2_index;
                        wantedIndices[3] = o2_index;
                        wantedIndices[4] = n2_index;
                        wantedIndices[5] = ch4_index;
                        wantedIndices[6] = co_index;
                        wantedIndices[7] = co2_index;
                        wantedIndices[8] = c2h4_index;
                        wantedIndices[9] = c2h6_index;
                        wantedIndices[10] = c2h2_index;
                        wantedIndices[11] = d1816_2_index;
                        wantedIndices[12] = furfural_index;
                        wantedIndices[13] = acidnum_index;
                        wantedIndices[14] = relSat_index;
                        wantedIndices[15] = water_index;
                        wantedIndices[16] = visual_index;
                        wantedIndices[17] = color_index;
                        wantedIndices[18] = ift_index;
                        wantedIndices[19] = c2h4_c2h2_index;
                        wantedIndices[20] = c2h6_ch4_index;
                        wantedIndices[21] = o2_n2_index;

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
        public static string getTestDataPath() { return testDataFile; }
        #endregion
    }
}

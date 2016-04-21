using System;
using System.Collections.Generic;

using TransformerAssessment.Core.Objects;
using System.Windows.Forms;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace TransformerAssessment.Core.Loaders {
    class EquipmentLoader {
        #region [Variables] Class variables
        private static string equipmentFile;    // file path (".....\equipment.csv")
        private static string[] xfmrNameList;   // file names without extention ("equipment", "test data")
        
        public static List<Transformer> equipment = new List<Transformer>();    // list of Equipment objects, each representing an individual piece of equipment
                                                                                //  (one transformer and respective LTC/SEL/DIV
        public static string[] headers; // list of header names from 'equipment.csv' (row 1 values)
        // vars to separate equipment types before combining into Tranformer objects
        public static List<string[]> xfmrs = new List<string[]>();
        public static List<string[]> divs = new List<string[]>();
        public static List<string[]> sels = new List<string[]>();
        public static List<string[]> ltcs = new List<string[]>();
        // vars used to access equipment values
        public static int equipnumIndex;
        public static int serialnumIndex;
        public static int norm_nameIndex;
        public static int mfrIndex;
        public static int year_mfgIndex;
        public static int modelIndex;
        public static int oilpresIndex;
        public static int eqp_remarksIndex;
        public static int designationIndex;
        public static int substn_nameIndex;
        public static int region_nameIndex;
        public static int owner_nameIndex;
        public static int apprtypeIndex;

        // vars used for index of variables in Norms
        private static List<int> normVarIndixes = new List<int>();

        #endregion

        public static void initializeEquipment() {
            resetEquipment();
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            string PROG_PATH = Application.StartupPath;
            try {
                equipmentFile = TransformerAssessment.equipmentFile;
                createEquipmentToParse(equipmentFile);
            } catch (Exception e) {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
                throw;
            }
        }

        public static void updateEquipment() {
            // reset equipment
            resetEquipment();
            equipmentFile = TransformerAssessment.equipmentFile;
            createEquipmentToParse(equipmentFile);
        }

        private static void resetEquipment() {
            equipment = new List<Transformer>();
            xfmrs = new List<string[]>();
            divs = new List<string[]>();
            sels = new List<string[]>();
            ltcs = new List<string[]>();
        }

        private static void createEquipmentToParse(string filePath) {
            // reset equipmentToParse List
            equipment = new List<Transformer>();
            bool isFirstLine = true;
            // open the equipment file which is a CSV file with headers
            using (CsvReader csv = new CsvReader(new StreamReader(filePath), true)) {
                csv.MissingFieldAction = MissingFieldAction.ReplaceByEmpty; // replace empty fields with ""
                int fieldCount = csv.FieldCount;    // fieldCount = num columns/fields
                headers = csv.GetFieldHeaders();   // string[] of column headers
                while (csv.ReadNextRecord()) {
                    if (isFirstLine) {
                        equipnumIndex = csv.GetFieldIndex("equipnum");
                        serialnumIndex = csv.GetFieldIndex("serialnum");
                        norm_nameIndex = csv.GetFieldIndex("norm_name");
                        mfrIndex = csv.GetFieldIndex("mfr");
                        year_mfgIndex = csv.GetFieldIndex("year_mfg");
                        modelIndex = csv.GetFieldIndex("model");
                        oilpresIndex = csv.GetFieldIndex("oilpres");
                        eqp_remarksIndex = csv.GetFieldIndex("eqp_remarks");
                        designationIndex = csv.GetFieldIndex("designation");
                        substn_nameIndex = csv.GetFieldIndex("substn_name");
                        region_nameIndex = csv.GetFieldIndex("region_name");
                        owner_nameIndex = csv.GetFieldIndex("owner_name");
                        apprtypeIndex = csv.GetFieldIndex("apprtype");
                        
                        isFirstLine = false;
                    }
                    if (!isFirstLine && isValidEquipment(csv)) {
                        string[] tempRow = new string[fieldCount];
                        for (int i = 0; i < tempRow.Length; i++)
                            tempRow[i] = csv[i];
                        if (csv[apprtypeIndex].Contains("XFMR"))
                            xfmrs.Add(tempRow);
                        else if (csv[apprtypeIndex].Contains("LTC"))
                            ltcs.Add(tempRow);
                        else if (csv[apprtypeIndex].Contains("SEL"))
                            sels.Add(tempRow);
                        else if (csv[apprtypeIndex].Contains("DIV"))
                            divs.Add(tempRow);
                        else
                            Console.WriteLine("EQUIPMENT apprtype doesn't match:]\t{0}", csv[apprtypeIndex]);
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

        private static bool isValidEquipment(CsvReader csvRow) {
            return (csvRow[region_nameIndex].Contains("OLTC") || csvRow[region_nameIndex].Contains("161/69"))
                    && !csvRow[owner_nameIndex].Contains("Customer")
                    && !csvRow[apprtypeIndex].Contains("OLTC REACTOR")
                    && !csvRow[designationIndex].Contains("FAILED")
                    && !csvRow[substn_nameIndex].Contains("FAILED")
                    && !csvRow[substn_nameIndex].Contains("DISPOSED");
        }

        #region [Methods] Getters
        public static string getEquipmentFile() { return equipmentFile; }
        public static string[] getXFMRNameList() { return xfmrNameList; }
        public static List<Transformer> getTransformers() { return equipment; }
        #endregion
    }
}

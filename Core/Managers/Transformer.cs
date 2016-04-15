using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformerAssessment.Core.Helpers;

namespace TransformerAssessment.Core.Managers {
    class Transformer {
        private string equipID;
        private string substn_name;
        private string designation;
        public string norm;
        public string manufacturer;
        public string[] rawXFMR;

        public List<string> equipmentHeaders = null;
        public List<TestData> data = new List<TestData>();
        public TapChanger ltc;
        public Selector sel;
        public Diverter div;

        public bool hasLTC;
        public bool hasSEL;
        public bool hasDIV;

        public Transformer(string[] transformer) {
            equipID = transformer[TOAExportLoader.equipnumIndex];
            substn_name = transformer[TOAExportLoader.substn_nameIndex];
            designation = transformer[TOAExportLoader.designationIndex];
            manufacturer = transformer[TOAExportLoader.mfrIndex];
            equipmentHeaders = TOAExportLoader.headerNames;
        }

        public Transformer(string[] transformer, string[] ltc, string[] sel, string[] div) {
            equipID = transformer[TOAExportLoader.equipnumIndex];
            substn_name = transformer[TOAExportLoader.substn_nameIndex];
            designation = transformer[TOAExportLoader.designationIndex];
            manufacturer = transformer[TOAExportLoader.mfrIndex];
            equipmentHeaders = TOAExportLoader.headerNames;

            rawXFMR = transformer;
            //Console.WriteLine("Creating transformer: {0}, {1} {2}", equipID, substn_name, designation);
            if (ltc.Length > 0) { 
                //Console.WriteLine("\t-adding LTC (row length: {0})", ltc.Length);
                addLTC(ltc);
            }
            if (sel.Length > 0) {
                //Console.WriteLine("\t-adding SEL (row length: {0})", sel.Length);
                addSEL(sel);
            }
            if (div.Length > 0) {
                //Console.WriteLine("\t-adding DIV (row length: {0})", div.Length);
                addDIV(div);
            }
        }

        /// <summary>Adds data[] to Tranformer instance.
        /// <param name="data">string[] from 'data.csv' row</param>
        /// </summary>
        public void addData(string[] data) {
            //Console.WriteLine("Adding data to {0} {1} {2}", substn_name, designation, data[TOAExportLoader.data_apprtypeIndex]);
            // if data is LTC, add to ltc
            if (hasLTC && data[TOAExportLoader.apprtypeIndex].Equals("LTC"))
                ltc.addData(data);
            // if data is SEL, add to sel
            else if (hasSEL && data[TOAExportLoader.apprtypeIndex].Equals("SEL"))
                sel.addData(data);
            // if data is DIV, add to div
            else if (hasDIV && data[TOAExportLoader.apprtypeIndex].Equals("DIV"))
                div.addData(data);
            else if (data[TOAExportLoader.apprtypeIndex].Equals("XFMR"))
                addXFMRData(data);
        }

        private void addXFMRData(string[] data) {
            this.data.Add(new TestData(data));
        }

        public void addLTC(string[] equipment) {
            ltc = new TapChanger(equipment);
            hasLTC = true;
        }

        public void addSEL(string[] equipment) {
            sel = new Selector(equipment);
            hasSEL = true;
        }

        public void addDIV(string[] equipment) {
            div = new Diverter(equipment);
            hasDIV = true;
        }

        #region [Methods] Getters
        public string getID() { return equipID; }
        public string getLocation() { return substn_name; }
        public string getPosition() { return designation; }
        #endregion
    }
}

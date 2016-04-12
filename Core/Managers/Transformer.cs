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

        public List<string> equipmentHeaders = null;
        public List<TestData> data = null;
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
            equipmentHeaders = TOAExportLoader.headerNames;
        }

        public Transformer(string[] transformer, string[] ltc, string[] sel, string[] div) {
            equipID = transformer[TOAExportLoader.equipnumIndex];
            substn_name = transformer[TOAExportLoader.substn_nameIndex];
            designation = transformer[TOAExportLoader.designationIndex];
            equipmentHeaders = TOAExportLoader.headerNames;
            if (ltc != null)
                addLTC(ltc);
            if (sel != null)
                addSEL(ltc);
            if (div != null)
                addDIV(div);
        }

        /// <summary>Adds data[] to Tranformer instance.
        /// <param name="data">string[] from 'data.csv' row</param>
        /// </summary>
        public void addData(string[] data) {
            
        }

        public void addLTC(string[] equipment) {
            ltc = new TapChanger(equipment);
            hasLTC = true;
        }

        public void addSEL(string[] equipment) {
            ltc = new Selector(equipment)
            hasSEL = true;
        }

        public void addDIV(string[] equipment) {
            ltc = new Diverter(equipment)
            hasDIV = true;
        }

        #region [Methods] Getters
        public string getID() { return equipID; }
        public string getLocation() { return substn_name; }
        public string getPosition() { return designation; }
        #endregion
    }
}

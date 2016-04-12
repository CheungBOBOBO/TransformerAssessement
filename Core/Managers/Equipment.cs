using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformerAssessment.Core.Helpers;

namespace TransformerAssessment.Core.Managers {
    class Equipment {
        private int equipID;
        private string substn_name;
        private string designation;

        public List<string[]> equipmentHeaders = null;
        public List<TestData> xfmrData = null;
        public List<TestData> ltcData = null;
        public List<TestData> selData = null;
        public List<TestData> divData = null;

        public bool hasLTC;
        public bool hasSEL;
        public bool hasDIV;

        public Equipment(string[] transformer) {
            equipID = Convert.ToInt32(transformer[TOAExportLoader.equipnumIndex]);
            substn_name = transformer[TOAExportLoader.substn_nameIndex];
            designation = transformer[TOAExportLoader.designationIndex];
        }

        /// <summary>Adds data[] to Equipment instance.
        /// <param name="data">string[] from 'data.csv' row</param>
        /// </summary>
        public void addData(string[] data) {

        }

        /// <summary>Adds equipment[] to Equipment instance.
        /// <param name="equipment">string[] from 'data.csv' row. Represents either LTC, SEL, or DIV</param>
        /// </summary>
        public void addLTCEquipment(string[] equipment) {
            // Determine if equipment[] is an LTC, SEL, or DIV, then add it to respective List<TestData>
        }

        #region [Methods] Getters
        public int getID() { return equipID; }
        public string getLocation() { return substn_name; }
        public string getPosition() { return designation; }
        #endregion
    }
}

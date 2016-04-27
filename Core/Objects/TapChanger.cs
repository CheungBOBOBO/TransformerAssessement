using System;
using System.Collections.Generic;
using System.Linq;
using TransformerAssessment.Core.Loaders;

namespace TransformerAssessment.Core.Objects {
    class TapChanger {
        public List<TestData> data = new List<TestData>();
        public string norm;
        public string manufacturer;
        public string yearMade;
        public string oilPresType;
        public string remarks;
        public string model;

        /// <summary>
        /// Calculated health of the LTC object
        /// </summary>
        public double Health { get; set; }

        public TapChanger(string[] ltc) {
            norm = ltc[EquipmentLoader.norm_nameIndex];
            manufacturer = ltc[EquipmentLoader.mfrIndex];
            yearMade = ltc[EquipmentLoader.year_mfgIndex];
            oilPresType = ltc[EquipmentLoader.oilpresIndex];
            remarks = ltc[EquipmentLoader.eqp_remarksIndex];
            model = ltc[EquipmentLoader.modelIndex];
        }

        public void addData(string[] data) {
            this.data.Add(new TestData(data));
            this.data = this.data.OrderByDescending(m => m._date).ToList();
        }
    }
}

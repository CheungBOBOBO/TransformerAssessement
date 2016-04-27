using System;
using System.Collections.Generic;
using System.Linq;
using TransformerAssessment.Core.Loaders;

namespace TransformerAssessment.Core.Objects{
    class Diverter {
        public List<TestData> data = new List<TestData>();
        public string norm;
        public string manufacturer;
        public string yearMade;
        public string oilPresType;
        public string remarks;
        public string model;

        /// <summary>
        /// Calculated health of the DIV object
        /// </summary>
        public double Health { get; set; }

        public Diverter(string[] div) {
            norm = div[EquipmentLoader.norm_nameIndex];
            manufacturer = div[EquipmentLoader.mfrIndex];
            yearMade = div[EquipmentLoader.year_mfgIndex];
            oilPresType = div[EquipmentLoader.oilpresIndex];
            remarks = div[EquipmentLoader.eqp_remarksIndex];
            model = div[EquipmentLoader.modelIndex];
        }

        public void addData(string[] data) {
            this.data.Add(new TestData(data));
            this.data = this.data.OrderByDescending(m => m._date).ToList();
        }
    }
}

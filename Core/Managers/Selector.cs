using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformerAssessment.Core.Helpers;

namespace TransformerAssessment.Core.Managers {
    class Selector {
        public List<TestData> data = new List<TestData>();

        public string norm;
        public string manufacturer;
        public string yearMade;

        public Selector(string[] sel) {
            norm = sel[EquipmentLoader.norm_nameIndex];
            manufacturer = sel[EquipmentLoader.mfrIndex];
            yearMade = sel[EquipmentLoader.year_mfgIndex];
        }

        public void addData(string[] data) {
            this.data.Add(new TestData(data));
            this.data = this.data.OrderByDescending(m => m._date).ToList();
        }
    }
}

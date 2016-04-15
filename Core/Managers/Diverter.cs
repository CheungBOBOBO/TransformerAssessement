using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformerAssessment.Core.Helpers;

namespace TransformerAssessment.Core.Managers {
    class Diverter {
        public List<TestData> data = new List<TestData>();

        public string norm;
        public string manufacturer;
        public string yearMade;

        public Diverter(string[] div) {
            norm = div[EquipmentLoader.norm_nameIndex];
            manufacturer = div[EquipmentLoader.mfrIndex];
            yearMade = div[EquipmentLoader.year_mfgIndex];
        }

        public void addData(string[] data) {
            this.data.Add(new TestData(data));
        }
    }
}

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

        public Diverter(string[] div) {
            norm = div[TOAExportLoader.norm_nameIndex];
            manufacturer = div[TOAExportLoader.mfrIndex];
        }

        public void addData(string[] data) {

        }
    }
}

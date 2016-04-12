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

        public Selector(string[] sel) {
            norm = sel[TOAExportLoader.norm_nameIndex];
            manufacturer = sel[TOAExportLoader.mfrIndex];
        }

        public void addData(string[] data) {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TransformerAssessment.Core.Helpers;

namespace TransformerAssessment.Core.Managers {
    class TapChanger {
        public List<TestData> data = new List<TestData>();

        public string norm;
        public string manufacturer;

        public TapChanger(string[] ltc) {
            norm = ltc[TOAExportLoader.norm_nameIndex];
            manufacturer = ltc[TOAExportLoader.mfrIndex];
        }

        public void addData(string[] data) {
            this.data.Add(new TestData(data));
        }
    }
}

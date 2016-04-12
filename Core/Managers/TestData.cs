using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerAssessment.Core.Managers {
    class TestData {
        #region [Instance Variables]
        public string date;
        public DateTime _date;
        public int operationCount;
        public int h2;      // hydrogen
        public int o2;      // oxygen
        public int n2;      // nitrogen
        public int ch4;     // methane
        public int co;      // carbon monoxide
        public int co2;     // carbon dioxide
        public int c2h4;    // ethylene
        public int c2h6;    // ethane
        public int c2h2;    // acetylene
        public int d1816_2; // dielectric breakdown
        public int acidnum; // acid number
        public int ift;     // interfacial tension
        public int relsat;  // relative saturation
        public int furan;   // total furan estimation
        public int water;   // water (ppm)
        #endregion

        public TestData(string path) {
            
        }
    }
}

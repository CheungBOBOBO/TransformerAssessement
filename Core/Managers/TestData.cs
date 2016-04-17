using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformerAssessment.Core.Helpers;

namespace TransformerAssessment.Core.Managers {
    class TestData {
        #region [Instance Variables]
        public string[] rawData;

        public string date;
        public DateTime _date;
        public int opCount = -1;     // operation count
        public int h2 = -1;          // hydrogen
        public int o2 = -1;          // oxygen
        public int n2 = -1;          // nitrogen
        public int ch4 = -1;         // methane
        public int co = -1;          // carbon monoxide
        public int co2 = -1;         // carbon dioxide
        public int c2h4 = -1;        // ethylene
        public int c2h6 = -1;        // ethane
        public int c2h2 = -1;        // acetylene
        public int d1816_2 = -1;     // dielectric breakdown
        public int furfural = -1;    // furan (IGNORED)
        public int relsat = -1;      // relative saturation
        public int water = -1;       // water (ppm)
        public string visual;        // visual
        public double acidnum = -1;     // acid number
        public double color = -1;    // color
        public double ift = -1;      // interfacial tension
        public double c2h4_c2h2 = -1;// ethylene to acetylene ratio
        public double c2h6_ch4 = -1; // ethane to methane ratio
        public double o2_n2 = -1;    // oxygen to nitrogen ratio
        #endregion

        public TestData(string[] raw) {
            rawData = raw;

            for (int i = 0; i < rawData.Length; i++ ) {
                if (string.IsNullOrWhiteSpace(rawData[i]))
                    rawData[i] = "-1";
            }

            date = rawData[TestDataLoader.date_index];
            _date = DateTime.Parse(date);
            opCount = Convert.ToInt32(rawData[TestDataLoader.opCount_index]);
            h2 = Convert.ToInt32(rawData[TestDataLoader.h2_index]);
            o2 = Convert.ToInt32(rawData[TestDataLoader.o2_index]);
            n2 = Convert.ToInt32(rawData[TestDataLoader.n2_index]);
            ch4 = Convert.ToInt32(rawData[TestDataLoader.ch4_index]);
            co = Convert.ToInt32(rawData[TestDataLoader.co_index]);
            co2 = Convert.ToInt32(rawData[TestDataLoader.co2_index]);
            c2h4 = Convert.ToInt32(rawData[TestDataLoader.c2h4_index]);
            c2h6 = Convert.ToInt32(rawData[TestDataLoader.c2h6_index]);
            c2h2 = Convert.ToInt32(rawData[TestDataLoader.c2h2_index]);
            d1816_2 = Convert.ToInt32(rawData[TestDataLoader.d1816_2_index]);
            furfural = Convert.ToInt32(rawData[TestDataLoader.furfural_index]);
            relsat = Convert.ToInt32(rawData[TestDataLoader.relsat_index]);
            water = Convert.ToInt32(rawData[TestDataLoader.water_index]);
            visual = rawData[TestDataLoader.visual_index];
            acidnum = Convert.ToDouble(rawData[TestDataLoader.acidnum_index]);
            color = Convert.ToDouble(rawData[TestDataLoader.color_index]);
            ift = Convert.ToDouble(rawData[TestDataLoader.ift_index]);
            if (c2h2 == 0)
                c2h4_c2h2 = Double.PositiveInfinity;
            else if (c2h2 < 0)
                c2h4_c2h2 = -1;
            else
                c2h4_c2h2 = (double)c2h4 / c2h2;
            if (ch4 == 0)
                c2h6_ch4 = Double.PositiveInfinity;
            else if (ch4 < 0)
                c2h6_ch4 = -1;
            else
                c2h6_ch4 = (double)c2h6 / ch4;
            o2_n2 = Convert.ToDouble(rawData[TestDataLoader.o2_n2_index]);
        }

        public string[] toStringArray() {
            string[] dataRow = new string[TestDataLoader.wantedIndices.Length];

            /*for (int i = 0; i < TestDataLoader.wantedIndices.Length; i++) {
                if(rawData[TestDataLoader.wantedIndices[i]].ToString().Equals("-1"))
                    dataRow[i] = "";
                else
                    dataRow[i] = rawData[TestDataLoader.wantedIndices[i]].ToString();
            }*/

            dataRow[0] = date;
            dataRow[1] = "" + opCount;
            dataRow[2] = "" + h2;
            dataRow[3] = "" + o2;
            dataRow[4] = "" + n2;
            dataRow[5] = "" + ch4;
            dataRow[6] = "" + co;
            dataRow[7] = "" + co2;
            dataRow[8] = "" + c2h4;
            dataRow[9] = "" + c2h6;
            dataRow[10] = "" + c2h2;
            dataRow[11] = "" + d1816_2;
            dataRow[12] = "" + furfural;
            dataRow[13] = string.Format("{0:0.000}", acidnum);
            dataRow[14] = "" + relsat;
            dataRow[15] = "" + water;
            dataRow[16] = visual;
            dataRow[17] = "" + color;
            dataRow[18] = "" + ift;
            dataRow[19] = string.Format("{0:0.000}", c2h4_c2h2);
            dataRow[20] = string.Format("{0:0.000}", c2h6_ch4);
            dataRow[21] = string.Format("{0:0.000}", o2_n2);

            for (int i = 0; i < dataRow.Length; i++)
                if (dataRow[i].Equals("-1") || dataRow[i].Equals("-1.000"))
                    dataRow[i] = "";

            return dataRow;
        }
    }
}

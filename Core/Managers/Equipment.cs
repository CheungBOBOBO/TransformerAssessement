using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerAssessment.Core.Managers
{
    class Equipment
    {
        public int equipID;
        public string substn_name;
        public string designation;


        public List<string[]> xfmrHeaders = null;
        public List<string[]> xfmrData = null;
        public List<string[]> ltcHeaders = null;
        public List<string[]> ltcData = null;
        public List<string[]> selHeaders = null;
        public List<string[]> selData = null;
        public List<string[]> divHeaders = null;
        public List<string[]> divData = null;

        public Equipment()
        {
            
        }
    }
}

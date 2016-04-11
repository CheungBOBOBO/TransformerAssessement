using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using E = TransformerAssessment.Core.Helpers.TOAExportLoader;

namespace TransformerAssessment.Core.Managers
{
    class Equipment
    {
        private int equipID;
        private string substn_name;
        private string designation;

        public List<string[]> xfmrHeaders = null;
        public List<string[]> xfmrData = null;
        public List<string[]> ltcHeaders = null;
        public List<string[]> ltcData = null;
        public List<string[]> selHeaders = null;
        public List<string[]> selData = null;
        public List<string[]> divHeaders = null;
        public List<string[]> divData = null;

        public Equipment(int id)
        {
            equipID = id;
        }

        #region [Methods] Getters
        public int getID() { return equipID; }
        public string getLocation() { return substn_name; }
        public string getDesignation() { return designation; }
        #endregion
    }
}

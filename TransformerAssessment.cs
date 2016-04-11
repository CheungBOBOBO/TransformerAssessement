using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Norms = TransformerAssessment.Core.Helpers.NormLoader;
using Exp = TransformerAssessment.Core.Helpers.TOAExportLoader;

namespace TransformerAssessment {
    static class TransformerAssessment {
        public static string normDir;
        public static string exportsDir;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            string PROGRAM_PATH = Application.StartupPath;
            
            // Get list of files in Sub-folders
            Norms.initializeNorms();
            Exp.initializeTOAExports();

            normDir = Norms.getNormsDir();
            string[] normList = Norms.getNormsPathList();
            exportsDir = Exp.getExportsDir();
            string[] toaExportsList = Exp.getTOAExportsList();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }
    }
}

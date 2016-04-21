using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerAssessment {
    static class TransformerAssessment {
        public static string normDir;
        public static string equipmentFile;
        public static string testDataFile;
        public static string PROGRAM_PATH;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            PROGRAM_PATH = Application.StartupPath;
            //Console.WriteLine("Program path: {0}", PROGRAM_PATH);


            // Get list of files in Sub-folders
            equipmentFile = Properties.Settings.Default.EquipmentFilePath;
            testDataFile = Properties.Settings.Default.TestDataFilePath;
            normDir = Properties.Settings.Default.NormFolderPath;

            /*NormLoader.initializeNorms();
            if (!string.IsNullOrWhiteSpace(equipmentFile))
                EquipmentLoader.initializeEquipment();
            if (!string.IsNullOrWhiteSpace(testDataFile))
            TestDataLoader.initializeTestData();
            */

            //normDir = NormLoader.getNormsDir();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHome());
        }
    }
}

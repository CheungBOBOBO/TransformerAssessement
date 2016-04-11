using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransformerAssessment.Core.Managers;

namespace TransformerAssessment.Core.Helpers {
    class NormLoader {
        private static string[] normsPathList;
        private static string normsDirectory;
        private static string[] fileNameList;
        private static Norm[] norms;
        
        public static void initializeNorms() {
            // try to load TOA Exports from default path "PROG_PATH/Norms"
            string PROG_PATH = Application.StartupPath;
            try {
                normsDirectory = Path.Combine(PROG_PATH, @"Norms");
                normsPathList = Directory.GetFiles(normsDirectory, "*.csv");
                fileNameList = new string[normsPathList.Length];
                for (int i = 0; i < normsPathList.Length; i++)
                    fileNameList[i] = Path.GetFileNameWithoutExtension(normsPathList[i]);
                createNorms(); 
            } catch (Exception e) {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
            }
        }

        public static void updateNorms(string folder) {
            normsDirectory = folder;
            normsPathList = Directory.GetFiles(normsDirectory, "*.csv");
            fileNameList = new string[normsPathList.Length];
            for (int i = 0; i < normsPathList.Length; i++)
                fileNameList[i] = Path.GetFileNameWithoutExtension(normsPathList[i]);
            createNorms();
        }

        private static void createNorms() {
            // create list of Norm objects from normsPathList
            norms = new Norm[normsPathList.Length];
            for (int i = 0; i < norms.Length; i++)
                norms[i] = new Norm(normsPathList[i]);
        }

        public static string[] getNormsPathList() { return normsPathList; }

        public static string getNormsDir() { return normsDirectory; }

        public static string[] getFileNameList() { return fileNameList; }

        public static Norm[] getNorms() { return norms; }
    }
}

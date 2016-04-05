using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransformerAssessment.Core.Managers;

namespace TransformerAssessment.Core.Helpers
{
    class TOAExportLoader
    {
        private static string[] exportsPathList;// array of file name + extention ("equipment.csv")
        private static string exportsDirectory; // folder location selected by default or by user
        private static string[] fileNameList;   // file names without extention ("equipment", "test data")
        private static TestData[] testData;     // list of TestData objects, each representing an individual test
        private static Equipment[] equipment;   // list of Equipment objects, each representing an individual piece of equipment
                                                //  (one transformer and respective LTC/SEL/DIV

        public static void initializeTOAExports()
        {
            // try to load TOA Exports from default path "PROG_PATH/TOAExports"
            string PROG_PATH = Application.StartupPath;
            try
            {
                exportsDirectory = Path.Combine(PROG_PATH, @"TOAExports");
                exportsPathList = Directory.GetFiles(exportsDirectory, "*.csv");
                fileNameList = new string[exportsPathList.Length];
                for (int i = 0; i < exportsPathList.Length; i++)
                {
                    fileNameList[i] = Path.GetFileNameWithoutExtension(exportsPathList[i]);
                }
                createEquipment();
                createTestData();
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPTION:\t" + e.Message);
            }
        }

        public static void updateTOAExports(string folder)
        {
            exportsDirectory = folder;
            exportsPathList = Directory.GetFiles(exportsDirectory, "*.csv");
            fileNameList = new string[exportsPathList.Length];
            for (int i = 0; i < exportsPathList.Length; i++)
                fileNameList[i] = Path.GetFileNameWithoutExtension(exportsPathList[i]);
            //createTOAExports();
        }

        private static void createTOAExports()
        {
            throw new NotImplementedException();
        }

        private static void createTestData()
        {
            // create list of Norm objects from normsPathList
            /*testData = new Norm[normsPathList.Length];
            for (int i = 0; i < norms.Length; i++)
                testData[i] = new Norm(normsPathList[i]);
             */
        }

        private static void createEquipment()
        {
            // create list of Norm objects from normsPathList
            /*norms = new Norm[normsPathList.Length];
            for (int i = 0; i < norms.Length; i++)
                norms[i] = new Norm(normsPathList[i]);
             */
        }

        public static string[] getTOAExportsList() { return exportsPathList; }

        public static string getExportsDir() { return exportsDirectory; }

        public static string[] getFileNameList() { return fileNameList; }

        public static TestData[] getTestData() { return testData; }

        public static Equipment[] getEquipment() { return equipment; }
    }
}

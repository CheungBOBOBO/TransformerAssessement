using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransformerAssessment;
using Norms = TransformerAssessment.Core.Helpers.NormLoader;
using Exports = TransformerAssessment.Core.Helpers.TOAExportLoader;
using TransformerAssessment.Core.Managers;
using System.IO;

namespace TransformerAssessment
{
    public partial class FormHome : Form
    {
        // DATA_SOURCES
        Norm[] _norms = Norms.getNorms();
        DataTable dt_Norms = new DataTable();

        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            tb_NormsFolder_BG.Text = TransformerAssessment.normDir;
            tb_ExportsFolder_BG.Text = TransformerAssessment.exportsDir;
            updateNormsListLB();
        }

        private void menu_Quit_Click(object sender, EventArgs e) { Application.Exit(); }

        private void menu_FolderSettings_Click(object sender, EventArgs e)
        {
            bringContentToFront(panel_Config);
        }

        private void button_NormsFolder_Click(object sender, EventArgs e)
        {
            TransformerAssessment.normDir = chooseNormFolder();
            Norms.updateNorms(TransformerAssessment.normDir);
            updateNormsListLB();
        }

        private void button_TOAExportsFolder_Click(object sender, EventArgs e)
        {
            TransformerAssessment.exportsDir = chooseExportsFolder();
            Exports.updateTOAExports(TransformerAssessment.exportsDir);
            chooseExportsFolder();
        }

        #region [Methods] - form support methods
        // brings up folder selection for location of Norm csv's
        public string chooseNormFolder()
        {
            DialogResult dr = openFolderDia.ShowDialog();
            if (dr == DialogResult.OK && validNormFolder(openFolderDia.SelectedPath))
                tb_NormsFolder_BG.Text = openFolderDia.SelectedPath;
            else
                tb_NormsFolder_BG.Text = TransformerAssessment.normDir;
            return tb_NormsFolder_BG.Text;
        }

        // brings up folder selection for location of TOA Exports csv's
        public string chooseExportsFolder()
        {
            DialogResult dr = openFolderDia.ShowDialog();
            if (dr == DialogResult.OK && validExportsFolder(openFolderDia.SelectedPath))
                tb_ExportsFolder_BG.Text = openFolderDia.SelectedPath;
            else
                tb_ExportsFolder_BG.Text = TransformerAssessment.exportsDir;
            return tb_ExportsFolder_BG.Text;
        }

        // returns false if no .csv files from selected folder
        public bool validNormFolder(string selectedPath)
        {
            string[] files = Directory.GetFiles(selectedPath, "*.csv");
            if (files.Length == 0)
            {
                MessageBox.Show("Selected folder does not contain any .csv files");
                return false;
            }
            return true;
        }

        public bool validExportsFolder(string selectedPath)
        {
            string[] files = Directory.GetFiles(selectedPath, "*.csv");
            if (files.Length < 2)
            {
                MessageBox.Show("Selected folder does not contain the required files\n   equipment.csv\n   test files.csv");
                return false;
            }
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            if (!files.Contains("equipment") || !files.Contains("test data"))
            {
                MessageBox.Show("Selected folder does not contain the required files\n   equipment.csv\n   test files.csv");
                return false;
            }
                return true;
        }

        private void bringContentToFront(Panel p)
        {
            p.BringToFront();
            for (int i = 0; i < p.Controls.Count; i++)
                p.Controls[i].BringToFront();
        }

        // update Norm List Box in Config tab
        private void updateNormsListLB()
        {
            lb_NormSelect.Items.Clear();
            for (int i = 0; i < Norms.getFileNameList().Length; i++)
                lb_NormSelect.Items.Add(Norms.getFileNameList()[i]);
            _norms = Norms.getNorms();
        }

        static string ConvertStringArrayToString(string[] array)
        {
            string result = string.Join("\t", array);
            return result;
        }

        static string ConvertStringArrayToString(double[] array)
        {
            string result = string.Join("\t", array);
            return result;
        }
        #endregion

        private void menu_Analyze_Click(object sender, EventArgs e)
        {
            bringContentToFront(panel_Analyze);
        }

        private void lb_NormSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lb_NormSelect.SelectedIndex;
            string selectedNormName = _norms[selectedIndex].name;
            Norm selectedNorm = _norms[selectedIndex];

            // edit GataGridView
            dt_Norms.Columns.Clear();
            dt_Norms.Rows.Clear();
            dt_Norms.Clear();
            for (int row = 0; row < selectedNorm.rawNorm.Count; row++)
            {
                if (row == 0)
                    for (int col = 1; col < selectedNorm.rawNorm[row].Length; col++)
                        dt_Norms.Columns.Add(selectedNorm.rawNorm[row][col]);
                else
                {
                    string[] temp = new string[selectedNorm.rawNorm[row].Length - 1];
                    for (int i = 1; i < selectedNorm.rawNorm[row].Length; i++)
                        temp[i - 1] = selectedNorm.rawNorm[row][i];
                    dt_Norms.Rows.Add(temp);
                }
            }
            dg_NormDisplay.DataSource = dt_Norms;
            foreach (DataGridViewRow row in dg_NormDisplay.Rows)
                row.HeaderCell.Value = selectedNorm.rawNorm[row.Index+1][0];
        }
    }
}

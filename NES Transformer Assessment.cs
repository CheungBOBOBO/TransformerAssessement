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
using TransformerAssessment.Core.Helpers;
using TransformerAssessment.Core.Managers;
using System.IO;

namespace TransformerAssessment {
    public partial class FormHome : Form {
        // DATA_SOURCES
        Norm[] _norms = NormLoader.getNorms();
        List<Transformer> _xfmrs = EquipmentLoader.getTransformers();

        DataTable dt_Norms = new DataTable();

        DataTable dt_Equipment = new DataTable();
        //BindingSource EquipmentSource = new BindingSource();

        public FormHome() {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e) {
            //EquipmentSource.DataSource = dt_Equipment;
            //dgv_EquipDisplay.DataSource = EquipmentSource;

            tb_NormsFolder_BG.Text = TransformerAssessment.normDir;
            tb_ExportsFolder_BG.Text = TransformerAssessment.exportsDir;
            updateNormsListLB();
            updateXFMR_CB();
        }

        private void menu_Quit_Click(object sender, EventArgs e) { 

            Application.Exit();
        }

        private void menu_FolderSettings_Click(object sender, EventArgs e) {
            bringContentToFront(panel_Config);
        }

        private void button_NormsFolder_Click(object sender, EventArgs e) {
            TransformerAssessment.normDir = chooseNormFolder();
            NormLoader.updateNorms(TransformerAssessment.normDir);
            updateNormsListLB();
        }

        private void button_TOAExportsFolder_Click(object sender, EventArgs e) {
            TransformerAssessment.exportsDir = chooseExportsFolder();
            EquipmentLoader.updateEquipment(TransformerAssessment.exportsDir);
            //chooseExportsFolder();
        }

        #region [Methods] - form support methods
        // brings up folder selection for location of Norm csv's
        public string chooseNormFolder() {
            DialogResult dr = openFolderDia.ShowDialog();
            if (dr == DialogResult.OK && validNormFolder(openFolderDia.SelectedPath))
                tb_NormsFolder_BG.Text = openFolderDia.SelectedPath;
            else
                tb_NormsFolder_BG.Text = TransformerAssessment.normDir;
            return tb_NormsFolder_BG.Text;
        }

        // brings up folder selection for location of TOA Exports csv's
        public string chooseExportsFolder()  {
            DialogResult dr = openFolderDia.ShowDialog();
            if (dr == DialogResult.OK && validExportsFolder(openFolderDia.SelectedPath))
                tb_ExportsFolder_BG.Text = openFolderDia.SelectedPath;
            else
                tb_ExportsFolder_BG.Text = TransformerAssessment.exportsDir;
            return tb_ExportsFolder_BG.Text;
        }

        // returns false if no .csv files from selected folder
        public bool validNormFolder(string selectedPath) {
            string[] files = Directory.GetFiles(selectedPath, "*.csv");
            if (files.Length == 0) {
                MessageBox.Show("Selected folder does not contain any .csv files");
                return false;
            }
            return true;
        }

        public bool validExportsFolder(string selectedPath) {
            string[] files = Directory.GetFiles(selectedPath, "*.csv");
            if (files.Length < 2) {
                MessageBox.Show("Selected folder does not contain the required files\n   equipment.csv\n   test files.csv");
                return false;
            }
            for (int i = 0; i < files.Length; i++)
                files[i] = Path.GetFileNameWithoutExtension(files[i]);
            if (!files.Contains("equipment") || !files.Contains("test data")) {
                MessageBox.Show("Selected folder does not contain the required files\n   equipment.csv\n   test files.csv");
                return false;
            }
                return true;
        }

        private void bringContentToFront(Panel p) {
            p.BringToFront();
            for (int i = 0; i < p.Controls.Count; i++)
                p.Controls[i].BringToFront();
        }

        // update Norm List Box in Config tab
        private void updateNormsListLB() {
            lb_NormSelect.Items.Clear();
            for (int i = 0; i < NormLoader.getFileNameList().Length; i++)
                lb_NormSelect.Items.Add(NormLoader.getFileNameList()[i]);
            _norms = NormLoader.getNorms();
        }

        // update Transformer selection Combo Boxes in Equipment tab
        private void updateXFMR_CB() {
            cb_xfmrSelection.Items.Clear();
            for (int i = 0; i < EquipmentLoader.getXFMRNameList().Length; i++)
                cb_xfmrSelection.Items.Add(EquipmentLoader.getXFMRNameList()[i]);
            _xfmrs = EquipmentLoader.getTransformers();
            if (cb_xfmrSelection.Items.Count > 0)
                cb_xfmrSelection.SelectedIndex = 0;
        }

        static string ConvertStringArrayToString(string[] array) {
            string result = string.Join("\t", array);
            return result;
        }

        static string ConvertStringArrayToString(double[] array) {
            string result = string.Join("\t", array);
            return result;
        }
        #endregion

        private void menu_Analyze_Click(object sender, EventArgs e) {
            bringContentToFront(panel_Analyze);
        }

        // When user selects a different norm index on Config Tab
        private void lb_NormSelect_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedIndex = lb_NormSelect.SelectedIndex;
            string selectedNormName = _norms[selectedIndex].name;
            Norm selectedNorm = _norms[selectedIndex];

            // edit GataGridView
            dt_Norms.Columns.Clear();
            dt_Norms.Rows.Clear();
            dt_Norms.Clear();
            for (int row = 0; row < selectedNorm.rawNorm.Count; row++) {
                if (row == 0)
                    for (int col = 1; col < selectedNorm.rawNorm[row].Length; col++)
                        dt_Norms.Columns.Add(selectedNorm.rawNorm[row][col]);
                else {
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

        // when new XFMR is selected on Equipment tab, clear the XFMR Equipment combo box
        // and populate with the selected XFMR's equipment
        private void cb_xfmrSelection_SelectedIndexChanged(object sender, EventArgs e) {
            cb_xfmrEquipSelect.Items.Clear();
            int selectedIndex = cb_xfmrSelection.SelectedIndex;

            List<string> xfmrEquipment = new List<string>();
            cb_xfmrEquipSelect.Items.Add("XFMR");
            if (_xfmrs[selectedIndex].hasLTC)
                cb_xfmrEquipSelect.Items.Add("LTC");
            if (_xfmrs[selectedIndex].hasSEL)
                cb_xfmrEquipSelect.Items.Add("SEL");
            if (_xfmrs[selectedIndex].hasDIV)
                cb_xfmrEquipSelect.Items.Add("DIV");

            // reset xfmr equipment index to zero
            if (cb_xfmrEquipSelect.Items.Count > 0)
                cb_xfmrEquipSelect.SelectedIndex = 0;

            // When this is executed, the EquipmentType Index also changes, so no need to call an update to the DataGrid in this method
        }

        private void cb_xfmrEquipSelect_SelectedIndexChanged(object sender, EventArgs e) {
            // update the data table
            updateEquipmentDataTable(cb_xfmrSelection.SelectedIndex, cb_xfmrEquipSelect.SelectedIndex);
        }

        private void updateEquipmentDataTable(int xfmrIndex, int xfmrEquipIndex) {
            Transformer selectedXFMR = _xfmrs[xfmrIndex];
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();

            //Console.WriteLine("Updating Equipment Table");

            dt_Equipment = new DataTable();
            dt_Equipment.Clear();   // clear DataTable
            for (int col = 0; col < TestDataLoader.headers.Length; col++)
                dt_Equipment.Columns.Add(TestDataLoader.headers[col]);
            // add rows of data to the grid (determine if selected index is XFMR, LTC, SEL, or DIV)
            // Selected XFMR
            if (equipmentType.Equals("XFMR"))
                for (int row = 0; row < selectedXFMR.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.data[row].rawData);
            // Selected LTC
            else if (equipmentType.Equals("LTC"))
                for (int row = 0; row < selectedXFMR.ltc.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.ltc.data[row].rawData);
            // Selected SEL
            else if (equipmentType.Equals("SEL"))
                for (int row = 0; row < selectedXFMR.sel.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.sel.data[row].rawData);
            // Selected DIV
            else if (equipmentType.Equals("DIV"))
                for (int row = 0; row < selectedXFMR.div.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.div.data[row].rawData);
            dgv_EquipDisplay.DataSource = dt_Equipment;
        }

        #region [Test Methods]
        
        #endregion
    }
}

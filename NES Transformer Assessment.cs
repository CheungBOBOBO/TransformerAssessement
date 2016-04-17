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
using LumenWorks.Framework.IO.Csv;

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
            if (!string.IsNullOrWhiteSpace(TransformerAssessment.normDir))
                NormLoader.initializeNorms();
            else
                System.Windows.Forms.MessageBox.Show("Norm folder is not valid. Please choose a valid folder.");

            if (!string.IsNullOrWhiteSpace(TransformerAssessment.equipmentFile))
                EquipmentLoader.initializeEquipment();
            if (!string.IsNullOrWhiteSpace(TransformerAssessment.equipmentFile) && !string.IsNullOrWhiteSpace(TransformerAssessment.testDataFile))
                TestDataLoader.initializeTestData();
            else
                System.Windows.Forms.MessageBox.Show("Equipment and/or Test Data files are not valid. Please choose a valid file.");
            TransformerAssessment.normDir = NormLoader.getNormsDir();
            //string[] normList = NormLoader.getNormsPathList();

            tb_NormsFolder_BG.Text = TransformerAssessment.normDir;
            tb_EquipmentFile_BG.Text = TransformerAssessment.equipmentFile;
            tb_TestDataFile_BG.Text = TransformerAssessment.testDataFile;
            updateNormsListLB();
            initializeEquipmentSelect();
        }

        private void menu_Quit_Click(object sender, EventArgs e) {
            Close();
            //Application.Exit();
        }

        private void menu_FolderSettings_Click(object sender, EventArgs e) {
            bringContentToFront(panel_Config);
        }

        private void button_NormsFolder_Click(object sender, EventArgs e) {
            TransformerAssessment.normDir = chooseNormFolder();
            NormLoader.updateNorms();
            updateNormsListLB();
        }

        private void button_EquipmentFile_Click(object sender, EventArgs e) {
            TransformerAssessment.equipmentFile = chooseEquipmentFile();
            EquipmentLoader.updateEquipment();
        }

        private void button_TestDataFile_Click(object sender, EventArgs e) {
            TransformerAssessment.testDataFile = chooseTestDataFile();
            EquipmentLoader.updateEquipment();
        }

        #region [Methods] - form support methods
        FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();
        // brings up folder selection for location of Norm csv's
        public string chooseNormFolder() {
            DialogResult dr = openFolderDialog.ShowDialog();
            if (dr == DialogResult.OK && validNormFolder(openFolderDialog.SelectedPath)) {
                tb_NormsFolder_BG.Text = openFolderDialog.SelectedPath;
                Properties.Settings.Default.NormFolderPath = openFolderDialog.SelectedPath;
                TransformerAssessment.equipmentFile = Properties.Settings.Default.NormFolderPath;
            }
            return tb_NormsFolder_BG.Text;
        }

        // brings up file selection for location of Equipment csv
        public string chooseEquipmentFile() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = TransformerAssessment.PROGRAM_PATH;
            openFileDialog.Title = "Choose an Equipment CSV";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK && validEquipmentFile(openFileDialog.FileName)) {
                tb_EquipmentFile_BG.Text = openFileDialog.FileName;
                Properties.Settings.Default.EquipmentFilePath = openFileDialog.FileName;
                TransformerAssessment.equipmentFile = Properties.Settings.Default.EquipmentFilePath;
            }
            return tb_EquipmentFile_BG.Text;
        }

        // brings up file selection for location of Test Data csv
        public string chooseTestDataFile() {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = TransformerAssessment.PROGRAM_PATH;
            openFileDialog.Title = "Choose a Test Data CSV";
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK && validTestDataFile(openFileDialog.FileName)) {
                tb_TestDataFile_BG.Text = openFileDialog.FileName;
                Properties.Settings.Default.TestDataFilePath = openFileDialog.FileName;
                TransformerAssessment.testDataFile = Properties.Settings.Default.TestDataFilePath;
            }
            return tb_TestDataFile_BG.Text;
        }

        #region [Methods] Folder/File Validation
        // returns false if no .csv files from selected folder
        public bool validNormFolder(string selectedPath) {
            string[] files = Directory.GetFiles(selectedPath, "*.csv");
            if (files.Length == 0) {
                MessageBox.Show("Selected folder does not contain any .csv files");
                return false;
            }
            return true;
        }

        public bool validEquipmentFile(string filePath) {
            // open the file "data.csv" which is a CSV file with headers
            using (CsvReader csv = new CsvReader(new StreamReader(filePath), true)) {
                string[] headers = csv.GetFieldHeaders();   // string[] of column headers
                return headers.Contains("region_name");   // if first row and column entry == equipnum, return true, else return false
            }
        }

        public bool validTestDataFile(string filePath) {
            // open the file "data.csv" which is a CSV file with headers
            using (CsvReader csv = new CsvReader(new StreamReader(filePath), true)) {
                string[] headers = csv.GetFieldHeaders();   // string[] of column headers
                return headers.Contains("labtestdate");   // if first row and column entry == equipnum, return true, else return false
            }
        }
        #endregion

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

        #region [Methods] Equipment DataGridView updates
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
            int xfmrIndex = cb_xfmrSelection.SelectedIndex;
            int xfmrEquipIndex = cb_xfmrEquipSelect.SelectedIndex;

            // update Selected Equipment text on Data tab
            l_SelectedEquipment.Text = string.Format("{0}  -  {1}  -  {2}", _xfmrs[xfmrIndex].getLocation(), _xfmrs[xfmrIndex].getPosition(), cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString());
            // update the data table
            updateEquipmentDataTable(xfmrIndex, xfmrEquipIndex);
        }

        private void updateEquipmentDataTable(int xfmrIndex, int xfmrEquipIndex) {
            Transformer selectedXFMR = _xfmrs[xfmrIndex];
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();

            dt_Equipment = new DataTable();
            dt_Equipment.Clear();   // clear DataTable

            for (int col = 0; col < TestDataLoader.wantedIndices.Length; col++)
                dt_Equipment.Columns.Add(TestDataLoader.headers[TestDataLoader.wantedIndices[col]]);
            // add rows of data to the grid (determine if selected index is XFMR, LTC, SEL, or DIV)
            // Selected XFMR
            if (equipmentType.Equals("XFMR"))
                for (int row = 0; row < selectedXFMR.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.data[row].toStringArray());
            // Selected LTC
            else if (equipmentType.Equals("LTC"))
                for (int row = 0; row < selectedXFMR.ltc.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.ltc.data[row].toStringArray());
            // Selected SEL
            else if (equipmentType.Equals("SEL"))
                for (int row = 0; row < selectedXFMR.sel.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.sel.data[row].toStringArray());
            // Selected DIV
            else if (equipmentType.Equals("DIV"))
                for (int row = 0; row < selectedXFMR.div.data.Count; row++)
                    dt_Equipment.Rows.Add(selectedXFMR.div.data[row].toStringArray());
            // set DataGridView to the new equipment's table
            dgv_EquipDisplay.DataSource = dt_Equipment;
        }

        public void initializeEquipmentSelect() {
            updateXFMR_CB();

            // fill in XFMR Equipment combobox
            cb_xfmrEquipSelect.Items.Clear();
            cb_xfmrEquipSelect.Items.Add("XFMR");
            if (_xfmrs[0].hasLTC)
                cb_xfmrEquipSelect.Items.Add("LTC");
            if (_xfmrs[0].hasSEL)
                cb_xfmrEquipSelect.Items.Add("SEL");
            if (_xfmrs[0].hasDIV)
                cb_xfmrEquipSelect.Items.Add("DIV");
            cb_xfmrEquipSelect.SelectedIndex = 0;

            // update Selected Equipment text on Data tab
            l_SelectedEquipment.Text = string.Format("{0}  -  {1}  -  {2}", _xfmrs[0].getLocation(), _xfmrs[0].getPosition(), cb_xfmrEquipSelect.Items[0].ToString());

            // update DataGridView
            updateEquipmentDataTable(0, 0);
        }
        #endregion

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void b_RefreshNorms_Click(object sender, EventArgs e) {
            NormLoader.updateNorms();
        }

        private void b_RefreshEquipment_Click(object sender, EventArgs e) {
            EquipmentLoader.updateEquipment();
        }

        private void b_RefreshTestData_Click(object sender, EventArgs e) {
            TestDataLoader.updateTestData();
        }

        #region [Test Methods]
        
        #endregion
    }
}

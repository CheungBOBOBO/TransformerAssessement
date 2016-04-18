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

        Label[][] gasLabels = new Label[5][];
        Label[][] fqLabels = new Label[5][];
        Label[][] moistLabels = new Label[5][];

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
                TransformerAssessment.normDir = Properties.Settings.Default.NormFolderPath;
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
                EquipmentLoader.updateEquipment();
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
                TestDataLoader.updateTestData();
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

            // update DataGridView
            updateEquipmentDataTable(selectedIndex, cb_xfmrEquipSelect.SelectedIndex);
            updateTOA(selectedIndex, cb_xfmrEquipSelect.SelectedIndex);
        }

        private void cb_xfmrEquipSelect_SelectedIndexChanged(object sender, EventArgs e) {
            int xfmrIndex = cb_xfmrSelection.SelectedIndex;
            int xfmrEquipIndex = cb_xfmrEquipSelect.SelectedIndex;

            // update the data table
            updateEquipmentDataTable(xfmrIndex, xfmrEquipIndex);
            updateTOA(xfmrIndex, xfmrEquipIndex);
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

            // update DataGridView & TOA tab
            updateEquipmentDataTable(0, 0);
            // create labels for TOA tables and then update them to the default XFMR
            createGasLabels();
            createFQLabels();
            createMoistureLabels();
            if (_xfmrs.Count > 0)
                updateTOA(0, 0);
        }
        #endregion

        #region [Methods] Updating TOA tab info
        private void updateTOA(int xfmrIndex, int xfmrEquipIndex) {
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();
            // update Selected Equipment text on Data tab
            l_SelectedEquipment.Text = string.Format("{0}  -  {1}  -  {2}", _xfmrs[xfmrIndex].getLocation(), _xfmrs[xfmrIndex].getPosition(), cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString());
            
            updateFluidReport(xfmrIndex, xfmrEquipIndex);
            updateGasAnalysis(xfmrIndex, xfmrEquipIndex);
            updateFluidQuality(xfmrIndex, xfmrEquipIndex);
            updateMoisture(xfmrIndex, xfmrEquipIndex);
        }

        // Update FLUID ANALYSIS REPORT table
        private void updateFluidReport(int xfmrIndex, int xfmrEquipIndex) {
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();

            l_equipNum.Text = _xfmrs[xfmrIndex].getID();
            l_serialNum.Text = _xfmrs[xfmrIndex].serialNum;
            // Selected XFMR
            if (equipmentType.Equals("XFMR")) {
                l_norm.Text = _xfmrs[xfmrIndex].norm;
                l_mfr.Text = _xfmrs[xfmrIndex].manufacturer;
                l_yearMfg.Text = _xfmrs[xfmrIndex].yearMade;
                l_model.Text = "";
                l_oilPresType.Text = _xfmrs[xfmrIndex].oilPresType;
                l_remarks.Text = _xfmrs[xfmrIndex].remarks;
                l_opsCount.Text = "";
            } // Selected LTC
            else if (equipmentType.Equals("LTC")) {
                l_norm.Text = _xfmrs[xfmrIndex].ltc.norm;
                l_mfr.Text = _xfmrs[xfmrIndex].ltc.manufacturer;
                l_yearMfg.Text = _xfmrs[xfmrIndex].ltc.yearMade;
                l_model.Text = _xfmrs[xfmrIndex].ltc.model;
                l_oilPresType.Text = _xfmrs[xfmrIndex].ltc.oilPresType;
                l_remarks.Text = _xfmrs[xfmrIndex].ltc.remarks;
                l_opsCount.Text = string.Format("{0:N0}", _xfmrs[xfmrIndex].ltc.data[0].opCount);
            } // Selected SEL
            else if (equipmentType.Equals("SEL")) {
                l_norm.Text = _xfmrs[xfmrIndex].sel.norm;
                l_mfr.Text = _xfmrs[xfmrIndex].sel.manufacturer;
                l_yearMfg.Text = _xfmrs[xfmrIndex].sel.yearMade;
                l_model.Text = _xfmrs[xfmrIndex].sel.model;
                l_oilPresType.Text = _xfmrs[xfmrIndex].sel.oilPresType;
                l_remarks.Text = _xfmrs[xfmrIndex].sel.remarks;
                l_opsCount.Text = string.Format("{0:N0}", _xfmrs[xfmrIndex].sel.data[0].opCount);
            } // Selected DIV
            else if (equipmentType.Equals("DIV")) {
                l_norm.Text = _xfmrs[xfmrIndex].div.norm;
                l_mfr.Text = _xfmrs[xfmrIndex].div.manufacturer;
                l_yearMfg.Text = _xfmrs[xfmrIndex].div.yearMade;
                l_model.Text = _xfmrs[xfmrIndex].div.model;
                l_oilPresType.Text = _xfmrs[xfmrIndex].div.oilPresType;
                l_remarks.Text = _xfmrs[xfmrIndex].div.remarks;
                l_opsCount.Text = string.Format("{0:N0}", _xfmrs[xfmrIndex].div.data[0].opCount);
            }
            if (l_opsCount.Text.Equals("-1"))
                l_opsCount.Text = "Not Recorded";
        }

        // Update GAS ANALYSIS table
        private void updateGasAnalysis(int xfmrIndex, int xfmrEquipIndex) {
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();
            // Selected XFMR
            if (equipmentType.Equals("XFMR")) {
                if (_xfmrs[xfmrIndex].data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int gasColIndex = 0;
                int xfmrDataIndex = 0;
                while (gasColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].data.Count) {
                        for (int row = 0; row < gasLabels[gasColIndex].Length; row++)
                            gasLabels[gasColIndex][row].Text = "";
                        gasColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].data[xfmrDataIndex].hasGasData) {
                            gasLabels[gasColIndex][0].Text = _xfmrs[xfmrIndex].data[xfmrDataIndex].date;
                            gasLabels[gasColIndex][1].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].temp);
                            gasLabels[gasColIndex][2].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].h2);
                            gasLabels[gasColIndex][3].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].ch4);
                            gasLabels[gasColIndex][4].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].c2h6);
                            gasLabels[gasColIndex][5].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].c2h4);
                            gasLabels[gasColIndex][6].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].c2h2);
                            gasLabels[gasColIndex][7].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].co);
                            gasLabels[gasColIndex][8].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].co2);
                            gasLabels[gasColIndex][9].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].o2);
                            gasLabels[gasColIndex][10].Text = string.Format("{0}",_xfmrs[xfmrIndex].data[xfmrDataIndex].n2);
                            gasLabels[gasColIndex][11].Text = string.Format("{0:0.000}",_xfmrs[xfmrIndex].data[xfmrDataIndex].o2_n2);
                            // go to next column on gas analysis
                            gasColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected LTC
            else if (equipmentType.Equals("LTC")) {
                if (_xfmrs[xfmrIndex].ltc.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int gasColIndex = 0;
                int xfmrDataIndex = 0;
                while (gasColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].ltc.data.Count) {
                        for (int row = 0; row < gasLabels[gasColIndex].Length; row++)
                            gasLabels[gasColIndex][row].Text = "";
                        gasColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].hasGasData) {
                            gasLabels[gasColIndex][0].Text = _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].date;
                            gasLabels[gasColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].temp);
                            gasLabels[gasColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].h2);
                            gasLabels[gasColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].ch4);
                            gasLabels[gasColIndex][4].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].c2h6);
                            gasLabels[gasColIndex][5].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].c2h4);
                            gasLabels[gasColIndex][6].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].c2h2);
                            gasLabels[gasColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].co);
                            gasLabels[gasColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].co2);
                            gasLabels[gasColIndex][9].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].o2);
                            gasLabels[gasColIndex][10].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].n2);
                            gasLabels[gasColIndex][11].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].o2_n2);
                            // go to next column on gas analysis
                            gasColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected SEL
            else if (equipmentType.Equals("SEL")) {
                if (_xfmrs[xfmrIndex].sel.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int gasColIndex = 0;
                int xfmrDataIndex = 0;
                while (gasColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].sel.data.Count) {
                        for (int row = 0; row < gasLabels[gasColIndex].Length; row++)
                            gasLabels[gasColIndex][row].Text = "";
                        gasColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].sel.data[xfmrDataIndex].hasGasData) {
                            gasLabels[gasColIndex][0].Text = _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].date;
                            gasLabels[gasColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].temp);
                            gasLabels[gasColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].h2);
                            gasLabels[gasColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].ch4);
                            gasLabels[gasColIndex][4].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].c2h6);
                            gasLabels[gasColIndex][5].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].c2h4);
                            gasLabels[gasColIndex][6].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].c2h2);
                            gasLabels[gasColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].co);
                            gasLabels[gasColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].co2);
                            gasLabels[gasColIndex][9].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].o2);
                            gasLabels[gasColIndex][10].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].n2);
                            gasLabels[gasColIndex][11].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].o2_n2);
                            // go to next column on gas analysis
                            gasColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected DIV
            else if (equipmentType.Equals("DIV")) {
                if (_xfmrs[xfmrIndex].div.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int gasColIndex = 0;
                int xfmrDataIndex = 0;
                while (gasColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].div.data.Count) {
                        for (int row = 0; row < gasLabels[gasColIndex].Length; row++)
                            gasLabels[gasColIndex][row].Text = "";
                        gasColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].div.data[xfmrDataIndex].hasGasData) {
                            gasLabels[gasColIndex][0].Text = _xfmrs[xfmrIndex].div.data[xfmrDataIndex].date;
                            gasLabels[gasColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].temp);
                            gasLabels[gasColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].h2);
                            gasLabels[gasColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].ch4);
                            gasLabels[gasColIndex][4].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].c2h6);
                            gasLabels[gasColIndex][5].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].c2h4);
                            gasLabels[gasColIndex][6].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].c2h2);
                            gasLabels[gasColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].co);
                            gasLabels[gasColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].co2);
                            gasLabels[gasColIndex][9].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].o2);
                            gasLabels[gasColIndex][10].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].n2);
                            gasLabels[gasColIndex][11].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].o2_n2);
                            // go to next column on gas analysis
                            gasColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            }
            // Turn any '-1' into an empty string
            for (int col = 0; col < gasLabels.Length; col++) {
                for (int row = 0; row < gasLabels[0].Length; row++) {
                    if (gasLabels[col][row].Text.Equals("-1"))
                        gasLabels[col][row].Text = "";
                }
            }
        }

        // Update FLUID QUALITY table
        private void updateFluidQuality(int xfmrIndex, int xfmrEquipIndex) {
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();
            // Selected XFMR
            if (equipmentType.Equals("XFMR")) {
                if (_xfmrs[xfmrIndex].data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int fqColIndex = 0;
                int xfmrDataIndex = 0;
                while (fqColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].data.Count) {
                        for (int row = 0; row < fqLabels[fqColIndex].Length; row++)
                            fqLabels[fqColIndex][row].Text = "";
                        fqColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].data[xfmrDataIndex].hasFQData) {
                            fqLabels[fqColIndex][0].Text = _xfmrs[xfmrIndex].data[xfmrDataIndex].date;
                            fqLabels[fqColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].temp);
                            fqLabels[fqColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].d1816_2);
                            fqLabels[fqColIndex][3].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].data[xfmrDataIndex].acidnum);
                            fqLabels[fqColIndex][4].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].ift);
                            fqLabels[fqColIndex][5].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].data[xfmrDataIndex].spGrav);
                            fqLabels[fqColIndex][6].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].color);
                            fqLabels[fqColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].visual);
                            fqLabels[fqColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].water);
                            // go to next column on gas analysis
                            fqColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected LTC
            else if (equipmentType.Equals("LTC")) {
                if (_xfmrs[xfmrIndex].ltc.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int fqColIndex = 0;
                int xfmrDataIndex = 0;
                while (fqColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].ltc.data.Count) {
                        for (int row = 0; row < fqLabels[fqColIndex].Length; row++)
                            fqLabels[fqColIndex][row].Text = "";
                        fqColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].hasFQData) {
                            fqLabels[fqColIndex][0].Text = _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].date;
                            fqLabels[fqColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].temp);
                            fqLabels[fqColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].d1816_2);
                            fqLabels[fqColIndex][3].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].acidnum);
                            fqLabels[fqColIndex][4].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].ift);
                            fqLabels[fqColIndex][5].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].spGrav);
                            fqLabels[fqColIndex][6].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].color);
                            fqLabels[fqColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].visual);
                            fqLabels[fqColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].water);
                            // go to next column on gas analysis
                            fqColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected SEL
            else if (equipmentType.Equals("SEL")) {
                if (_xfmrs[xfmrIndex].sel.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int fqColIndex = 0;
                int xfmrDataIndex = 0;
                while (fqColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].sel.data.Count) {
                        for (int row = 0; row < fqLabels[fqColIndex].Length; row++)
                            fqLabels[fqColIndex][row].Text = "";
                        fqColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].sel.data[xfmrDataIndex].hasFQData) {
                            fqLabels[fqColIndex][0].Text = _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].date;
                            fqLabels[fqColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].temp);
                            fqLabels[fqColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].d1816_2);
                            fqLabels[fqColIndex][3].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].acidnum);
                            fqLabels[fqColIndex][4].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].ift);
                            fqLabels[fqColIndex][5].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].spGrav);
                            fqLabels[fqColIndex][6].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].color);
                            fqLabels[fqColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].visual);
                            fqLabels[fqColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].water);
                            // go to next column on gas analysis
                            fqColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected DIV
            else if (equipmentType.Equals("DIV")) {
                if (_xfmrs[xfmrIndex].div.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int fqColIndex = 0;
                int xfmrDataIndex = 0;
                while (fqColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].div.data.Count) {
                        for (int row = 0; row < fqLabels[fqColIndex].Length; row++)
                            fqLabels[fqColIndex][row].Text = "";
                        fqColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].div.data[xfmrDataIndex].hasGasData) {
                            fqLabels[fqColIndex][0].Text = _xfmrs[xfmrIndex].div.data[xfmrDataIndex].date;
                            fqLabels[fqColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].temp);
                            fqLabels[fqColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].d1816_2);
                            fqLabels[fqColIndex][3].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].acidnum);
                            fqLabels[fqColIndex][4].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].ift);
                            fqLabels[fqColIndex][5].Text = string.Format("{0:0.000}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].spGrav);
                            fqLabels[fqColIndex][6].Text = string.Format("{0:0.0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].color);
                            fqLabels[fqColIndex][7].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].visual);
                            fqLabels[fqColIndex][8].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].water);
                            // go to next column on gas analysis
                            fqColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            }
            // Turn any '-1' into an empty string
            for (int col = 0; col < fqLabels.Length; col++) {
                for (int row = 0; row < fqLabels[0].Length; row++) {
                    if (fqLabels[col][row].Text.Equals("-1"))
                        fqLabels[col][row].Text = "";
                }
            }
        }

        // Update MOISTURE table
        private void updateMoisture(int xfmrIndex, int xfmrEquipIndex) {
            string equipmentType = cb_xfmrEquipSelect.Items[xfmrEquipIndex].ToString();
            // Selected XFMR
            if (equipmentType.Equals("XFMR")) {
                if (_xfmrs[xfmrIndex].data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int moistColIndex = 0;
                int xfmrDataIndex = 0;
                while (moistColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].data.Count) {
                        for (int row = 0; row < moistLabels[moistColIndex].Length; row++)
                            moistLabels[moistColIndex][row].Text = "";
                        moistColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].data[xfmrDataIndex].hasMoistureData) {
                            moistLabels[moistColIndex][0].Text = _xfmrs[xfmrIndex].data[xfmrDataIndex].date;
                            moistLabels[moistColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].temp);
                            moistLabels[moistColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].water);
                            moistLabels[moistColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].data[xfmrDataIndex].relSat);
                            // go to next column on gas analysis
                            moistColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected LTC
            else if (equipmentType.Equals("LTC")) {
                if (_xfmrs[xfmrIndex].ltc.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int moistColIndex = 0;
                int xfmrDataIndex = 0;
                while (moistColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].ltc.data.Count) {
                        for (int row = 0; row < moistLabels[moistColIndex].Length; row++)
                            moistLabels[moistColIndex][row].Text = "";
                        moistColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].hasMoistureData) {
                            moistLabels[moistColIndex][0].Text = _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].date;
                            moistLabels[moistColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].temp);
                            moistLabels[moistColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].water);
                            moistLabels[moistColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].ltc.data[xfmrDataIndex].relSat);
                            // go to next column on gas analysis
                            moistColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected SEL
            else if (equipmentType.Equals("SEL")) {
                if (_xfmrs[xfmrIndex].sel.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int moistColIndex = 0;
                int xfmrDataIndex = 0;
                while (moistColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].sel.data.Count) {
                        for (int row = 0; row < moistLabels[moistColIndex].Length; row++)
                            moistLabels[moistColIndex][row].Text = "";
                        moistColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].sel.data[xfmrDataIndex].hasMoistureData) {
                            moistLabels[moistColIndex][0].Text = _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].date;
                            moistLabels[moistColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].temp);
                            moistLabels[moistColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].water);
                            moistLabels[moistColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].sel.data[xfmrDataIndex].relSat);
                            // go to next column on gas analysis
                            moistColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            } // Selected DIV
            else if (equipmentType.Equals("DIV")) {
                if (_xfmrs[xfmrIndex].div.data.Count == 0) {
                    resetTOALabels();
                    return;
                }
                int moistColIndex = 0;
                int xfmrDataIndex = 0;
                while (moistColIndex < 5) {
                    // if we've run out of tests... 
                    if (xfmrDataIndex >= _xfmrs[xfmrIndex].div.data.Count) {
                        for (int row = 0; row < moistLabels[moistColIndex].Length; row++)
                            moistLabels[moistColIndex][row].Text = "";
                        moistColIndex++;
                    } else {
                        // not out of tests...
                        // is test that has Gas Data
                        if (_xfmrs[xfmrIndex].div.data[xfmrDataIndex].hasGasData) {
                            moistLabels[moistColIndex][0].Text = _xfmrs[xfmrIndex].div.data[xfmrDataIndex].date;
                            moistLabels[moistColIndex][1].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].temp);
                            moistLabels[moistColIndex][2].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].water);
                            moistLabels[moistColIndex][3].Text = string.Format("{0}", _xfmrs[xfmrIndex].div.data[xfmrDataIndex].relSat);
                            // go to next column on gas analysis
                            moistColIndex++;
                        }
                    }
                    xfmrDataIndex++;
                }
            }
            // Turn any '-1' into an empty string
            for (int col = 0; col < moistLabels.Length; col++) {
                for (int row = 1; row < moistLabels[0].Length; row++) {
                    if (moistLabels[col][row].Text.Equals("") || Convert.ToInt32(moistLabels[col][row].Text) == -1)
                        moistLabels[col][row].Text = "";
                }
            }
        }

        // initialize GAS labels in the TableLayoutPanel for Gas Analysis
        private void createGasLabels() {
            int NUM_ROWS = 12;
            // create labels to go with each column
            for (int i = 0; i < gasLabels.Length; i++) {
                gasLabels[i] = new Label[NUM_ROWS];
            }
            // assign attributes to each label
            for (int col = 0; col < gasLabels.Length; col++) {
                for (int row = 0; row < gasLabels[0].Length; row++) {
                    gasLabels[col][row] = new System.Windows.Forms.Label(); // create the label
                    if (row == 0) {
                        gasLabels[col][row].Anchor = System.Windows.Forms.AnchorStyles.None;
                        gasLabels[col][row].AutoSize = true;
                        gasLabels[col][row].Text = string.Format("{0},{1}", col, row);
                        gasLabels[col][row].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    } else {
                        gasLabels[col][row].Anchor = System.Windows.Forms.AnchorStyles.Right;
                        gasLabels[col][row].AutoSize = true;
                        gasLabels[col][row].Text = string.Format("{0},{1}", col, row);
                        gasLabels[col][row].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    }
                    tlp_TOA_gasAnalysis.Controls.Add(gasLabels[col][row], col+1, row);  // assign it to a spot on the gas analysis chart
                }
            }
        }

        // initialize FLUID QUALITY labels in the TableLayoutPanel for FQ Analysis
        private void createFQLabels() {
            int NUM_ROWS = 9;
            // create labels to go with each column
            for (int i = 0; i < fqLabels.Length; i++) {
                fqLabels[i] = new Label[NUM_ROWS];
            }
            // assign attributes to each label
            for (int col = 0; col < fqLabels.Length; col++) {
                for (int row = 0; row < fqLabels[0].Length; row++) {
                    fqLabels[col][row] = new System.Windows.Forms.Label(); // create the label
                    if (row == 0) {
                        fqLabels[col][row].Anchor = System.Windows.Forms.AnchorStyles.None;
                        fqLabels[col][row].AutoSize = true;
                        fqLabels[col][row].Text = string.Format("{0},{1}", col, row);
                        fqLabels[col][row].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    } else {
                        fqLabels[col][row].Anchor = System.Windows.Forms.AnchorStyles.Right;
                        fqLabels[col][row].AutoSize = true;
                        fqLabels[col][row].Text = string.Format("{0},{1}", col, row);
                        fqLabels[col][row].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    }
                    tlp_TOA_FluidQuality.Controls.Add(fqLabels[col][row], col + 1, row);  // assign it to a spot on the gas analysis chart
                }
            }
        }

        // initialize MOISTURE labels in the TableLayoutPanel for Moisture Analysis
        private void createMoistureLabels() {
            int NUM_ROWS = 4;
            // create labels to go with each column
            for (int i = 0; i < moistLabels.Length; i++) {
                moistLabels[i] = new Label[NUM_ROWS];
            }
            // assign attributes to each label
            for (int col = 0; col < moistLabels.Length; col++) {
                for (int row = 0; row < moistLabels[0].Length; row++) {
                    moistLabels[col][row] = new System.Windows.Forms.Label(); // create the label
                    if (row == 0) {
                        moistLabels[col][row].Anchor = System.Windows.Forms.AnchorStyles.None;
                        moistLabels[col][row].AutoSize = true;
                        moistLabels[col][row].Text = string.Format("{0},{1}", col, row);
                        moistLabels[col][row].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    } else {
                        moistLabels[col][row].Anchor = System.Windows.Forms.AnchorStyles.Right;
                        moistLabels[col][row].AutoSize = true;
                        moistLabels[col][row].Text = string.Format("{0},{1}", col, row);
                        moistLabels[col][row].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    }
                    tlp_TOA_Moisture.Controls.Add(moistLabels[col][row], col + 1, row);  // assign it to a spot on the gas analysis chart
                }
            }
        }

        // reset the labels in the TOA tab tables
        private void resetTOALabels() {
            for (int col = 0; col < gasLabels.Length; col++) {
                for (int row = 0; row < gasLabels.Length; row++) {
                    gasLabels[col][row].Text = "";
                }
            }
            for (int col = 0; col < fqLabels.Length; col++) {
                for (int row = 0; row < fqLabels.Length; row++) {
                    fqLabels[col][row].Text = "";
                }
            }
            for (int col = 0; col < moistLabels.Length; col++) {
                for (int row = 0; row < moistLabels.Length; row++) {
                    moistLabels[col][row].Text = "";
                }
            }
        }
        #endregion

        private void FormHome_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.Save();
        }

        private void b_RefreshNorms_Click(object sender, EventArgs e) {
            NormLoader.updateNorms();
            updateNormsListLB();
        }

        private void b_RefreshEquipment_Click(object sender, EventArgs e) {
            EquipmentLoader.updateEquipment();
            TestDataLoader.updateTestData();
            _xfmrs = EquipmentLoader.getTransformers();
        }

        private void b_RefreshTestData_Click(object sender, EventArgs e) {
            TestDataLoader.updateTestData();
        }

        private void tlp_Data_MouseEnter(object sender, EventArgs e) {
            panel_TOA_center.Focus();
        }


        #region [Test Methods]
        
        #endregion
    }
}

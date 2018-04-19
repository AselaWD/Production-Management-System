using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductionManagementSystem.BusinessObjects;
using ProductionManagementSystem.BusinessService;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using System.Data.OleDb;
using System.Configuration;

namespace ProductionManagementSystem
{
    public partial class frm_DCDImport : Form
    {
        SqlConnection conn;

        public frm_DCDImport()
        {
            InitializeComponent();
        }

        private void frm_DCDImport_Load(object sender, EventArgs e)
        {
            
            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();
            cmbShipmentName.DataSource = new ShipmentHeaderMng(this.conn).GetAllShipmentByName();
            removeButtonDisable();
            RefreshData();
            cmbShipmentName.Text = "";
            cmbPDTeam.Text = "";
            dataGridViewDCDInventory.Text = "";
            btnImport.Enabled = false;
            btnSave.Enabled = false;
            btnRefresh.Enabled = false;
            btnNew.TabIndex=0;

        }

        private void RefreshData()
        {

            ShipmentDetailMng mShipment = new ShipmentDetailMng(conn);
            cmbShipmentName.DataSource = new ShipmentHeaderMng(this.conn).GetAllShipmentByName();
            cmbPDTeam.DataSource = new UserTeamMng(this.conn).GetAllUserTeam();
            DataTable table = mShipment.GetAllShipments();
            dataGridViewDCDInventory.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = @"Desktop\";
            openFileDialog1.Title = "Import New Shipment";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "xls";
            openFileDialog1.Filter = "Excel files (*.xls)|*.xlsx";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                string filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath);
                string fNameOnly = Path.GetFileNameWithoutExtension(filePath);
                string conString = "";
                string sheetName = "";
                int rowCount;

                switch (extension)
                {
                    case ".xls":
                        conString = string.Format(Excel03ConString, filePath, "YES");
                        break;
                    case ".xlsx":
                        conString = string.Format(Excel07ConString, filePath, "YES");
                        break;
                }
                using (OleDbConnection con = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dt = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dt.Rows[0]["Table_Name"].ToString();

                        con.Close();
                    }
                }
                using (OleDbConnection con = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        OleDbDataAdapter oda = new OleDbDataAdapter();
                        cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        oda.Fill(dt);

                        //Count the Lines
                        rowCount = dt.Rows.Count;

                        con.Close();

                        //Fill Data to the grid
                        dataGridViewDCDImport.DataSource = dt;

                        //Fill data to Fields
                        cmbShipmentName.Text = fNameOnly;
                        lblImportPath.Text = filePath;
                        lblFileCount.Text = rowCount.ToString();
                    }
                }

            }

            btnImport.Enabled = false;
            btnSave.Enabled = true;
            btnSave.Focus();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{

                DialogResult result;
                result = MessageBox.Show("Do you really want to register this shipment?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (cmbShipmentName.Text != "")
                {
                    if (cmbPDTeam.Text != "")
                    {
                        if (result == DialogResult.Yes)
                        {
                            if (dataGridViewDCDImport.DataSource != null)
                            {
                                //Create Object From User Object
                                ShipmetDetail mShDetail = new ShipmetDetail();
                                ShipmentHeader mShHeader = new ShipmentHeader();
                                ShipmentDetailFormats mShFormats = new ShipmentDetailFormats();

                                ShipmentHeaderMng ShHeader = new ShipmentHeaderMng(conn);
                                ShipmentDetailMng ShDetail = new ShipmentDetailMng(conn);
                                ShipmentDetailFormatsMng ShFormats = new ShipmentDetailFormatsMng(conn);

                                mShHeader.ShipmentID = cmbShipmentName.Text;
                                mShHeader.DownloadedDate = dateTimePickerDCDImport.Value;
                                mShHeader.FileCount = int.Parse(lblFileCount.Text.ToString());

                                if (ShHeader.AddShipmentHeader(mShHeader) > 0)
                                {
                                    //Loop until total Shipment File Count Registerd into the ShipmentDetails Tabele
                                    for (int i = 0; i < dataGridViewDCDImport.Rows.Count; i++)
                                    {
                                        //Load Selected Grid Row to frm_EditImportedFile for Edit
                                        // int rowIndex = dataGridViewDCDImport.CurrentRow.Index;

                                        string sISBN = dataGridViewDCDImport.Rows[i].Cells[0].Value.ToString();
                                        string sdISBN = dataGridViewDCDImport.Rows[i].Cells[1].Value.ToString();
                                        string stxtBookTitle = dataGridViewDCDImport.Rows[i].Cells[2].Value.ToString();
                                        string stxtAuthor = dataGridViewDCDImport.Rows[i].Cells[3].Value.ToString();
                                        string stxtAuthor1 = dataGridViewDCDImport.Rows[i].Cells[4].Value.ToString();
                                        int sPageCount = int.Parse(dataGridViewDCDImport.Rows[i].Cells[5].Value.ToString());
                                        DateTime sPubDate = DateTime.Parse(dataGridViewDCDImport.Rows[i].Cells[6].Value.ToString());
                                        string sPublisher = dataGridViewDCDImport.Rows[i].Cells[7].Value.ToString();
                                        string sLanguage = dataGridViewDCDImport.Rows[i].Cells[8].Value.ToString();
                                        string sFormat = dataGridViewDCDImport.Rows[i].Cells[9].Value.ToString();
                                        string sComment = dataGridViewDCDImport.Rows[i].Cells[10].Value.ToString();
                                        string sTeam = cmbPDTeam.Text;



                                        // Assign User Interface data to User Object
                                        mShDetail.DownloadedDate = dateTimePickerDCDImport.Value;
                                        mShDetail.ID = cmbShipmentName.Text;
                                        mShDetail.Publisher = sPublisher;
                                        mShDetail.ISBN = sISBN;
                                        mShDetail.DISBN = sdISBN;
                                        mShDetail.Title = stxtBookTitle;
                                        mShDetail.Author = stxtAuthor;
                                        mShDetail.Author1 = stxtAuthor1;
                                        mShDetail.PageCount = sPageCount;
                                        mShDetail.PubDate = sPubDate;
                                        mShDetail.Language = sLanguage;
                                        mShDetail.Format = sFormat;
                                        mShDetail.Comment = sComment;
                                        mShDetail.DateOfAllocation = dateTimePickerAllocatedDate.Value;
                                        mShDetail.Team = sTeam;
                                        mShDetail.TATDelivery = 0;
                                        mShDetail.ProductionDone = 0;
                                        mShDetail.QRDone = 0;
                                        mShDetail.TransmissionDone = 0;
                                        mShDetail.ClientFeedback = 0;


                                        if (ShDetail.AddSipmentFile(mShDetail) > 0)
                                        {

                                            // For each uutput formats dedicate a column
                                            //string fePub
                                            //string fMobi
                                            //string fWEB
                                            //string fDoc
                                            //string fAFF For Apple Fixed Book
                                            //string fKF8 For Kindle Fixed Book
                                            //string fKCC For Kindle Comic Book
                                            //string fePib For B&N Fixed Book

                                            mShFormats.ShipmentID = cmbShipmentName.Text;
                                            mShFormats.ShpID = ShDetail.GetLastID();
                                            List<String> LFormat = ShFormats.GetAllFormats();
                                            mShFormats.ProductionStatus = "Not Assigned";


                                            var s1 = sFormat.Split('/');
                                            for (int x = 0; x < s1.Length; x++)
                                            {
                                                for (int y = 0; y < LFormat.Count(); y++)
                                                {
                                                    if (s1[x].ToString() == LFormat[y])
                                                    {
                                                        mShFormats.FormatName = LFormat[y].ToString();
                                                    }

                                                }

                                                ShFormats.AddShimpentFormats(mShFormats);

                                            }

                                        }

                                    }

                                    MessageBox.Show("New Shipment been registered..!\n\nShipment Name: " + mShDetail.ID + "\nTotal File(s): " + (dataGridViewDCDImport.Rows.Count), "Shipment Registerd", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //Clear Header Details registered after shipment
                                    dataGridViewDCDImport.DataSource = null;
                                    lblFileCount.Text = "";
                                    lblImportPath.Text = "";
                                    dataGridViewDCDInventory.Focus();
                                    RefreshData();
                                    cmbShipmentName.Text = "";
                                    btnImport.Enabled = false;
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is no new Shipment to import! \nPlease import provided excel file.", "Empty Shipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btnImport.Focus();
                            }
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a Team to allocate shipment!", "Empty Team", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbPDTeam.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("There is no Shipment to import!.", "Empty Shipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbShipmentName.Focus();
                }
                
                
            }
            catch (Exception ex){
                if (ex.HResult == -2146232060)
                {
                    MessageBox.Show("This shipment is already imported..!\n Please check shipment name again.", "Cannot Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

        }

        private void label_DcdInventory_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }


        public void dataGridViewdataGridViewDCDImport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //This has moved to DCDInventory
        }


        public void dataGridViewDCDImport_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDCDImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControlDCDImport_Click(object sender, EventArgs e)
        {

            if (tabControlDCDImport.SelectedTab == tabPageImportShipment)
            {
                //removeButtonEnable();
                btnNew.Enabled = true;
                cmbShipmentName.Text = "";
                cmbPDTeam.Text = "";
                dataGridViewDCDInventory.Text = "";
                dataGridViewDCDImport.DataSource = "";
                lblFileCount.Text = "";
                lblImportPath.Text = "";
                btnImport.Enabled = false;
                btnSave.Enabled = false;
                btnRefresh.Enabled = false;
                btnRemove.Enabled = false;
                
                btnNew.TabIndex = 0;
            }
            else if (tabControlDCDImport.SelectedTab == tabPageeBookInventory)
            {
                RefreshData();
                btnNew.Enabled = false;
                btnImport.Enabled = false;
                btnSave.Enabled = false;
                btnRemove.Enabled = true;
                btnRefresh.Enabled = true;
                cmbShipmentName.Text = "";
                cmbPDTeam.Text = "";
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridViewDCDInventory.DataSource!=null){
                frm_DeleteShipment dFrm = new frm_DeleteShipment();
                dFrm.ShowDialog();
            }
            else{
                MessageBox.Show("There is no new Shipment to delete.", "Empty DCD Inventory", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void removeButtonEnable()
        {
            btnRemove.Enabled = true;
        }
        private void removeButtonDisable()
        {
            btnRemove.Enabled = false;
        }

        private void dataGridViewDCDImport_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDCDInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load Selected Grid Row to frm_EditImportedFile for Edit
            int rowIndex = dataGridViewDCDInventory.CurrentRow.Index;

            int sShpID = int.Parse(dataGridViewDCDInventory.Rows[rowIndex].Cells[0].Value.ToString());
            string sShipmentID = dataGridViewDCDInventory.Rows[rowIndex].Cells[1].Value.ToString();
            string sISBN = dataGridViewDCDInventory.Rows[rowIndex].Cells[3].Value.ToString();
            string sdISBN = dataGridViewDCDInventory.Rows[rowIndex].Cells[4].Value.ToString();
            string stxtBookTitle = dataGridViewDCDInventory.Rows[rowIndex].Cells[6].Value.ToString();
            string stxtAuthor = dataGridViewDCDInventory.Rows[rowIndex].Cells[7].Value.ToString();
            string stxtAuthor2 = dataGridViewDCDInventory.Rows[rowIndex].Cells[8].Value.ToString();
            string sPageCount = dataGridViewDCDInventory.Rows[rowIndex].Cells[9].Value.ToString();
            string sPCPCode = dataGridViewDCDInventory.Rows[rowIndex].Cells[10].Value.ToString();
            string sComplexcity = dataGridViewDCDInventory.Rows[rowIndex].Cells[11].Value.ToString();
            string sPubDate = dataGridViewDCDInventory.Rows[rowIndex].Cells[12].Value.ToString();
            string sPublisher = dataGridViewDCDInventory.Rows[rowIndex].Cells[2].Value.ToString();
            string sLanguage = dataGridViewDCDInventory.Rows[rowIndex].Cells[13].Value.ToString();
            string sTeam = dataGridViewDCDInventory.Rows[rowIndex].Cells[16].Value.ToString();
            string sFormat = dataGridViewDCDInventory.Rows[rowIndex].Cells[27].Value.ToString();
            string sComment = dataGridViewDCDInventory.Rows[rowIndex].Cells[26].Value.ToString();
            string sAuditName = dataGridViewDCDInventory.Rows[rowIndex].Cells[19].Value.ToString();
            string sAuditLoadedDate = dataGridViewDCDInventory.Rows[rowIndex].Cells[17].Value.ToString();
            string sAuditCount = dataGridViewDCDInventory.Rows[rowIndex].Cells[18].Value.ToString();
            string sAuditStatus = dataGridViewDCDInventory.Rows[rowIndex].Cells[20].Value.ToString();
            string sXmittedDate = dataGridViewDCDInventory.Rows[rowIndex].Cells[21].Value.ToString();
            string sDollarFileUploadedDate = dataGridViewDCDInventory.Rows[rowIndex].Cells[23].Value.ToString();
            string sDollarFileName = dataGridViewDCDInventory.Rows[rowIndex].Cells[24].Value.ToString();
            string sFinalPrice = dataGridViewDCDInventory.Rows[rowIndex].Cells[25].Value.ToString();

            //frm_EditImportedFile Constructor Overload with Gridview Selected Data
            frm_EditImportedFile eFile = new frm_EditImportedFile(sShpID, sShipmentID, sISBN, sdISBN, stxtBookTitle, stxtAuthor, stxtAuthor2, sPageCount, sComplexcity, sPCPCode, sPubDate, sPublisher, sLanguage, sTeam, sFormat, sComment, rowIndex, sAuditName, sAuditLoadedDate, sAuditCount, sAuditStatus, sDollarFileName, sDollarFileUploadedDate, sFinalPrice, sXmittedDate);

            eFile.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmbShipmentName.Text = "";
            dataGridViewDCDImport.DataSource = "";
            lblFileCount.Text = "";
            lblImportPath.Text = "";
            btnImport.Enabled = true;
            btnSave.Enabled = false;
            btnRefresh.Enabled = false;
            btnRemove.Enabled = false;
            tabControlDCDImport.SelectedIndex = 0;
            tabControlDCDImport.Refresh();
            btnImport.Focus();
        }

        private void dataGridViewDCDInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Load Shipment and Team name to header
            int rowIndex = dataGridViewDCDInventory.CurrentRow.Index;

            cmbShipmentName.Text = dataGridViewDCDInventory.Rows[rowIndex].Cells[1].Value.ToString();
            cmbPDTeam.Text = dataGridViewDCDInventory.Rows[rowIndex].Cells[16].Value.ToString(); ;
        }

    }
}

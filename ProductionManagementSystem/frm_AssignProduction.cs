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

namespace ProductionManagementSystem
{
    public partial class frm_AssignProduction : Form
    {
        SqlConnection conn;

        public frm_AssignProduction(string mUID, string mTeam)
        {
            InitializeComponent();
            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();

            lblCUID.Text = mUID;
            lblTeam.Text = mTeam;
        }

        private void frm_AssignProduction_Load(object sender, EventArgs e)
        {

            cmbShipment.DataSource = new ShipmentHeaderMng(this.conn).GetAllShipmentByName();
            cmbFormat.DataSource = new FormatMng(this.conn).GetAllFormatName();
            cmbUserID.DataSource = new UserManager(this.conn).GetAllUserIDs();
            cmbShipment.Text = null;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbShipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridBeforeAssignedUID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridBeforeAssignedUID.CurrentRow.Index;

            cmbPID.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[0].Value.ToString();
            cmbShipment.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
            lblLBookTitle.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[4].Value.ToString();
            cmbFormat.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[7].Value.ToString();
            cmbUserID.Focus();
            
        }

        private void btnAssignUID_Click(object sender, EventArgs e)
        {
            //validate User ID
            if (cmbUserID.Text != "")
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Do You want to assign User "+ cmbUserID.Text +" to this file?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    //Confirm by user
                    if(result==DialogResult.Yes){

                        //validate Production ID
                        if (cmbPID.Text != "")
                        {
                            int rowIndex = dataGridBeforeAssignedUID.CurrentRow.Index;

                            ProductionManagementHeader mProductionHdr = new ProductionManagementHeader();
                            ProductionManagementDetail mProductionDtl = new ProductionManagementDetail();
                            ShipmentDetailFormats mShipmetDetail = new ShipmentDetailFormats();
                            ProductionStatus mLog = new ProductionStatus();

                            //Production Management Header Value
                            mProductionHdr.ShpID = int.Parse(cmbPID.Text);
                            mProductionHdr.ShipmentID = cmbShipment.Text;
                            mProductionHdr.FormatName = cmbFormat.Text;

                            //Production Management Detail Value
                            mProductionDtl.ShpID = int.Parse(cmbPID.Text);
                            mProductionDtl.ShipmentID = cmbShipment.Text;
                            mProductionDtl.Format = cmbFormat.Text;
                            mProductionDtl.ISBN = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[2].Value.ToString();
                            mProductionDtl.UserID = cmbUserID.Text;
                            mProductionDtl.PageCount = int.Parse(dataGridBeforeAssignedUID.Rows[rowIndex].Cells[8].Value.ToString());
                            mProductionDtl.StartDate = dateTimePickerStartDate.Value;
                            mProductionDtl.ProductionStatus = "Process By User";

                            //Shipment Detail Formats Value
                            mShipmetDetail.ShpID = int.Parse(cmbPID.Text);
                            mShipmetDetail.ShipmentID = cmbShipment.Text;
                            mShipmetDetail.FormatName = cmbFormat.Text;
                            mShipmetDetail.ProductionStatus = "Process By User";

                            //Production Status Log Value
                            mLog.ProductID = int.Parse(cmbPID.Text);
                            mLog.ShipmentID = cmbShipment.Text;
                            mLog.ISBN = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[2].Value.ToString();
                            mLog.StartDate = DateTime.Now;
                            mLog.FormatName = cmbFormat.Text;
                            mLog.UserID = lblCUID.Text;
                            mLog.Status = "Production assign to User " + cmbUserID.Text + " by Access User " + lblCUID.Text;

                            ProductionManagementDetailMng mProductionDtlMng = new ProductionManagementDetailMng(conn);
                            ShipmentDetailFormatsMng mShipmentDetailMng = new ShipmentDetailFormatsMng(conn);

                            //Add Prodution Management Header table
                            if (new ProductionManagementHeaderMng(this.conn).AddProductionManagementHeader(mProductionHdr) > 0)
                            {

                                //Update Shipment Format table
                                mShipmentDetailMng.UpdateProductionOnSipmentFormatFile(mShipmetDetail);

                                //Add Prodution Management Detail table
                                mProductionDtlMng.AddProductionManagementDetail(mProductionDtl);
                                MessageBox.Show("File has been assigned.\n\n ISBN: " + mProductionDtl.ISBN + "\n User ID: " + cmbUserID.Text + "\n Start Date: " + dateTimePickerStartDate.Value.ToString("dd/MMM/yyyy"), "File Assigned", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                                //Production Log table
                                new ProductionStatusLogMng(this.conn).AddProdustionStatus(mLog);
                                RefreshData();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Production ID cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbPID.Focus();
                        }
                    }

                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146232060)
                    {
                        MessageBox.Show("This Format is already assigned to a User.\n Please check Format & User ID again.", "Cannot Assign", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
            }
            else {
                MessageBox.Show("Plese select User ID to assign file.", "Cannot Assign", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserID.Focus();
            }
            
            
           
        }

        private void btnRemoveUID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                int rowIndex = dataGridAfterAssignedUID.CurrentRow.Index;

                if (dataGridAfterAssignedUID.Rows[rowIndex].Cells[7].Value.ToString()=="Process By User")
                {
                    String ISBN= dataGridAfterAssignedUID.Rows[rowIndex].Cells[2].Value.ToString();

                    result = MessageBox.Show("Do you really want to remove User ID from ISBN: " + ISBN +"?", "Remove User from Assign File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if(result==DialogResult.Yes)
                    {
                        QRDetail mQRD = new QRDetail();
                        QRHeader mQRH = new QRHeader();
                        EmployeeProduction mEMP = new EmployeeProduction();
                        ProductionManagementDetail mProductionDtl = new ProductionManagementDetail();
                        ProductionManagementHeader mProductionHdr = new ProductionManagementHeader();
                        ShipmentDetailFormats mShipmentDetailFormats = new ShipmentDetailFormats();
                        ProductionStatus mLog = new ProductionStatus();

                        //initilize values for QR Detail to delete
                        mQRD.ProductID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mQRD.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mQRD.ISBN = ISBN;
                        mQRD.FormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();

                        //initilize values for QR Header to delete
                        mQRH.ProductID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mQRH.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mQRH.ISBN = ISBN;
                        mQRH.FormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();

                        //initilize values for Employee Production to delete
                        mEMP.ProductID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mEMP.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mEMP.ISBN = ISBN;
                        mEMP.FormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();
                        mEMP.Status = "Complete By User";

                        //initilize values for Production Detail to delete
                        mProductionDtl.ShpID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mProductionDtl.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mProductionDtl.ISBN = ISBN;
                        mProductionDtl.Format = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();

                        //initilize values for Production Detail Header to delete
                        mProductionHdr.ShpID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mProductionHdr.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mProductionHdr.FormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();

                        //initilize values for Detail Format to delete
                        mShipmentDetailFormats.ShpID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mShipmentDetailFormats.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mShipmentDetailFormats.FormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();

                        //Production Status Log Value
                        mLog.ProductID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                        mLog.ShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                        mLog.ISBN = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[2].Value.ToString();
                        mLog.StartDate = DateTime.Now;
                        mLog.FormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();
                        mLog.UserID = lblCUID.Text;
                        String aUID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[4].Value.ToString();
                        mLog.Status = "Removed assigned User " + aUID + " from Assgned Production by System Access User " + lblCUID.Text;

                        QRDetailMng mQRDMng = new QRDetailMng(conn);
                        QRHeaderMng mQRHMng = new QRHeaderMng(conn);
                        EmployeeProductionMng mEPMMng = new EmployeeProductionMng(conn);
                        ProductionManagementDetailMng mShipmentDetailMng = new ProductionManagementDetailMng(conn);
                        ProductionManagementHeaderMng mProductionHdrMng = new ProductionManagementHeaderMng(conn);
                        ShipmentDetailFormatsMng mShipmentDetailFormatsMng = new ShipmentDetailFormatsMng(conn);

                        // Delete Production Manegement Detail
                        if (mShipmentDetailMng.DeleteAssignedProductionManagementDetail(mProductionDtl) > 0)
                        {
                            // Delete Production Manegement Header
                            mProductionHdrMng.DeleteProductionManagementHeader(mProductionHdr);

                            // Delete QR Detail
                            if (mQRDMng.DeleteQRDetail(mQRD) > 0)
                            {
                            // Delete QR Header
                                mQRHMng.DeleteQRHeader(mQRH);
                            }
                            // Delete Employee Production
                            mEPMMng.DeleteUserProdcutionDone(mEMP);

                            // Update Employee Shipment Detail Formats to Not Assign
                            mShipmentDetailFormatsMng.UpdateProductionOnToBeAssignFormatFile(mShipmentDetailFormats);

                            MessageBox.Show("Selected assigned User successfully cleared from File..!", "Assigned File Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //Production Log table
                            new ProductionStatusLogMng(this.conn).AddProdustionStatus(mLog);

                            RefreshData();

                        }
                    }

                }
                else
                {
                    MessageBox.Show("This file is already in process by User. \nFirst modify status before remove User ID.", "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnModifyUID.Focus();
                }


            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467261)
                {
                    MessageBox.Show("First select a file to remove User ID.", "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbShipment.Focus();
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }

        }

        private void RefreshData()
        {
            dataGridBeforeAssignedUID.DataSource = new ShipmentDetailMng(this.conn).GetAllShipmentsByAssignedTAT(cmbShipment.Text);
            dataGridAfterAssignedUID.DataSource = new ProductionManagementDetailMng(this.conn).GetAllAssignedProduction(cmbShipment.Text);

            int rowIndex = dataGridBeforeAssignedUID.CurrentRow.Index;

            cmbPID.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[0].Value.ToString();
            cmbShipment.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
            lblLBookTitle.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[4].Value.ToString();
            cmbFormat.Text = dataGridBeforeAssignedUID.Rows[rowIndex].Cells[7].Value.ToString();
            cmbUserID.Focus();
        }

        private void dataGridAfterAssignedUID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnRemoveUID.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (new ProductionManagementDetailMng(conn).ShipmentIsExist(cmbShipment.Text) == true)
            {

                    dataGridBeforeAssignedUID.DataSource = new ShipmentDetailMng(this.conn).GetAllShipmentsByAssignedTAT(cmbShipment.Text);
                    dataGridAfterAssignedUID.DataSource = new ProductionManagementDetailMng(this.conn).GetAllAssignedProduction(cmbShipment.Text);

                //Clear Fileds Production ID, Format, UserID and Booktitle when find Shipment
                    cmbPID.Text = null;
                    cmbFormat.Text = null;
                    cmbUserID.Text = null;
                    lblLBookTitle.Text = null;
                    

            }
            else
            {
                MessageBox.Show("Shipment: " + cmbShipment.Text + " is not found!", "Shipment Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShipment.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshData();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467261)
                {
                    MessageBox.Show("Cannot refresh data. First select Shipment.", "Cannot Refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbShipment.Focus();
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            
        }

        private void btnModifyUID_Click(object sender, EventArgs e)
        {

            try
            {
                int rowIndex = dataGridAfterAssignedUID.CurrentRow.Index;


                int sShpID = int.Parse(dataGridAfterAssignedUID.Rows[rowIndex].Cells[0].Value.ToString());
                string sShipmentID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[1].Value.ToString();
                string sISBN = dataGridAfterAssignedUID.Rows[rowIndex].Cells[2].Value.ToString();
                string sFormatName = dataGridAfterAssignedUID.Rows[rowIndex].Cells[3].Value.ToString();
                string sUserID = dataGridAfterAssignedUID.Rows[rowIndex].Cells[4].Value.ToString();
                string sStatus = dataGridAfterAssignedUID.Rows[rowIndex].Cells[7].Value.ToString();

                frm_ModifyAssignedUID fModifyUID = new frm_ModifyAssignedUID(sShpID, sShipmentID, sISBN, sFormatName, sUserID, sStatus, lblCUID.Text);
                fModifyUID.Show();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467261)
                {
                    MessageBox.Show("There is no Shipment or Assigned file to modify User ID..!\n Please check shipment name again.", "Cannot Modify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbShipment.Focus();
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
            
        }


    }
}

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
    public partial class frm_FeedbackHandle : Form
    {
        SqlConnection conn;

        public frm_FeedbackHandle(string mUID, string mTeam)
        {
            InitializeComponent();

            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();

            lblUID.Text = mUID;
        }

        private void frm_FeedbackHandle_Load(object sender, EventArgs e)
        {
            cmbShipment.DataSource = new ShipmentHeaderMng(this.conn).GetAllShipmentByName();
            cmbPISBN.DataSource = new FeedbackMng(this.conn).GetAllXmittedISBN(cmbShipment.Text);

            cmbShipment.Text = null;
            cmbPISBN.Text = null;    

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbShipment.Text != "")
            {
                if (cmbPISBN.Text == "")
                {
                    dataGridXmittedFiles.DataSource = new ShipmentDetailMng(this.conn).GetAllShipmentsByTransmitted(cmbShipment.Text);
                    dataGridViewFeedbackFile.DataSource = new FeedbackMng(this.conn).GetAllFeedbackFilesByShipment(cmbShipment.Text);
                }
                else
                {
                    dataGridXmittedFiles.DataSource = new ShipmentDetailMng(this.conn).GetAllISBNByTransmitted(cmbShipment.Text, cmbPISBN.Text);
                    dataGridViewFeedbackFile.DataSource = new FeedbackMng(this.conn).GetAllFeedbackFilesByISBN(cmbShipment.Text, cmbPISBN.Text);
                }
            }
            else
            {
                MessageBox.Show("Shipment ID cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShipment.Focus();
            }

        }

        private void btnMetadata_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridXmittedFiles.CurrentRow.Index;

                //Initialize Feedback data to Feedback Table
                int mShpID = int.Parse(dataGridXmittedFiles.Rows[rowIndex].Cells[0].Value.ToString());
                string mShipmentID = cmbShipment.Text;
                string mISBN = cmbPISBN.Text;
                string mFormat = dataGridXmittedFiles.Rows[rowIndex].Cells[7].Value.ToString();

                frm_AddFeedbackDetails mAddCF = new frm_AddFeedbackDetails(mShpID, mShipmentID, mISBN, mFormat);
                mAddCF.Show();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467261)
                {

                    MessageBox.Show("There is no file selected to add feedback.\n Please select a file from Xmitted File list.", "Cannot Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
           

        }

        private void dataGridXmittedFiles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridXmittedFiles.CurrentRow.Index;

            //Load details to Header
            cmbShipment.Text = dataGridXmittedFiles.Rows[rowIndex].Cells[1].Value.ToString();
            cmbPISBN.Text = dataGridXmittedFiles.Rows[rowIndex].Cells[2].Value.ToString();
            lblbFormat.Text = dataGridXmittedFiles.Rows[rowIndex].Cells[7].Value.ToString();
            lbldRecivedDate.Text = DateTime.Parse(dataGridXmittedFiles.Rows[rowIndex].Cells[11].Value.ToString()).ToString("dd/MMM/yyyy");
            lbldXmittedDate.Text = DateTime.Parse(dataGridXmittedFiles.Rows[rowIndex].Cells[14].Value.ToString()).ToString("dd/MMM/yyyy");
            lbldAuditName.Text = dataGridXmittedFiles.Rows[rowIndex].Cells[12].Value.ToString();
        }

        private void btnReturnFile_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dataGridViewFeedbackFile.CurrentRow.Index;
                DialogResult result;

                Feedback mCF = new Feedback();
                ShipmetDetail mSD = new ShipmetDetail();
                ProductionStatus mPS = new ProductionStatus();

                //Initialize Feedback data to Feedback Table
                mCF.ShpID = int.Parse(dataGridViewFeedbackFile.Rows[rowIndex].Cells[0].Value.ToString());
                mCF.ShipmentID = dataGridViewFeedbackFile.Rows[rowIndex].Cells[1].Value.ToString();
                mCF.ISBN = dataGridViewFeedbackFile.Rows[rowIndex].Cells[2].Value.ToString();
                mCF.FormatName = dataGridViewFeedbackFile.Rows[rowIndex].Cells[3].Value.ToString();

                //Initialize Feedback data to Shipment Detail Table
                mSD.ShpID = int.Parse(dataGridViewFeedbackFile.Rows[rowIndex].Cells[0].Value.ToString());
                mSD.ShipmentID = dataGridViewFeedbackFile.Rows[rowIndex].Cells[1].Value.ToString();
                mSD.TransmissionDone = 0;

                //Production Status Log Values Initialize
                mPS.ProductID = int.Parse(dataGridViewFeedbackFile.Rows[rowIndex].Cells[0].Value.ToString());
                mPS.ShipmentID = dataGridViewFeedbackFile.Rows[rowIndex].Cells[1].Value.ToString();
                mPS.ISBN = dataGridViewFeedbackFile.Rows[rowIndex].Cells[2].Value.ToString();
                mPS.FormatName = dataGridViewFeedbackFile.Rows[rowIndex].Cells[3].Value.ToString();
                mPS.UserID = lblUID.Text;
                mPS.StartDate = DateTime.Now;
                mPS.Status = "Feedback Removed by System Access User " + lblUID.Text;


                ShipmentDetailMng mSDMng = new ShipmentDetailMng(conn);
                FeedbackMng mCFMng = new FeedbackMng(conn);
                ProductionStatusLogMng mPSMng = new ProductionStatusLogMng(conn);

                result = MessageBox.Show("Do you really want to remove feedback?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Remove data from Feedback Table
                    if (mCFMng.DeleteFeedback(mCF) > 0)
                    {
                        //Update Shipment Detail Table
                        mSDMng.UpdateFeedbackStatusInShipment(mSD);
                        MessageBox.Show("Client feedback sucessfully removed.", "Feedback Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Production Status Log
                        mPSMng.AddProdustionStatus(mPS);

                        RefreshData();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467261)
                {

                    MessageBox.Show("There is no file selected to remove feedback.\n Please select a file from Feedback File list or Click Referesh button.", "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            


        }

        private void RefreshData()
        {
            if (cmbShipment.Text != "")
            {
                dataGridXmittedFiles.DataSource = new ShipmentDetailMng(this.conn).GetAllShipmentsByTransmitted(cmbShipment.Text);
                dataGridViewFeedbackFile.DataSource = new FeedbackMng(this.conn).GetAllFeedbackFilesByShipment(cmbShipment.Text);
                lblbFormat.Text = "";
                lbldRecivedDate.Text = "";
                lbldXmittedDate.Text = "";
                cmbPISBN.Text = "";

            }
            else
            {
                MessageBox.Show("There is no Shipment to refresh data.", "Cannot Refresh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbShipment.Focus();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnModifyFeedback_Click(object sender, EventArgs e)
        {
            try
            {

                int rowIndex = dataGridViewFeedbackFile.CurrentRow.Index;

                //Initialize Feedback data to Feedback Table
                int mShpID = int.Parse(dataGridViewFeedbackFile.Rows[rowIndex].Cells[0].Value.ToString());
                string mShipmentID = dataGridViewFeedbackFile.Rows[rowIndex].Cells[1].Value.ToString();
                string mISBN = dataGridViewFeedbackFile.Rows[rowIndex].Cells[2].Value.ToString();
                string mFormatName = dataGridViewFeedbackFile.Rows[rowIndex].Cells[3].Value.ToString();
                string mFeedbackDate = dataGridViewFeedbackFile.Rows[rowIndex].Cells[4].Value.ToString();
                string mRemark = dataGridViewFeedbackFile.Rows[rowIndex].Cells[5].Value.ToString();

                frm_ModifyFeedbackDetails mAddCF = new frm_ModifyFeedbackDetails(mShpID, mShipmentID, mISBN, mFormatName, mFeedbackDate, mRemark);
                mAddCF.Show();
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2147467261)
                {

                    MessageBox.Show("There is no file selected to modify feedback.\n Please select a file from Feedback File list or Click Referesh button.", "Cannot Modify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }

        }
    }
}

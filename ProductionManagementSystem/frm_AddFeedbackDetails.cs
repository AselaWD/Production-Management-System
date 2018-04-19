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
    public partial class frm_AddFeedbackDetails : Form
    {
        SqlConnection conn;

        public frm_AddFeedbackDetails(int mShpID, string mShipmentID, string mISBN, string mFormat)
        {
            InitializeComponent();

            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();

            lbldShpID.Text = mShpID.ToString();
            lbldShipment.Text = mShipmentID;
            txtISBN.Text = mISBN;
            lbldFormat.Text = mFormat;
        }

        private void btnAddFeedBack_Click(object sender, EventArgs e)
        {
            DialogResult result;

            Feedback mCF = new Feedback();
            ShipmetDetail mSD = new ShipmetDetail();

            //Initialize Feedback data to Feedback Table
            mCF.ISBN = txtISBN.Text;
            mCF.FeedbackDate = dateTimePickerFeedbackDate.Value;
            mCF.ShpID = int.Parse(lbldShpID.Text);
            mCF.ShipmentID = lbldShipment.Text;
            mCF.Remark = txtRemark.Text;
            mCF.FormatName = lbldFormat.Text;

            //Initialize Feedback data to Feedback Table
            mSD.ShpID = int.Parse(lbldShpID.Text);
            mSD.ShipmentID = lbldShipment.Text;
            mSD.ClientFeedback= 1;

            FeedbackMng mCFMng = new FeedbackMng(conn);
            ShipmentDetailMng mSDMng = new ShipmentDetailMng(conn);

            result = MessageBox.Show("Do you really want to add feedback?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (mCFMng.AddFeedback(mCF) > 0)
                {
                    mSDMng.UpdateFeedbackStatusInShipment(mSD);
                    MessageBox.Show("Client feedback sucessfully added.", "Feedback Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
        }
    }
}

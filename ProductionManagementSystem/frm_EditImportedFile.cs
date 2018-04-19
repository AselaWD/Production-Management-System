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
using System.Windows.Forms.PropertyGridInternal;
namespace ProductionManagementSystem
{
    public partial class frm_EditImportedFile : Form
    {
        SqlConnection conn;


        private void frm_EditImportedFile_Load(object sender, EventArgs e)
        {


        }


        public frm_EditImportedFile(int ShpID, string ShipmentID, string ISBN, string dISBN, string BookTitle, string Author, string Author2, string PageCount, string sPCPCode, string sComplexcity, string PubDate, string Publisher, string Language, string Team, string Format, string Comment, int rowIndex, string sAuditName, string sAuditLoadedDate, string sAuditCount, string sAuditStatus, string sDollarFileName, string sDollarFileUploadedDate, string sFinalPrice, string sXmittedDate)
        {
            InitializeComponent();
            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();

            cmbPublisher.DataSource = new PublisherMng(this.conn).GetAllPublishers();
            cmbTeamName.DataSource = new UserTeamMng(this.conn).GetAllUserTeam();
            


            //File Detail Tab
            lblShipment.Text = ShipmentID;
            txtISBN.Text = ISBN;
            txtdISBN.Text = dISBN;
            txtBookTitle.Text = BookTitle;
            txtAuthor.Text = Author;
            txtAuthor2.Text = Author2;
            txtPageCount.Text = PageCount;
            cmbComplexcity.Text = sComplexcity;
            txtPCPCode.Text = sPCPCode;
            dateTimePickerPubDate.Text = PubDate;
            cmbPublisher.Text = Publisher;
            cmbLanguage.Text = Language;
            cmbTeamName.Text = Team;
            lblTLbl.Text = ShpID.ToString();
            groupBoxFixedLayout.Enabled = false;
            groupBoxFlowLayout.Enabled = false;


            //Audit Tab
            txtAISBN.Text = ISBN;
            txtADISBN.Text = dISBN;
            txtAuditName.Text = sAuditName;
            dateTimePickerAuditLoadedDate.Text = sAuditLoadedDate;
            numericAuditCount.Text = sAuditCount;
            cmbAuditStatus.Text = sAuditStatus;

            //Transmission Details
            txtDollarFileName.Text = sDollarFileName;
            dateTimePickerDollarDate.Text = sDollarFileUploadedDate;
            numericFinalPrice.Text = sFinalPrice;
            dateTimePickerXmittedDate.Text = sXmittedDate;


            // For each uutput formats dedicate a column
            //string fePub
            //string fMobi
            //string fWEB
            //string fDoc
            //string fAFF For Apple Fixed Book
            //string fKF8 For Kindle Fixed Book
            //string fKCC For Kindle Comic Book
            //string fePib For B&N Fixed Book

            string data = Format;
            var s1 = data.Split('/');
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].ToString() == "ePub")
                {
                    checkBoxePub.Checked = true;
                }
                if (s1[i].ToString() == "Mobi")
                {
                    checkBoxMobi.Checked = true;
                }
                if (s1[i].ToString() == "WEB")
                {
                    checkBoxWEB.Checked = true;
                }
                if (s1[i].ToString() == "DocBook")
                {
                    checkBoxDocBook.Checked = true;
                }
                if (s1[i].ToString() == "AFF")
                {
                    checkBoxAFF.Checked = true;
                }
                if (s1[i].ToString() == "KF8")
                {
                    checkBoxKF8.Checked = true;
                }
                if (s1[i].ToString() == "KCC")
                {
                    checkBoxKCC.Checked = true;
                }
                if (s1[i].ToString() == "ePib")
                {
                    checkBoxePib.Checked = true;
                }
            }

            txtComment.Text = Comment;

        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            ShipmentDetailFormats mShFormats = new ShipmentDetailFormats();

            DialogResult result;
            result=MessageBox.Show("Are you sure want to update file details?","Update File Details",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ShipmetDetail mShilmpent = new ShipmetDetail();
                ShipmentDetailFormatsMng ShFormats = new ShipmentDetailFormatsMng(conn);

                

                mShilmpent.ShpID = (int.Parse(lblTLbl.Text));
                mShilmpent.ShipmentID = lblShipment.Text;
                mShilmpent.ISBN = txtISBN.Text;
                mShilmpent.DISBN = txtdISBN.Text;
                mShilmpent.Title = txtBookTitle.Text;
                mShilmpent.Author = txtAuthor.Text;
                mShilmpent.Author1 = txtAuthor2.Text;
                mShilmpent.PageCount = int.Parse(txtPageCount.Text);
                mShilmpent.PCPCode = txtPCPCode.Text;
                mShilmpent.Complexcity = cmbComplexcity.Text;
                mShilmpent.PubDate = dateTimePickerPubDate.Value;
                mShilmpent.Publisher = cmbPublisher.Text;
                mShilmpent.Language = cmbLanguage.Text;
                mShilmpent.Team = cmbTeamName.Text;
                mShilmpent.Comment =txtComment.Text;

                ShipmentDetailMng ShipDetailMng = new ShipmentDetailMng(conn);
               

                if (ShipDetailMng.UpdateShipment(mShilmpent) > 0)
                {
                 
                    MessageBox.Show("File details successfully updated..!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ShipDetailMng.GetAllShipmentByName();
                }
            }
            

        }


        private void cmbPublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPriceUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure want to update Audit details?", "Update File Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (new ShipmentDetailMng(conn).ProductionDoneIsExist(int.Parse(lblTLbl.Text), lblShipment.Text) == true)
                {
                    if (new ShipmentDetailMng(conn).QRDoneIsExist(int.Parse(lblTLbl.Text), lblShipment.Text) == true)
                    {
                        ShipmetDetail mShilmpent = new ShipmetDetail();

                        mShilmpent.ShpID = (int.Parse(lblTLbl.Text));
                        mShilmpent.ShipmentID = lblShipment.Text;
                        mShilmpent.AuditName = txtAuditName.Text;
                        mShilmpent.AuditLoadedDate = dateTimePickerAuditLoadedDate.Value;
                        mShilmpent.AuditCount = int.Parse(numericAuditCount.Value.ToString());
                        mShilmpent.AuditStatus = cmbAuditStatus.Text;


                        ShipmentDetailMng ShipDetailMng = new ShipmentDetailMng(conn);


                        if (ShipDetailMng.UpdateAuditInShipment(mShilmpent) > 0)
                        {

                            MessageBox.Show("File details successfully updated..!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            

                        }
                    }
                    else
                    {
                        MessageBox.Show("File is not QR done yet", "Cannot Update Audit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
               else{
                   MessageBox.Show("File is not production done yet", "Cannot Update Audit", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Are you sure want to update Transmission details?", "Update File Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (new ShipmentDetailMng(conn).ProductionDoneIsExist(int.Parse(lblTLbl.Text), lblShipment.Text) == true)
                {
                    if (new ShipmentDetailMng(conn).QRDoneIsExist(int.Parse(lblTLbl.Text), lblShipment.Text) == true)
                    {
                    
                        ShipmetDetail mShilmpent = new ShipmetDetail();

                        mShilmpent.ShpID = (int.Parse(lblTLbl.Text));
                        mShilmpent.ShipmentID = lblShipment.Text;
                        mShilmpent.DollerFileName = txtDollarFileName.Text;
                        mShilmpent.DollerUploadedDate = dateTimePickerDollarDate.Value;
                        mShilmpent.FinalPrice = float.Parse(numericFinalPrice.Value.ToString());
                        mShilmpent.XmittedDate = dateTimePickerXmittedDate.Value;
                        mShilmpent.TransmissionDone = 1;


                        ShipmentDetailMng ShipDetailMng = new ShipmentDetailMng(conn);


                        if (ShipDetailMng.UpdateTransmissioInShipment(mShilmpent) > 0)
                        {

                            MessageBox.Show("File details successfully updated..!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            

                        }
                    }
                    else{
                        MessageBox.Show("File is not QR done yet", "Cannot Update Trasmission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else{
                    MessageBox.Show("File is not Production done yet", "Cannot Update Trasmission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFileExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAuditExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

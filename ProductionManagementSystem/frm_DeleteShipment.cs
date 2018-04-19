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
    public partial class frm_DeleteShipment : Form
    {
        SqlConnection conn;

        public frm_DeleteShipment()
        {
            InitializeComponent();
            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();
        }

        // Referch dataGridViewDCDInventory (eBooks Inventory) Data in Form DCD Import
        private void RefreshData()
        {

            ShipmentDetailMng mShipment = new ShipmentDetailMng(conn);
            DataTable table = mShipment.GetAllShipments();
            frm_DCDImport rfDCDInventory = new frm_DCDImport();
            rfDCDInventory.dataGridViewDCDInventory = new DataGridView();
            rfDCDInventory.dataGridViewDCDInventory.DataSource = table;
            
           
            

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_DeleteShipment_Load(object sender, EventArgs e)
        {
            
            ShipmentDetailMng mShipment = new ShipmentDetailMng(conn);
            cmbShipment.DataSource = new ShipmentHeaderMng(this.conn).GetAllShipmentByName();
            cmbISBN.DataSource = mShipment.GetAllShipmentByPrintISBN();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try{
                //Message for Error when Shipment Fied is empty
                if (cmbShipment.Text.ToString() == "")
                {
                    MessageBox.Show("Please select a Shipment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (cbmSAllFiles.Checked == true && cmbShipment.Text.ToString() != "")
                    {
                        //Initialize Message Result
                        DialogResult result;
                        result = MessageBox.Show("Do you really want to delete \"" + cmbShipment.Text + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            //Create Object From ShipmetDetail Object
                            ShipmetDetail mShipment = new ShipmetDetail();
                            ShipmentHeader mShipmentHeader = new ShipmentHeader();
                            ShipmentDetailFormats mShipmentDetailFormats = new ShipmentDetailFormats();
                            TATDelivery mTATDelivery = new TATDelivery();
                            ProductionManagementDetail mProductionManagementDetail = new ProductionManagementDetail();
                            ProductionManagementHeader mProductionManagementHeader = new ProductionManagementHeader();


                            // Assign Shipment Delete Interface data to mShipmentID
                            String mShipmentID = cmbShipment.Text.ToString();


                            //Create Services
                            ShipmentDetailMng mShipmentMng = new ShipmentDetailMng(conn);
                            ShipmentHeaderMng mShipmentHeaderMng = new ShipmentHeaderMng(conn);
                            ShipmentDetailFormatsMng mShipmentDetailFormatsMng = new ShipmentDetailFormatsMng(conn);
                            TATDeliveryMng mTATDeliveryMng = new TATDeliveryMng(conn);
                            ProductionManagementDetailMng mProductionManagementDetailMng = new ProductionManagementDetailMng(conn);
                            ProductionManagementHeaderMng mProductionManagementHeaderMng = new ProductionManagementHeaderMng(conn);

                            mShipmentDetailFormatsMng.DeleteShimpentFormats(mShipmentID);
                            mShipmentMng.DeleteShipment(mShipmentID);
                            mShipmentHeaderMng.DeleteShipmentHeader(mShipmentID);



                            MessageBox.Show("\"" + cmbShipment.Text + "\" successfully deleted..!", " Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            frm_DCDImport DCDFrm = new frm_DCDImport();
                            RefreshData();
                            this.Dispose();


                        }
                        else
                        {
                            this.Dispose();
                        }

                    }

                    else if (cmbISBN.Text != "" && cmbShipment.Text.ToString() != "")
                    {

                        //Initialize Message Result
                        DialogResult result;
                        result = MessageBox.Show("Do you really want to delete ISBN " + cmbISBN.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            //Create Object From ShipmetDetail Object
                            ShipmetDetail mShipmentISBN = new ShipmetDetail();
                            ShipmetDetail mShipment = new ShipmetDetail();
                            ShipmentDetailFormats mShipmentDetailFormats = new ShipmentDetailFormats();



                            // Assign Shipment Delete Interface data to mShipmentwithISBN Object
                            mShipment.ID = cmbShipment.Text;
                            mShipmentISBN.ISBN = cmbISBN.Text;


                            ShipmentDetailMng mShipmentMng = new ShipmentDetailMng(conn);
                            ShipmentDetailMng mShipmentMngShpID = new ShipmentDetailMng(conn);
                            ShipmentDetailFormatsMng mShipmentDetailFormatsMng = new ShipmentDetailFormatsMng(conn);

                            if (mShipmentMng.DeleteShipmentFromID(mShipmentISBN, mShipment) > 0)
                            {
                                MessageBox.Show("ISBN " + mShipmentISBN.ISBN + " successfully deleted..!", "ISBN Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshData();
                                this.Dispose();
                            }


                        }
                        else if (result == DialogResult.No)
                        {
                            this.Close();
                        }

                    }
               
            }
            }
            catch (Exception ex)
            {
                if (ex.HResult == -2146232060)
                {
                    MessageBox.Show("This shipment is already in production!","Cannot Delete",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }else
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }
    }
}

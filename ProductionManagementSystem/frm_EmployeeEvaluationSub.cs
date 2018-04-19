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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProductionManagementSystem
{
    public partial class frm_EmployeeEvaluationSub : Form
    {
        SqlConnection conn;

        public frm_EmployeeEvaluationSub()
        {
            InitializeComponent();
            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();
            cmbUID.DataSource = new EmployeeProductionMng(this.conn).GetAllUserIDProductionEmployee();
            cmbShipment.DataSource = new EmployeeProductionMng(this.conn).GetAllShipmentIDProductionEmployee();

            cmbUID.Text = null;
            cmbShipment.Text = null;

        }

        private void frm_EmployeeEvaluationSub_Load(object sender, EventArgs e)
        {
            radioAllUser.Checked = true;

            if (radioUserWise.Checked == true)
            {
                cmbUID.Enabled = true;
            }
            if (radioAllUser.Checked == true)
            {
                cmbUID.Enabled = false;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (radioAllUser.Checked == true)
            {
                EmployeeProductionMng mEMP = new EmployeeProductionMng(conn);

                //Report Document Object
                ReportDocument cryUser = new ReportDocument();
                cryUser.Load("E:\\MyProject\\ProductionManagementSystem\\ProductionManagementSystem\\ProductionManagementSystem\\Reprots\\rptEmployeeProductionAllShipment.rpt");

                //Data Source set
                cryUser.SetDataSource(mEMP.GetAllEmployeeProduction());

                frm_UserEvaluvation fUE = new frm_UserEvaluvation();
                fUE.crystalReportViewer1.ReportSource = cryUser;
                fUE.crystalReportViewer1.Refresh();
                fUE.Show();
            }

            if (radioUserWise.Checked == true)
            {
                if(cmbUID.Text==""){
                    MessageBox.Show("User ID cannot be empty!","Invalid User ID",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    cmbUID.Focus();
                }
                else
                {
                    EmployeeProductionMng mEMP = new EmployeeProductionMng(conn);

                    //Report Document Object
                    ReportDocument cryUser = new ReportDocument();
                    cryUser.Load("E:\\MyProject\\ProductionManagementSystem\\ProductionManagementSystem\\ProductionManagementSystem\\Reprots\\rpt_EmpProduction.rpt");

                    //Data Source set
                    cryUser.SetDataSource(mEMP.GetAllEmployeeProduction());


                    ParameterFieldDefinitions crParameterFieldDefinitions;
                    ParameterFieldDefinition crParameterFieldDefinition;
                    ParameterValues crParameterValues = new ParameterValues();
                    ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                    crParameterDiscreteValue.Value = cmbUID.Text;
                    crParameterFieldDefinitions = cryUser.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["UserID"];
                    crParameterValues = crParameterFieldDefinition.CurrentValues;

                    crParameterValues.Clear();
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    frm_UserEvaluvation fUE = new frm_UserEvaluvation();
                    fUE.crystalReportViewer1.ReportSource = cryUser;
                    fUE.crystalReportViewer1.Refresh();
                    fUE.Show();
                }
                
            }


            if (radioButtonShipmentName.Checked == true)
            {
                if (cmbShipment.Text == "")
                {
                    MessageBox.Show("Shipment name cannot be empty!", "Invalid Shipment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbShipment.Focus();
                }
                else
                {
                    EmployeeProductionMng mEMP = new EmployeeProductionMng(conn);

                    //Report Document Object
                    ReportDocument cryUser = new ReportDocument();
                    cryUser.Load("E:\\MyProject\\ProductionManagementSystem\\ProductionManagementSystem\\ProductionManagementSystem\\Reprots\\rptEmployeeProductionShipmentWise.rpt");

                    //Data Source set
                    cryUser.SetDataSource(mEMP.GetAllEmployeeProduction());


                    ParameterFieldDefinitions crParameterFieldDefinitions;
                    ParameterFieldDefinition crParameterFieldDefinition;
                    ParameterValues crParameterValues = new ParameterValues();
                    ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                    crParameterDiscreteValue.Value = cmbShipment.Text;
                    crParameterFieldDefinitions = cryUser.DataDefinition.ParameterFields;
                    crParameterFieldDefinition = crParameterFieldDefinitions["ShipmentID"];
                    crParameterValues = crParameterFieldDefinition.CurrentValues;

                    crParameterValues.Clear();
                    crParameterValues.Add(crParameterDiscreteValue);
                    crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                    frm_UserEvaluvation fUE = new frm_UserEvaluvation();
                    fUE.crystalReportViewer1.ReportSource = cryUser;
                    fUE.crystalReportViewer1.Refresh();
                    fUE.Show();
                }
               
            }

            
        }

        private void radioAllUser_CheckedChanged(object sender, EventArgs e)
        {
            cmbUID.Enabled = false;
            cmbShipment.Enabled = false;
        }

        private void radioUserWise_CheckedChanged(object sender, EventArgs e)
        {
            cmbUID.Enabled = true;
            cmbShipment.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radioButtonShipmentName_CheckedChanged(object sender, EventArgs e)
        {
            cmbShipment.Enabled = true;
            cmbUID.Enabled = false;
        }
    }
}

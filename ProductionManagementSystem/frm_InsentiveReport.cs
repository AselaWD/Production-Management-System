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
    public partial class frm_InsentiveReport : Form
    {
        SqlConnection conn;

        public frm_InsentiveReport(string mUID, string mUTeam, string mULevel)
        {
            InitializeComponent();

            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();

            lbluTeam.Text = mULevel;
            lblUID.Text = mUID;

            if (lbluTeam.Text == "Level 6" || lbluTeam.Text == "Admin" || lbluTeam.Text == "Level 7" || lbluTeam.Text == "Level 8" || lbluTeam.Text == "Level 9" || lbluTeam.Text == "Level 10")
            {
                btnRemoveIncentives.Enabled = true;
                btnSetInsentiveScheme.Enabled = true;
                btnViewEmployeeIncentives.Enabled = true;

            }
            else if (lbluTeam.Text == "Level 4" || lbluTeam.Text == "Level 5")
            {
                btnRemoveIncentives.Enabled = false;
                btnSetInsentiveScheme.Enabled = false;
                btnViewEmployeeIncentives.Enabled = true;
            }
            else{
                btnRemoveIncentives.Enabled = false;
                btnSetInsentiveScheme.Enabled = false;
                btnViewEmployeeIncentives.Enabled = false;
            }
        }

        private void frm_InsentiveReport_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSetInsentiveScheme_Click(object sender, EventArgs e)
        {
            frm_IncentiveManagement mMakeIn = new frm_IncentiveManagement();
            mMakeIn.Show();
        }

        private void btnViewEmployeeIncentives_Click(object sender, EventArgs e)
        {
            ProductionManagementDetailMng mUserDone = new ProductionManagementDetailMng(conn);

            if (mUserDone.IsNulltrptViewGetAllAssignedProduction() == false)
            {

                //Report Document Object
                ReportDocument cryUser = new ReportDocument();
                cryUser.Load("E:\\MyProject\\ProductionManagementSystem\\ProductionManagementSystem\\ProductionManagementSystem\\Reprots\\rptIncentiveApplied.rpt");

                //Data Source set
                cryUser.SetDataSource(mUserDone.rptViewGetAllAssignedProduction());


                //ParameterFieldDefinitions crParameterFieldDefinitions;
                //ParameterFieldDefinition crParameterFieldDefinition;
                //ParameterValues crParameterValues = new ParameterValues();
                //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                //crParameterDiscreteValue.Value = "1000";
                //crParameterFieldDefinitions = cryUser.DataDefinition.ParameterFields;
                //crParameterFieldDefinition = crParameterFieldDefinitions["FromDate"];
                //crParameterValues = crParameterFieldDefinition.CurrentValues;

                //crParameterValues.Clear();
                //crParameterValues.Add(crParameterDiscreteValue);
                //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);


                //ParameterFieldDefinitions crParameterFieldToDates;
                //ParameterFieldDefinition crParameterFieldToDate;
                //ParameterValues crParameterValuesToDate = new ParameterValues();

                //crParameterDiscreteValue.Value = "2000";
                //crParameterFieldToDates = cryUser.DataDefinition.ParameterFields;
                //crParameterFieldToDate = crParameterFieldToDates["ToDate"];
                //crParameterValuesToDate = crParameterFieldToDate.CurrentValues;

                //crParameterValuesToDate.Clear();
                //crParameterValuesToDate.Add(crParameterDiscreteValue);
                //crParameterFieldToDate.ApplyCurrentValues(crParameterValuesToDate);



                frm_UserEvaluvation fUE = new frm_UserEvaluvation();
                fUE.crystalReportViewer1.ReportSource = cryUser;
                fUE.crystalReportViewer1.Refresh();
                fUE.Show();
            }
            else
            {
                MessageBox.Show("There is no data to load.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckIncentives_Click(object sender, EventArgs e)
        {
            
            
            ProductionManagementDetailMng mUserDone = new ProductionManagementDetailMng(conn);

            if (mUserDone.UserIsExistrptViewGetAllAssignedProduction(lblUID.Text)==true)
            {
                //Report Document Object
                ReportDocument cryUser = new ReportDocument();
                cryUser.Load("E:\\MyProject\\ProductionManagementSystem\\ProductionManagementSystem\\ProductionManagementSystem\\Reprots\\rptIncentiveAppliedByUser.rpt");

                //Data Source set
                cryUser.SetDataSource(mUserDone.rptViewGetAllAssignedProduction());

                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                //Set Parameter
                crParameterDiscreteValue.Value = lblUID.Text;
                crParameterFieldDefinitions = cryUser.DataDefinition.ParameterFields;
                crParameterFieldDefinition = crParameterFieldDefinitions["UserID"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;

                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                //Load Report Viewer
                frm_UserEvaluvation fUE = new frm_UserEvaluvation();
                fUE.crystalReportViewer1.ReportSource = cryUser;
                fUE.crystalReportViewer1.Refresh();
                fUE.Show();
            }
            else {
                MessageBox.Show("There is no data to load for user: " + lblUID.Text, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void btnRemoveIncentives_Click(object sender, EventArgs e)
        {
            frm_RemoveIncentivePlan mModifyIn = new frm_RemoveIncentivePlan();
            mModifyIn.Show();
        }
    }
}

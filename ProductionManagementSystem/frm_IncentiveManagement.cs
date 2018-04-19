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
    public partial class frm_IncentiveManagement : Form
    {
        SqlConnection conn;

        public frm_IncentiveManagement()
        {
            InitializeComponent();

            //Global Variables
            conn = new SqlConnection(Properties.Settings.Default.ProductionManagementSystemConnectionString);
            conn.Open();
        }

        private void frm_IncentiveManagement_Load(object sender, EventArgs e)
        {
            groupBoxMakePlan.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                groupBoxMakePlan.Enabled = true;
            }
            else
            {
                groupBoxMakePlan.Enabled = false;
            }
        }

        private void btnMakePlan_Click(object sender, EventArgs e)
        {
            //validate Incentive Plan
            if (cmbIncentivePlan.Text!=""){

                //validate Incentive Amount
                if (numericUpDownIncentiveAmount.Value > 0)
                {
                    if (numericUpDownIncentiveLimit.Value > 0)
                    {

                            InsentiveScheme mINS = new InsentiveScheme();


                        //Initialize Insentive Plan
                            mINS.IncentiveMonth = dateTimePickerIncentiveMonth.Value.ToString("yyyy-MM");


                        if (cmbIncentivePlan.Text == "Page Count")
                        {
                            mINS.ForBook = 0;
                            mINS.ForPage = 1;
                        }
                        if (cmbIncentivePlan.Text == "Book Count")
                        {
                            mINS.ForBook = 1;
                            mINS.ForPage = 0;
                        }
                        mINS.IncentiveRule = int.Parse(numericUpDownIncentiveLimit.Value.ToString());
                        mINS.IncentiveAmount = int.Parse(numericUpDownIncentiveAmount.Value.ToString());

                        InsentiveSchemeMng mINSMng = new InsentiveSchemeMng(conn);

                        if (mINSMng.MonthIsExist(dateTimePickerIncentiveMonth.Value.ToString("yyyy-MM")) == false)
                        {
                            if (mINSMng.AddIncentivePlan(mINS) > 0)
                            {
                                MessageBox.Show("Incentive Plan created for month " + dateTimePickerIncentiveMonth.Value + ".", "Incentive Plan Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else{
                            MessageBox.Show("Incentive plan already exists as " + dateTimePickerIncentiveMonth.Value.ToString("yyyy-MM") + " !\nPlease change the month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dateTimePickerIncentiveMonth.Focus();
                        }
                        

                    }
                    else{
                        MessageBox.Show("Incentive Limit should not be zero or empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        numericUpDownIncentiveLimit.Focus();
                    }
                    
                }
                else {
                    MessageBox.Show("Incentive Amount should not be zero or empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numericUpDownIncentiveAmount.Focus();
                }
                
            }
            else
            {
                MessageBox.Show("Incentive Plan canot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                cmbIncentivePlan.Focus();
            }
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

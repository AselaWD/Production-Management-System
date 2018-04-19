using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProductionManagementSystem.BusinessObjects;

namespace ProductionManagementSystem.BusinessService
{
        //IncentiveID	    bigint	Unchecked
        //IncentiveMonth	date	Unchecked
        //IncentiveAmount	money	Checked
        //ForBook	        int	    Checked
        //ForPage	        int	    Checked
        //IncentiveRule	    int	    Checked

    class InsentiveSchemeMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public InsentiveSchemeMng()
        {

        }
        // Constructor Overload
        public InsentiveSchemeMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddIncentivePlan(InsentiveScheme mDetail)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@IN_IncentiveMonth", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@IN_IncentiveAmount", SqlDbType.Money);
            insetComm.Parameters.Add("@IN_ForBook", SqlDbType.Int);
            insetComm.Parameters.Add("@IN_ForPage", SqlDbType.Int);
            insetComm.Parameters.Add("@IN_IncentiveRule", SqlDbType.Int);

            insetComm.Parameters["@IN_IncentiveMonth"].Value = DateTime.Parse(mDetail.IncentiveMonth);
            insetComm.Parameters["@IN_IncentiveAmount"].Value = mDetail.IncentiveAmount;
            insetComm.Parameters["@IN_ForBook"].Value = mDetail.ForBook;
            insetComm.Parameters["@IN_ForPage"].Value = mDetail.ForPage;
            insetComm.Parameters["@IN_IncentiveRule"].Value = mDetail.IncentiveRule;


            insetComm.CommandText = "INSERT INTO IncentiveScheme(IncentiveMonth,IncentiveAmount,ForBook,ForPage,IncentiveRule) VALUES(@IN_IncentiveMonth,@IN_IncentiveAmount,@IN_ForBook,@IN_ForPage,@IN_IncentiveRule)";
            int ans = insetComm.ExecuteNonQuery();
            if (ans > 0)
            {
                return ans;
            }
            else
            {
                return 0;
            }
        }

        public int RemoveIncentivePlanForBook(InsentiveScheme mDetail)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@IN_IncentiveMonth", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@IN_ForBook", SqlDbType.Int);

            insetComm.Parameters["@IN_IncentiveMonth"].Value = DateTime.Parse(mDetail.IncentiveMonth);
            insetComm.Parameters["@IN_ForBook"].Value = mDetail.ForBook;

            insetComm.CommandText = "DELETE FROM IncentiveScheme WHERE IncentiveMonth=@IN_IncentiveMonth AND ForBook=@IN_ForBook";
            int ans = insetComm.ExecuteNonQuery();
            if (ans > 0)
            {
                return ans;
            }
            else
            {
                return 0;
            }
        }

        public int RemoveIncentivePlanForPageCount(InsentiveScheme mDetail)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@IN_IncentiveMonth", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@IN_ForPage", SqlDbType.Int);

            insetComm.Parameters["@IN_IncentiveMonth"].Value = DateTime.Parse(mDetail.IncentiveMonth);
            insetComm.Parameters["@IN_ForPage"].Value = mDetail.ForPage;

            insetComm.CommandText = "DELETE FROM IncentiveScheme WHERE IncentiveMonth=@IN_IncentiveMonth AND ForPage=@IN_ForPage";
            int ans = insetComm.ExecuteNonQuery();
            if (ans > 0)
            {
                return ans;
            }
            else
            {
                return 0;
            }
        }

        public int UpdateIncentivePlan(InsentiveScheme mDetail)
        {

            //update databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;
            updateComm.Parameters.Add("@IN_IncentiveMonth", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@IN_IncentiveAmount", SqlDbType.Money);
            updateComm.Parameters.Add("@IN_ForBook", SqlDbType.Int);
            updateComm.Parameters.Add("@IN_ForPage", SqlDbType.Int);
            updateComm.Parameters.Add("@IN_IncentiveRule", SqlDbType.Int);

            updateComm.Parameters["@IN_IncentiveMonth"].Value = DateTime.Parse(mDetail.IncentiveMonth);
            updateComm.Parameters["@IN_IncentiveAmount"].Value = mDetail.IncentiveAmount;
            updateComm.Parameters["@IN_ForBook"].Value = mDetail.ForBook;
            updateComm.Parameters["@IN_ForPage"].Value = mDetail.ForPage;
            updateComm.Parameters["@IN_IncentiveRule"].Value = mDetail.IncentiveRule;

            updateComm.CommandText = "update IncentiveScheme set IncentiveMonth=@IN_IncentiveMonth,IncentiveAmount=@IN_IncentiveAmount,ForBook=@IN_ForBook,ForPage=@IN_ForPage,IncentiveRule=@IN_IncentiveRule where IncentiveMonth=@IN_IncentiveMonth";
            int ans = updateComm.ExecuteNonQuery();
            if (ans > 0)
            {
                return ans;
            }
            else
            {
                return 0;
            }
        }

        public bool MonthIsExist(String mMonth)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@INS_Month", SqlDbType.VarChar);

            SelectCommand.Parameters["@INS_Month"].Value = DateTime.Parse(mMonth);

            SelectCommand.CommandText = "SELECT IncentiveMonth FROM IncentiveScheme WHERE IncentiveMonth=@INS_Month";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            int rowCount = table.Rows.Count;

            if (rowCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

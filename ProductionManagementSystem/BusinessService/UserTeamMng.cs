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
    //TeamID	varchar(50)	    Unchecked
    //TeamName	varchar(100)	Checked

    class UserTeamMng
    {
         //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public UserTeamMng()
        {

        }
        // Constructor Overload
        public UserTeamMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public List<String> GetAllUserTeam()
        {
            List<String> mTeam = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select TeamName from UserTeam", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mTeam.Add(row[0].ToString());
            }

            return mTeam;
        }

        public bool TeamIsExist(String mTeamName)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mTeam_TeamName", SqlDbType.VarChar);

            SelectCommand.Parameters["@mTeam_TeamName"].Value = mTeamName;

            SelectCommand.CommandText = "SELECT TeamName FROM UserTeam WHERE TeamName=@mTeam_TeamName";

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

        public bool TeamIsExistProductionSummary(String mTeamName)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mTeam_TeamName", SqlDbType.VarChar);

            SelectCommand.Parameters["@mTeam_TeamName"].Value = mTeamName;

            SelectCommand.CommandText = "SELECT Team FROM ProductionSummary WHERE Team=@mTeam_TeamName";

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

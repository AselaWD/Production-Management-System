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
    class UserLoginMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public UserLoginMng()
        {
        }

        // Constructor Overload
        public UserLoginMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public List<String> GetAllUserIDs()
        {
            List<String> uID = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select UserID from UserManagement", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                uID.Add(row[0].ToString());
            }
            return uID;
        }

        public List<String> GetUserPassword()
        {
            List<String> uPass = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select Password from UserManagement", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                uPass.Add(row[0].ToString());
            }
            return uPass;
        }
    }
}
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
    //LevelID	varchar(50)	Unchecked
    //LevelName	varchar(50)	Checked

    class UserLevelMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public UserLevelMng()
        {

        }
        // UserLevelMng Constructor Overload
        public UserLevelMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public List<String> GetAllUserLevels()
        {
            List<String> uLevel = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select LevelName from UserLevel", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                uLevel.Add(row[0].ToString());
            }

            return uLevel;
        }
    }
}

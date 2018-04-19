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
    //DepartmentID	varchar(50)	Unchecked
    //DeparmentName	varchar(50)	Checked

    class UserDepartmentMng
    {
        SqlConnection mConnectionUser;

        //Default Connection
        public UserDepartmentMng() { 
        
        }

        // UserDepartmentMng Constructor Overload
        public UserDepartmentMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public List<String> GetAllUserDepartment() {

            List<String> uDept = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select DeparmentName from UserDepartment", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                uDept.Add(row[0].ToString());
            }

            return uDept;

        }
    }
}

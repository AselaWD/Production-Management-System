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
    //FormatID	    varchar(100)	Unchecked
    //FormatName	varchar(100)	Checked

    class FormatMng
    {  
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public FormatMng()
        {

        }
        // Constructor Overload
        public FormatMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public List<String> GetAllFormatName()
        {
            List<String> mFormat = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select FormatName from Format", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mFormat.Add(row[0].ToString());
            }

            return mFormat;
        }

    }
}

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
    class PriorityMng
    {
        
         SqlConnection mConnectionUser;

        //Default connection
        public PriorityMng()
        {

        }
        // Constructor Overload
        public PriorityMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }
        
        public List<String> GetAllPriprityLevels()
        {
            List<String> uPriority = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT PriorityName FROM Priority", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                uPriority.Add(row[0].ToString());
            }
            return uPriority;
        }
    }
}

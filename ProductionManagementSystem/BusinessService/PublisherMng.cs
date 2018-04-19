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
    class PublisherMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public PublisherMng()
        {

        }
        // UserLevelMng Constructor Overload
        public PublisherMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public List<String> GetAllPublishers()
        {
            List<String> mPublisher = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select PublisherName from Publisher", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mPublisher.Add(row[0].ToString());
            }

            return mPublisher;
        }
    }
}

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
        //ID	            varchar(50)	    Unchecked
        //ShipmentID	    varchar(500)	Unchecked
        //FileCount	        int	            Unchecked
        //DownloadedDate	datetime	    Unchecked

    class ShipmentHeaderMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public ShipmentHeaderMng(){

        }
        // Constructor Overload
        public ShipmentHeaderMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddShipmentHeader(ShipmentHeader mShipment)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@Shh_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Shh_FileCount", SqlDbType.Int);
            insetComm.Parameters.Add("@Shh_DownloadedDate", SqlDbType.DateTime);

            insetComm.Parameters["@Shh_ShipmentID"].Value = mShipment.ShipmentID;
            insetComm.Parameters["@Shh_FileCount"].Value = mShipment.FileCount;
            insetComm.Parameters["@Shh_DownloadedDate"].Value = mShipment.DownloadedDate;

            insetComm.CommandText = "insert into ShipmentHeader(ShipmentID,FileCount,DownloadedDate)values(@Shh_ShipmentID,@Shh_FileCount,@Shh_DownloadedDate)";
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

        public int DeleteShipmentHeader(String mShipment)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@Shh_ShipmentID", SqlDbType.VarChar);

            deleteComm.Parameters["@Shh_ShipmentID"].Value = mShipment;


            deleteComm.CommandText = "delete from ShipmentHeader where ShipmentID=@Shh_ShipmentID";
            int ans = deleteComm.ExecuteNonQuery();
            if (ans > 0)
            {
                return ans;
            }
            else
            {
                return 0;
            }
        }

        public List<String> GetAllShipmentByName()
        {
            List<String> mShipmentID = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select ShipmentID from ShipmentHeader", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mShipmentID.Add(row[0].ToString());
            }
            return mShipmentID;
        }

        public DataTable GetFileCount(ShipmentHeader mShipment)
        {
            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@Shh_ShipmentID", SqlDbType.VarChar);

            deleteComm.Parameters["@Shh_ShipmentID"].Value = mShipment.ShipmentID;

            //Data adapter with select command

            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = new SqlCommand("SELECT FileCount FROM ShipmentHeader", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

    }
}

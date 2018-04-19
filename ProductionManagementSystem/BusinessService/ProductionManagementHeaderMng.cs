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
        //ShpID	        bigint	        Unchecked
        //UserID	    varchar(50)	    Checked
        //ShipmentID	varchar(500)	Checked

    class ProductionManagementHeaderMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public ProductionManagementHeaderMng(){

        }
        // Constructor Overload
        public ProductionManagementHeaderMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddProductionManagementHeader(ProductionManagementHeader mProduction)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@PM_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@PM_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@PM_FormatName", SqlDbType.NVarChar);

            insetComm.Parameters["@PM_ShpID"].Value = mProduction.ShpID;
            insetComm.Parameters["@PM_ShipmentID"].Value = mProduction.ShipmentID;
            insetComm.Parameters["@PM_FormatName"].Value = mProduction.FormatName;


            insetComm.CommandText = "insert into ProductionManagementHeader(ShpID,ShipmentID,FormatName)values(@PM_ShpID,@PM_ShipmentID,@PM_FormatName)";
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

        public int DeleteProductionManagementHeader(ProductionManagementHeader mProduction)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@PM_ShpID", SqlDbType.BigInt);
            deleteComm.Parameters.Add("@PM_ShipmentID", SqlDbType.NVarChar);
            deleteComm.Parameters.Add("@PM_FormatName", SqlDbType.NVarChar);

            deleteComm.Parameters["@PM_ShpID"].Value = mProduction.ShpID;
            deleteComm.Parameters["@PM_ShipmentID"].Value = mProduction.ShipmentID;
            deleteComm.Parameters["@PM_FormatName"].Value = mProduction.FormatName;

            deleteComm.CommandText = "DELETE FROM ProductionManagementHeader WHERE ShpID=@PM_ShpID AND ShipmentID=@PM_ShipmentID AND FormatName=@PM_FormatName";
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
    }
}

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
    class ProductionStatusLogMng
    {
        //ProductID	    bigint	        Unchecked
        //ShipmentID	varchar(500)	Unchecked
        //ISBN	        varchar(20)	    Checked
        //StartDate	    datetime	    Checked
        //FormatName	varchar(100)	Unchecked
        //UserID	    varchar(50) 	Checked
        //Status	    varchar(100)	Checked


         //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public ProductionStatusLogMng(){

        }
        // Constructor Overload
        public ProductionStatusLogMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddProdustionStatus(ProductionStatus mFile)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@EPD_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@EPD_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_UID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_DoneDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@EPD_Status", SqlDbType.NVarChar);


            insetComm.Parameters["@EPD_ShpID"].Value = mFile.ProductID;
            insetComm.Parameters["@EPD_ShipmentID"].Value = mFile.ShipmentID;
            insetComm.Parameters["@EPD_ISBN"].Value = mFile.ISBN;
            insetComm.Parameters["@EPD_UID"].Value = mFile.UserID;
            insetComm.Parameters["@EPD_FormatName"].Value = mFile.FormatName;
            insetComm.Parameters["@EPD_DoneDate"].Value = mFile.StartDate;
            insetComm.Parameters["@EPD_Status"].Value = mFile.Status;


            insetComm.CommandText = "INSERT INTO ProductionStatus(ProductID,ShipmentID,ISBN,UserID,FormatName,StartDate,Status) VALUES (@EPD_ShpID,@EPD_ShipmentID,@EPD_ISBN,@EPD_UID,@EPD_FormatName,@EPD_DoneDate,@EPD_Status)";

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

        public int UpdateProductionStatusLog(ProductionStatus mStatus)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;
            updateComm.Parameters.Add("@Log_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@Log_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Log_FormatName", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Log_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Log_UID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Log_StartDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@Log_PrStatus", SqlDbType.NVarChar);

            updateComm.Parameters["@Log_ShpID"].Value = mStatus.ProductID;
            updateComm.Parameters["@Log_ShipmentID"].Value = mStatus.ShipmentID;
            updateComm.Parameters["@Log_FormatName"].Value = mStatus.FormatName;
            updateComm.Parameters["@Log_ISBN"].Value = mStatus.ISBN;
            updateComm.Parameters["@Log_UID"].Value = mStatus.UserID;
            updateComm.Parameters["@Log_StartDate"].Value = mStatus.StartDate;
            updateComm.Parameters["@Log_PrStatus"].Value = mStatus.Status;


            updateComm.CommandText = "UPDATE ProductionStatus SET Status=@Log_PrStatus, StartDate=@Log_StartDate, WHERE ProductID=@Log_ShpID AND ShipmentID=@Log_ShipmentID AND FormatName=@Log_FormatName AND ISBN=@Log_ISBN AND UserID=@Log_UID";
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
    }
}

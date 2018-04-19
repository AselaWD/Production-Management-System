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
    //ProductID	    bigint	        Unchecked
    //ShipmentID	varchar(500)	Unchecked
    //ISBN	        varchar(20)	    Unchecked
    //FormatName	varchar(100)	Unchecked

    class QRHeaderMng
    {
         //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public QRHeaderMng(){

        }
        // Constructor Overload
        public QRHeaderMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }


        public int AddQRHeader(QRHeader mDetail)
        {

            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@QRD_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@QRD_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@QRD_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@QRD_ISBN", SqlDbType.NVarChar);

            insetComm.Parameters["@QRD_ShpID"].Value = mDetail.ProductID;
            insetComm.Parameters["@QRD_ShipmentID"].Value = mDetail.ShipmentID;
            insetComm.Parameters["@QRD_FormatName"].Value = mDetail.FormatName;
            insetComm.Parameters["@QRD_ISBN"].Value = mDetail.ISBN;

            insetComm.CommandText = "INSERT INTO QRHeader(ProductID,ShipmentID,FormatName,ISBN) VALUES(@QRD_ShpID,@QRD_ShipmentID,@QRD_FormatName,@QRD_ISBN)";
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

        public int DeleteQRHeader(QRHeader mDetail)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@Sh_ShpID", SqlDbType.BigInt);
            deleteComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.VarChar);
            deleteComm.Parameters.Add("@Sh_FormatName", SqlDbType.VarChar);
            deleteComm.Parameters.Add("@Sh_ISBN", SqlDbType.VarChar);

            deleteComm.Parameters["@Sh_ShpID"].Value = mDetail.ProductID;
            deleteComm.Parameters["@Sh_ShipmentID"].Value = mDetail.ShipmentID;
            deleteComm.Parameters["@Sh_FormatName"].Value = mDetail.FormatName;
            deleteComm.Parameters["@Sh_ISBN"].Value = mDetail.ISBN;

            deleteComm.CommandText = "DELETE FROM QRHeader WHERE ProductID=@Sh_ShpID AND ShipmentID=@Sh_ShipmentID AND FormatName=@Sh_FormatName AND ISBN=@Sh_ISBN";
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

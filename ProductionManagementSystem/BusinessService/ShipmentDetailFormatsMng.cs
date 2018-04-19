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
        //ShpID	            bigint	        Unchecked
        //ShipmentID	    varchar(500)	Unchecked
        //FormatName	    varchar(100)	Unchecked
        //ProductionStatus	varchar(100)	Checked

    class ShipmentDetailFormatsMng
    {

        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public ShipmentDetailFormatsMng()
        {

        }
        // Constructor Overload
        public ShipmentDetailFormatsMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddShimpentFormats(ShipmentDetailFormats mShFormat)
        {

            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@ShF_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@ShF_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@ShF_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@ShF_ProductionStatus", SqlDbType.NVarChar);


            insetComm.Parameters["@ShF_ShpID"].Value = mShFormat.ShpID;
            insetComm.Parameters["@ShF_ShipmentID"].Value = mShFormat.ShipmentID;
            insetComm.Parameters["@ShF_FormatName"].Value = mShFormat.FormatName;
            insetComm.Parameters["@ShF_ProductionStatus"].Value = mShFormat.ProductionStatus;

            insetComm.CommandText = "insert into ShipmentDetailFormats(ShpID,ShipmentID,FormatName,ProductionStatus)values(@ShF_ShpID,@ShF_ShipmentID,@ShF_FormatName,@ShF_ProductionStatus)";
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

        public int UpdateShimpentFormats(ShipmentDetailFormats mShFormat)
        {

            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@ShF_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@ShF_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@ShF_FormatName", SqlDbType.NVarChar);

            updateComm.Parameters["@ShF_ShpID"].Value = mShFormat.ShpID;
            updateComm.Parameters["@ShF_ShipmentID"].Value = mShFormat.ShipmentID;
            updateComm.Parameters["@ShF_FormatName"].Value = mShFormat.FormatName;

            updateComm.CommandText = "update ShipmentDetailFormats set ShipmentID=@ShF_ShipmentID, FormatName=@ShF_FormatName where ShpID=@ShF_ShpID";
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

        public int UpdateProductionOnSipmentFormatFile(ShipmentDetailFormats mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Format", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ProductionStatus", SqlDbType.NVarChar);



            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_Format"].Value = mFile.FormatName;
            updateComm.Parameters["@Sh_ProductionStatus"].Value = mFile.ProductionStatus;


            updateComm.CommandText = "UPDATE ShipmentDetailFormats SET ProductionStatus='Process By User' WHERE ShpID=@Sh_ShpID AND ShipmentID=@Sh_ShipmentID AND FormatName=@Sh_Format";
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

        public int UpdateProductionOnToBeAssignFormatFile(ShipmentDetailFormats mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Format", SqlDbType.NVarChar);
            //updateComm.Parameters.Add("@Sh_ProductionStatus", SqlDbType.NVarChar);



            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_Format"].Value = mFile.FormatName;
            //updateComm.Parameters["@Sh_ProductionStatus"].Value = mFile.ProductionStatus;


            updateComm.CommandText = "UPDATE ShipmentDetailFormats SET ProductionStatus='Not Assigned' WHERE ShpID=@Sh_ShpID AND ShipmentID=@Sh_ShipmentID AND FormatName=@Sh_Format";
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

        public int UpdateProductionFormatDoneFileByUser(ShipmentDetailFormats mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Format", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ProductionStatus", SqlDbType.NVarChar);

            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_Format"].Value = mFile.FormatName;
            updateComm.Parameters["@Sh_ProductionStatus"].Value = mFile.ProductionStatus;


            updateComm.CommandText = "UPDATE ShipmentDetailFormats SET ProductionStatus=@Sh_ProductionStatus WHERE ShpID=@Sh_ShpID AND ShipmentID=@Sh_ShipmentID AND FormatName=@Sh_Format";
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

        public int DeleteShimpentFormats(String mShFormat)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@ShF_ShipmentID", SqlDbType.VarChar);

            deleteComm.Parameters["@ShF_ShipmentID"].Value = mShFormat;


            deleteComm.CommandText = "delete from ShipmentDetailFormats where ShipmentID=@ShF_ShipmentID";
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

        public int DeleteFormatsByShID(ShipmentDetailFormats mShID)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@ShF_ShpID", SqlDbType.VarChar);

            deleteComm.Parameters["@ShF_ShpID"].Value = mShID.ShpID;


            deleteComm.CommandText = "delete from ShipmentDetailFormats where ShpID=@ShF_ShpID";
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

        public List<String> GetAllFormats()
        {
            List<String> uFormat = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT FormatName FROM Format", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                uFormat.Add(row[0].ToString());
            }
            return uFormat;
        }

    }
}

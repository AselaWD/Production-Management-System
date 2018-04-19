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
        //ShipmentID	    varchar(500)	Checked
        //FormatName	    varchar(100)	Checked
        //ISBN	            varchar(20) 	Checked
        //UserID	        varchar(50)	    Checked
        //PageCount	        int         	Checked
        //StartDate	        datetime2(7)	Checked
        //ProductionStatus	varchar(100)	Checked

    class ProductionManagementDetailMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public ProductionManagementDetailMng(){

        }
        // Constructor Overload
        public ProductionManagementDetailMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddProductionManagementDetail(ProductionManagementDetail mProductionDtl)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@PMD_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@PMD_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@PMD_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@PMD_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@PMD_UID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@PMD_PageCount", SqlDbType.BigInt);
            insetComm.Parameters.Add("@PMD_StartDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@PMD_PrStatus", SqlDbType.NVarChar);

            insetComm.Parameters["@PMD_ShpID"].Value = mProductionDtl.ShpID;
            insetComm.Parameters["@PMD_ShipmentID"].Value = mProductionDtl.ShipmentID;
            insetComm.Parameters["@PMD_FormatName"].Value = mProductionDtl.Format;
            insetComm.Parameters["@PMD_ISBN"].Value = mProductionDtl.ISBN;
            insetComm.Parameters["@PMD_UID"].Value = mProductionDtl.UserID;
            insetComm.Parameters["@PMD_PageCount"].Value = mProductionDtl.PageCount;
            insetComm.Parameters["@PMD_StartDate"].Value = mProductionDtl.StartDate;
            insetComm.Parameters["@PMD_PrStatus"].Value = mProductionDtl.ProductionStatus;


            insetComm.CommandText = "INSERT INTO ProductionManagementDetail(ShpID,ShipmentID,FormatName,ISBN,UserID,PageCount,StartDate,ProductionStatus) VALUES(@PMD_ShpID,@PMD_ShipmentID,@PMD_FormatName,@PMD_ISBN,@PMD_UID,@PMD_PageCount,@PMD_StartDate,@PMD_PrStatus)";
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

        public int UpdateAssignedFile(ProductionManagementDetail mProductionDtl)
        {

            //insert values into databse
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@PMD_ProductionID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@PMD_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@PMD_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@PMD_Format", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@PMD_UserID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@PMD_Status", SqlDbType.NVarChar);

            updateComm.Parameters["@PMD_ProductionID"].Value = mProductionDtl.ShpID;
            updateComm.Parameters["@PMD_ShipmentID"].Value = mProductionDtl.ShipmentID;
            updateComm.Parameters["@PMD_ISBN"].Value = mProductionDtl.ISBN;
            updateComm.Parameters["@PMD_Format"].Value = mProductionDtl.Format;
            updateComm.Parameters["@PMD_UserID"].Value = mProductionDtl.UserID;
            updateComm.Parameters["@PMD_Status"].Value = mProductionDtl.ProductionStatus;

            updateComm.CommandText = "UPDATE ProductionManagementDetail SET UserID=@PMD_UserID WHERE ShpID=@PMD_ProductionID AND ShipmentID=@PMD_ShipmentID AND ISBN=@PMD_ISBN AND FormatName=@PMD_Format";

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

        public int DeleteAssignedProductionManagementDetail(ProductionManagementDetail mProductionDtl)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@Sh_ShpID", SqlDbType.BigInt);
            deleteComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.VarChar);
            deleteComm.Parameters.Add("@Sh_FormatName", SqlDbType.VarChar);
            deleteComm.Parameters.Add("@Sh_ISBN", SqlDbType.VarChar);

            deleteComm.Parameters["@Sh_ShpID"].Value = mProductionDtl.ShpID;
            deleteComm.Parameters["@Sh_ShipmentID"].Value = mProductionDtl.ShipmentID;
            deleteComm.Parameters["@Sh_FormatName"].Value = mProductionDtl.Format;
            deleteComm.Parameters["@Sh_ISBN"].Value = mProductionDtl.ISBN;

            deleteComm.CommandText = "DELETE FROM ProductionManagementDetail WHERE ShpID=@Sh_ShpID AND ShipmentID=@Sh_ShipmentID AND FormatName=@Sh_FormatName AND ISBN=@Sh_ISBN";
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

        public DataTable GetAllAssignedProduction(String mShipmentID)
        {

            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mPMD_ShpID", SqlDbType.VarChar);


            SelectCommand.Parameters["@mPMD_ShpID"].Value = mShipmentID;


            SelectCommand.CommandText = "select ShpID as [ID], ShipmentID as [Shipment], ISBN as [ISBN], FormatName as [Format], UserID as [User ID], PageCount as [Page Count], StartDate as [Star Date], ProductionStatus as [Status] from ProductionManagementDetail WHERE ShipmentID=@mPMD_ShpID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public DataTable rptViewGetAllAssignedProduction()
        {

            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;


            SelectCommand.CommandText = "select * from IncentiveApplied";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

        public bool UserIsExistrptViewGetAllAssignedProduction(String mUserID)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@User_ID", SqlDbType.VarChar);

            SelectCommand.Parameters["@User_ID"].Value = mUserID;

            SelectCommand.CommandText = "SELECT UserID FROM IncentiveApplied where UserID = @User_ID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            int rowCount = table.Rows.Count;

            if (rowCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNulltrptViewGetAllAssignedProduction()
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.CommandText = "SELECT * FROM IncentiveApplied";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            int rowCount = table.Rows.Count;

            if (rowCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ShipmentIsExist(String mShipmentID)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mTAT_ShpID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mTAT_ShpID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT ShipmentID FROM ShipmentDetail WHERE ShipmentID=@mTAT_ShpID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            int rowCount = table.Rows.Count;

            if (rowCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

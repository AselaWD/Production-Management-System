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
    //UserID	    varchar(50)	    Unchecked
    //QRDate	    datetime	    Checked
    //Status	    varchar(100)	Checked

    class QRDetailMng
    {
         //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public QRDetailMng()
        {

        }
        // Constructor Overload
        public QRDetailMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddQRDetail(QRDetail mDetail)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;
            insetComm.Parameters.Add("@QRD_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@QRD_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@QRD_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@QRD_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@QRD_PageCount", SqlDbType.Int);
            insetComm.Parameters.Add("@QRD_UID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@QRD_QRDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@QRD_PrStatus", SqlDbType.NVarChar);

            insetComm.Parameters["@QRD_ShpID"].Value = mDetail.ProductID;
            insetComm.Parameters["@QRD_ShipmentID"].Value = mDetail.ShipmentID;
            insetComm.Parameters["@QRD_FormatName"].Value = mDetail.FormatName;
            insetComm.Parameters["@QRD_ISBN"].Value = mDetail.ISBN;
            insetComm.Parameters["@QRD_PageCount"].Value = mDetail.PageCount;
            insetComm.Parameters["@QRD_UID"].Value = mDetail.UserID;
            insetComm.Parameters["@QRD_QRDate"].Value = mDetail.QRDate;
            insetComm.Parameters["@QRD_PrStatus"].Value = mDetail.Status;


            insetComm.CommandText = "INSERT INTO QRDetail(ProductID,ShipmentID,FormatName,ISBN, PageCount,UserID,QRDate,Status) VALUES(@QRD_ShpID,@QRD_ShipmentID,@QRD_FormatName,@QRD_ISBN,@QRD_PageCount,@QRD_UID,@QRD_QRDate,@QRD_PrStatus)";
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

        public int DeleteQRDetail(QRDetail mDetail)
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

            deleteComm.CommandText = "DELETE FROM QRDetail WHERE ProductID=@Sh_ShpID AND ShipmentID=@Sh_ShipmentID AND FormatName=@Sh_FormatName AND ISBN=@Sh_ISBN";
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


        public DataTable GetAllShipmentsBeforeQRDone(String mShipmentID, String mUID)//INNER JOIN to filter TAT assigned & Production Status Complete By User files
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],f.FormatName as [Format],f.PageCount as [Page Count], s.PubDate as [Pub Date], s.TATDate as [TAT Date] FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Complete By User' AND f.UserID=@mSh_UserID";

            //SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],f.PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date] FROM ShipmentDetail s INNER JOIN ProductionManagementDetail f ON s.TATDelivery=1 AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN

        public DataTable GetAllFilesAfterQRDone(String mShipmentID, String mUID)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT ProductID as [ID],ShipmentID as [Shipment],ISBN as [Printed ISBN],UserID as [User ID],PageCount as [Page Count],FormatName as [Format],QRDate as [Completed Date],Status as [Status] FROM QRDetail WHERE ShipmentID=@mSh_ShpID AND Status='QR Done' AND UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetISBNBeforeQRDone(String mShipmentID, String mUID, String mISBN)//INNER JOIN to filter TAT assigned & Production Status Complete By User files
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_ISBN", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;
            SelectCommand.Parameters["@mSh_ISBN"].Value = mISBN;

            SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],f.FormatName as [Format],f.PageCount as [Page Count], s.PubDate as [Pub Date], s.TATDate as [TAT Date] FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Complete By User' AND f.UserID=@mSh_UserID AND f.ISBN=@mSh_ISBN";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN 

        public DataTable GetISBNBAfterUserQRDone(String mShipmentID, String mUID, String mISBN)//INNER JOIN to filter TAT assigned & Production Status QR Done files
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_ISBN", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;
            SelectCommand.Parameters["@mSh_ISBN"].Value = mISBN;

            SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],f.FormatName as [Format],f.PageCount as [Page Count], s.PubDate as [Pub Date], s.TATDate as [TAT Date] FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='QR Done' AND f.UserID=@mSh_UserID AND f.ISBN=@mSh_ISBN";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN

        public int GetAllShipmentCountBeforeQRDone(String mShipmentID, String mUID)//INNER JOIN to get Count TAT assigned & Production Status Complete By User file
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT COUNT(f.FormatName) FROM ShipmentDetail s INNER JOIN ProductionManagementDetail f ON s.TATDelivery=1 AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Complete By User' AND f.UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            int mCount = 0;

            foreach (DataRow row in table.Rows)
            {
                mCount = int.Parse(row[0].ToString());
            }
            return mCount;

        } //INNER JOIN 
    }
}

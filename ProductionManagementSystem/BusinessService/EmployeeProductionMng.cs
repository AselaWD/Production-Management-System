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
    //UserID	    varchar(50)	    Checked
    //PageCount	    int	            Checked
    //FormatName	varchar(100)	Unchecked
    //Status	    varchar(100)	Unchecked
    //DoneDate	    datetime	    Checked

    class EmployeeProductionMng
    {

        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public EmployeeProductionMng()
        {

        }
        // Constructor Overload
        public EmployeeProductionMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddUserProdcutionDone(EmployeeProduction mFile)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@EPD_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@EPD_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_UID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_PageCount", SqlDbType.Int);
            insetComm.Parameters.Add("@EPD_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@EPD_DoneDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@EPD_Status", SqlDbType.NVarChar);


            insetComm.Parameters["@EPD_ShpID"].Value = mFile.ProductID;
            insetComm.Parameters["@EPD_ShipmentID"].Value = mFile.ShipmentID;
            insetComm.Parameters["@EPD_ISBN"].Value = mFile.ISBN;
            insetComm.Parameters["@EPD_UID"].Value = mFile.UserID;
            insetComm.Parameters["@EPD_PageCount"].Value = mFile.PageCount;
            insetComm.Parameters["@EPD_FormatName"].Value = mFile.FormatName;
            insetComm.Parameters["@EPD_DoneDate"].Value = mFile.DoneDate;
            insetComm.Parameters["@EPD_Status"].Value = mFile.Status;


            insetComm.CommandText = "INSERT INTO EmployeeProduction(ProductID,ShipmentID,ISBN,UserID,PageCount,FormatName,DoneDate,Status) VALUES (@EPD_ShpID,@EPD_ShipmentID,@EPD_ISBN,@EPD_UID,@EPD_PageCount,@EPD_FormatName,@EPD_DoneDate,@EPD_Status)";

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


        //public int UpdateQRDone(EmployeeProduction mFile)
        //{
        //    //insert databse values
        //    SqlCommand updateComm = new SqlCommand();
        //    updateComm.Connection = this.mConnectionUser;
        //    updateComm.CommandType = CommandType.Text;

        //    updateComm.Parameters.Add("@EPD_ShpID", SqlDbType.BigInt);
        //    updateComm.Parameters.Add("@EPD_ShipmentID", SqlDbType.NVarChar);
        //    updateComm.Parameters.Add("@EPD_ISBN", SqlDbType.NVarChar);
        //    updateComm.Parameters.Add("@EPD_UID", SqlDbType.NVarChar);
        //    updateComm.Parameters.Add("@EPD_PageCount", SqlDbType.Int);
        //    updateComm.Parameters.Add("@EPD_FormatName", SqlDbType.NVarChar);
        //    updateComm.Parameters.Add("@EPD_DoneDate", SqlDbType.DateTime);
        //    updateComm.Parameters.Add("@EPD_Status", SqlDbType.NVarChar);


        //    updateComm.Parameters["@EPD_ShpID"].Value = mFile.ProductID;
        //    updateComm.Parameters["@EPD_ShipmentID"].Value = mFile.ShipmentID;
        //    updateComm.Parameters["@EPD_ISBN"].Value = mFile.ISBN;
        //    updateComm.Parameters["@EPD_UID"].Value = mFile.UserID;
        //    updateComm.Parameters["@EPD_PageCount"].Value = mFile.PageCount;
        //    updateComm.Parameters["@EPD_FormatName"].Value = mFile.FormatName;
        //    updateComm.Parameters["@EPD_DoneDate"].Value = mFile.DoneDate;
        //    updateComm.Parameters["@EPD_Status"].Value = mFile.Status;

        //    updateComm.CommandText = "UPDATE EmployeeProduction SET Status=@EPD_Status, DoneDate=@EPD_DoneDate WHERE ProductID=@EPD_ShpID AND ShipmentID=@EPD_ShipmentID AND ISBN=@EPD_ISBN AND PageCount=@EPD_PageCount AND FormatName=@EPD_FormatName";

        //    int ans = updateComm.ExecuteNonQuery();
        //    if (ans > 0)
        //    {
        //        return ans;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}

        public int UpdateProductionStatus(EmployeeProduction mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@EPD_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@EPD_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@EPD_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@EPD_UID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@EPD_FormatName", SqlDbType.NVarChar);
            //updateComm.Parameters.Add("@EPD_DoneDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@EPD_Status", SqlDbType.NVarChar);


            updateComm.Parameters["@EPD_ShpID"].Value = mFile.ProductID;
            updateComm.Parameters["@EPD_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@EPD_ISBN"].Value = mFile.ISBN;
            updateComm.Parameters["@EPD_UID"].Value = mFile.UserID;
            updateComm.Parameters["@EPD_FormatName"].Value = mFile.FormatName;
            //updateComm.Parameters["@EPD_DoneDate"].Value = mFile.DoneDate;
            updateComm.Parameters["@EPD_Status"].Value = mFile.Status;

            updateComm.CommandText = "UPDATE EmployeeProduction SET Status=@EPD_Status WHERE ProductID=@EPD_ShpID AND ShipmentID=@EPD_ShipmentID AND ISBN=@EPD_ISBN AND FormatName=@EPD_FormatName";

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

        public int DeleteUserProdcutionDone(EmployeeProduction mFile)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@PMD_ProductionID", SqlDbType.NVarChar);
            deleteComm.Parameters.Add("@PMD_ShipmentID", SqlDbType.NVarChar);
            deleteComm.Parameters.Add("@PMD_ISBN", SqlDbType.NVarChar);
            deleteComm.Parameters.Add("@PMD_Format", SqlDbType.NVarChar);
            //deleteComm.Parameters.Add("@PMD_UserID", SqlDbType.NVarChar);
            //deleteComm.Parameters.Add("@PMD_Status", SqlDbType.NVarChar);

            deleteComm.Parameters["@PMD_ProductionID"].Value = mFile.ProductID;
            deleteComm.Parameters["@PMD_ShipmentID"].Value = mFile.ShipmentID;
            deleteComm.Parameters["@PMD_ISBN"].Value = mFile.ISBN;
            deleteComm.Parameters["@PMD_Format"].Value = mFile.FormatName;
            //deleteComm.Parameters["@User_ID"].Value = mFile.UserID;
            //deleteComm.Parameters["@PMD_Status"].Value = mFile.Status;


            deleteComm.CommandText = "DELETE FROM EmployeeProduction WHERE ProductID=@PMD_ProductionID AND ShipmentID=@PMD_ShipmentID AND ISBN=@PMD_ISBN AND FormatName=@PMD_Format";
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

        public DataTable GetAllShipmentsBeforeUserProductionDone(String mShipmentID, String mUID)//INNER JOIN to filter TAT assigned & Production Status Process By User files
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],f.FormatName as [Format],f.PageCount as [Page Count], s.PubDate as [Pub Date], s.TATDate as [TAT Date] FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID";

            //SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],f.PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date] FROM ShipmentDetail s INNER JOIN ProductionManagementDetail f ON s.TATDelivery=1 AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN 

        public DataTable GetISBNBeforeUserProductionDone(String mShipmentID, String mUID, String mISBN)//INNER JOIN to filter TAT assigned & Production Status Process By User files
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

            SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],f.FormatName as [Format],f.PageCount as [Page Count], s.PubDate as [Pub Date], s.TATDate as [TAT Date] FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID AND f.ISBN=@mSh_ISBN";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN 

        public DataTable GetISBNBAfterUserProductionDone(String mShipmentID, String mUID, String mISBN)//INNER JOIN to filter TAT assigned & Production Status Process By User files
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

        public int GetAllShipmentCountBeforeUserProductionDone(String mShipmentID, String mUID)//INNER JOIN to get Count TAT assigned & Production Status Process By User file
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT COUNT(f.FormatName) FROM ShipmentDetail s INNER JOIN ProductionManagementDetail f ON s.TATDelivery=1 AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID;";

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

        public List<String> GetAllISBNByUser(String mShipmentID, String mUID)//INNER JOIN to filter TAT assigned & Production Status Process By User ISBNs
        {
            List<String> mISBN = new List<string>();

            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT s.ISBN FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.UserID=@mSh_UserID";

            //SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],f.PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date] FROM ShipmentDetail s INNER JOIN ProductionManagementDetail f ON s.TATDelivery=1 AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mISBN.Add(row[0].ToString());
            }
            return mISBN;

        } //INNER JOIN 

        public List<String> GetAllQRISBNByUser(String mShipmentID, String mUID)//INNER JOIN to filter TAT assigned & Production Status Process By User ISBNs
        {
            List<String> mISBN = new List<string>();

            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT s.ISBN FROM ProductionManagementDetail f INNER JOIN TATDelivery s ON f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.UserID=@mSh_UserID AND f.ProductionStatus='Complete By User'";

            //SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],f.PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date] FROM ShipmentDetail s INNER JOIN ProductionManagementDetail f ON s.TATDelivery=1 AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID AND f.ProductionStatus='Process By User' AND f.UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mISBN.Add(row[0].ToString());
            }
            return mISBN;

        } //INNER JOIN

        public DataTable GetAllFilesAfterUserProductionDone(String mShipmentID, String mUID)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_UserID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_UserID"].Value = mUID;

            SelectCommand.CommandText = "SELECT ProductID as [ID],ShipmentID as [Shipment],ISBN as [Printed ISBN],UserID as [User ID],PageCount as [Page Count],FormatName as [Format],DoneDate as [Completed Date],Status as [Status] FROM EmployeeProduction WHERE ShipmentID=@mSh_ShpID AND Status='Complete By User' AND UserID=@mSh_UserID;";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetAllEmployeeProduction()
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.CommandText = "SELECT * FROM EmployeeProduction";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetAllIncentivesForPageCountSUM()
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.CommandText = "SELECT * FROM IncentivesForPageCountSUM";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public bool UserIsExistIncentivesForPageCountSUM(String mUserID)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@User_ID", SqlDbType.VarChar);

            SelectCommand.Parameters["@User_ID"].Value = mUserID;

            SelectCommand.CommandText = "SELECT UserID FROM IncentivesForPageCountSUM where UserID = @User_ID";

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

        public DataTable GetAllDailyProductionSummary()
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.CommandText = "SELECT * FROM ProductionSummary";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetFileMetadata(int mShpID, String mShipmentID)
        {

            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.BigInt);
            SelectCommand.Parameters.Add("@mSh_mShipmentID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShpID.ToString();
            SelectCommand.Parameters["@mSh_mShipmentID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT Publisher,ISBN,DISBN,Title,Author,Author1,PageCount,PubDate,Language,Format,PCPCode,Comment FROM ShipmentDetail WHERE shpID=@mSh_ShpID AND ShipmentID=@mSh_mShipmentID";
            
            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;


        }

        public List<String> GetAllUserIDProductionEmployee()
        {
            List<String> mUID = new List<string>();

            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.CommandText = "SELECT UserID FROM EmployeeProduction GROUP BY UserID";


            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mUID.Add(row[0].ToString());
            }
            return mUID;

        }

        public List<String> GetAllShipmentIDProductionEmployee()
        {
            List<String> mUID = new List<string>();

            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.CommandText = "SELECT ShipmentID FROM EmployeeProduction GROUP By ShipmentID";


            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mUID.Add(row[0].ToString());
            }
            return mUID;

        }
    }
}

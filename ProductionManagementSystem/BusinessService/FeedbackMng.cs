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
    //FeedbackID	varchar(500)	Unchecked
    //ShpID	        bigint	        Unchecked
    //ShipmentID	varchar(500)	Unchecked
    //ISBN	        varchar(20)	    Checked
    //FormatName	varchar(100)	Unchecked
    //FeedbackDate	datetime	    Checked
    //Remark	    varchar(5000)	Checked

    class FeedbackMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public FeedbackMng()
        {

        }
        // Constructor Overload
        public FeedbackMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddFeedback(Feedback mFile)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@CF_ShpID", SqlDbType.Int);
            insetComm.Parameters.Add("@CF_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_FeedbackDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@CF_Remark", SqlDbType.NVarChar);

            insetComm.Parameters["@CF_ShpID"].Value = mFile.ShpID;
            insetComm.Parameters["@CF_ShipmentID"].Value = mFile.ShipmentID;
            insetComm.Parameters["@CF_ISBN"].Value = mFile.ISBN;
            insetComm.Parameters["@CF_FormatName"].Value = mFile.FormatName;
            insetComm.Parameters["@CF_FeedbackDate"].Value = mFile.FeedbackDate;
            insetComm.Parameters["@CF_Remark"].Value = mFile.Remark;

            insetComm.CommandText = "INSERT INTO FeedbackTracking(ShpID,ShipmentID,ISBN,FormatName,FeedbackDate,Remark) VALUES (@CF_ShpID,@CF_ShipmentID,@CF_ISBN,@CF_FormatName,@CF_FeedbackDate,@CF_Remark)";
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

        public int DeleteFeedback(Feedback mFile)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@CF_ShpID", SqlDbType.Int);
            insetComm.Parameters.Add("@CF_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_FormatName", SqlDbType.NVarChar);

            insetComm.Parameters["@CF_ShpID"].Value = mFile.ShpID;
            insetComm.Parameters["@CF_ShipmentID"].Value = mFile.ShipmentID;
            insetComm.Parameters["@CF_ISBN"].Value = mFile.ISBN;
            insetComm.Parameters["@CF_FormatName"].Value = mFile.FormatName;

            insetComm.CommandText = "DELETE FROM FeedbackTracking WHERE ShpID=@CF_ShpID AND ShipmentID=@CF_ShipmentID AND ISBN=@CF_ISBN AND FormatName=@CF_FormatName";
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

        public int UpdateFeedback(Feedback mFile)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@CF_ShpID", SqlDbType.Int);
            insetComm.Parameters.Add("@CF_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_FormatName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@CF_FeedbackDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@CF_Remark", SqlDbType.NVarChar);

            insetComm.Parameters["@CF_ShpID"].Value = mFile.ShpID;
            insetComm.Parameters["@CF_ShipmentID"].Value = mFile.ShipmentID;
            insetComm.Parameters["@CF_ISBN"].Value = mFile.ISBN;
            insetComm.Parameters["@CF_FormatName"].Value = mFile.FormatName;
            insetComm.Parameters["@CF_FeedbackDate"].Value = mFile.FeedbackDate;
            insetComm.Parameters["@CF_Remark"].Value = mFile.Remark;

            insetComm.CommandText = "UPDATE FeedbackTracking SET FeedbackDate=@CF_FeedbackDate, Remark=@CF_Remark WHERE ShpID=@CF_ShpID AND ShipmentID=@CF_ShipmentID AND ISBN=@CF_ISBN AND FormatName=@CF_FormatName";
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

        public DataTable GetAllFeedbackFilesByShipment(String mShipmentID)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;


            SelectCommand.CommandText = "SELECT ShpID as[Product ID], ShipmentID as [Shipment Name],ISBN as [ISBN],FormatName as [Format Name],FeedbackDate as [Feedback Date], Remark as [Remark] FROM FeedbackTracking WHERE ShipmentID=@mSh_ShpID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetAllFeedbackFilesByISBN(String mShipmentID, String mISBN)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_ISBN", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_ISBN"].Value = mISBN;


            SelectCommand.CommandText = "SELECT ShpID as[Product ID], ShipmentID as [Shipment Name],ISBN as [ISBN],FormatName as [Format Name],FeedbackDate as [Feedback Date], Remark as [Remark] FROM FeedbackTracking WHERE ShipmentID=@mSh_ShpID AND ISBN=@mSh_ISBN";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public List<String> GetAllXmittedISBN(String mShipmentID)//INNER JOIN to filter Transmitted Done ISBNs
        {
            List<String> mISBN = new List<string>();

            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT s.ISBN FROM ShipmentDetailFormats f INNER JOIN ShipmentDetail s ON s.TransmissionDone=1 AND s.ClientFeedback=0 AND f.ProductionStatus='QR Done' AND f.ShipmentID=@mSh_ShpID";

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

        

    }
}

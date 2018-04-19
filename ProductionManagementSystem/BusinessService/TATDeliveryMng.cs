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
    //ShpID                  bigint         Unchecked
    //ShipmentID           	 varchar(500)	Unchecked
    //ISBN	                 varchar(20)    Checked
    //PriorityName           varchar(50)	Checked
    //FormatName             varchar(100)	Checked
    //PubDate	             datetime2(7)	Checked
    //TATDate	             datetime2(7)	Checked
    //DateOfAllocation	     datetime(7)	Checked
    //Team                   varchar(100)	Checked

    class TATDeliveryMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public TATDeliveryMng()
        {

        }
        // Constructor Overload
        public TATDeliveryMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddTAT(TATDelivery mTAT)
        {

            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@TAT_ShpID", SqlDbType.BigInt);
            insetComm.Parameters.Add("@TAT_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@TAT_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@TAT_Priority", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@TAT_Format", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@TAT_PubDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@TAT_TATDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@TAT_DateOfAllocation", SqlDbType.DateTime);
            insetComm.Parameters.Add("@TAT_TeamName", SqlDbType.NVarChar);

            insetComm.Parameters["@TAT_ShpID"].Value = mTAT.ShpID;
            insetComm.Parameters["@TAT_ShipmentID"].Value = mTAT.ShipmentID;
            insetComm.Parameters["@TAT_ISBN"].Value = mTAT.ISBN;
            insetComm.Parameters["@TAT_Priority"].Value = mTAT.PriorityName;
            insetComm.Parameters["@TAT_Format"].Value = mTAT.Format;
            insetComm.Parameters["@TAT_PubDate"].Value = mTAT.PubDate;
            insetComm.Parameters["@TAT_TATDate"].Value = mTAT.TATDate;
            insetComm.Parameters["@TAT_DateOfAllocation"].Value = mTAT.DateOfAllocation;
            insetComm.Parameters["@TAT_TeamName"].Value = mTAT.TeamName;

            insetComm.CommandText = "insert into TATDelivery(ShpID,ShipmentID,ISBN,PriorityName,FormatName,PubDate,TATDate,DateOfAllocation,Team)values(@TAT_ShpID,@TAT_ShipmentID,@TAT_ISBN,@TAT_Priority,@TAT_Format,@TAT_PubDate,@TAT_TATDate,@TAT_DateOfAllocation,@TAT_TeamName)";

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

        public int DeleteTAT(String mTAT)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@TAT_ShipmentID", SqlDbType.VarChar);

            deleteComm.Parameters["@TAT_ShipmentID"].Value = mTAT;


            deleteComm.CommandText = "delete from TATDelivery where ShipmentID=@TAT_ShipmentID";
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

        public int UpdateTAT(TATDelivery mTAT)
        {

            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@TAT_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_Priority", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_Format", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_PubDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@TAT_TATDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@DateOfAllocation", SqlDbType.DateTime);

            updateComm.Parameters["@TAT_ShipmentID"].Value = mTAT.ShipmentID;
            updateComm.Parameters["@TAT_ISBN"].Value = mTAT.ISBN;
            updateComm.Parameters["@TAT_Priority"].Value = mTAT.PriorityName;
            updateComm.Parameters["@TAT_Format"].Value = mTAT.Format;
            updateComm.Parameters["@TAT_PubDate"].Value = mTAT.PubDate;
            updateComm.Parameters["@TAT_TATDate"].Value = mTAT.TATDate;
            updateComm.Parameters["@DateOfAllocation"].Value = mTAT.DateOfAllocation;

            updateComm.CommandText = "update TATDelivery set TATDate=@TAT_TATDate, PriorityName=@TAT_Priority where ShipmentID=@TAT_ShipmentID AND ISBN=@TAT_ISBN";

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

        public int ClearTAT(TATDelivery mTAT)
        {

            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@TAT_ShpID", SqlDbType.BigInt);
            updateComm.Parameters.Add("@TAT_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_Priority", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_Format", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@TAT_PubDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@TAT_TATDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@DateOfAllocation", SqlDbType.DateTime);

            updateComm.Parameters["@TAT_ShpID"].Value = mTAT.ShpID;
            updateComm.Parameters["@TAT_ShipmentID"].Value = mTAT.ShipmentID;
            updateComm.Parameters["@TAT_ISBN"].Value = mTAT.ISBN;
            updateComm.Parameters["@TAT_Priority"].Value = mTAT.PriorityName;
            updateComm.Parameters["@TAT_Format"].Value = mTAT.Format;
            updateComm.Parameters["@TAT_PubDate"].Value = mTAT.PubDate;
            updateComm.Parameters["@TAT_TATDate"].Value = mTAT.TATDate;
            updateComm.Parameters["@DateOfAllocation"].Value = mTAT.DateOfAllocation;

            updateComm.CommandText = "delete from TATDelivery where ShipmentID=@TAT_ShipmentID AND ISBN=@TAT_ISBN AND ShpID=@TAT_ShpID";

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

        public DataTable GetAllShipments(String mShipmentID)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mTAT_ShpID", SqlDbType.VarChar);
            

            SelectCommand.Parameters["@mTAT_ShpID"].Value = mShipmentID;
            

            SelectCommand.CommandText = "select ShpID as [ID], ShipmentID as [Shipment],ISBN as [ISBN],TATDate as [TAT Date],PriorityName as [Priority], Team as [Team Name], FormatName as [Format],PubDate as [Pub Date], DateOfAllocation as [Recieved Date] from TATDelivery WHERE ShipmentID=@mTAT_ShpID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public List<String> GetAllShipmentsByShipment()
        {
            List<String> mTATShip = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select ShipmentID from TATDelivery", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mTATShip.Add(row[0].ToString());
            }
            return mTATShip;
        }

        public DataTable GetAllShipmentsByNullPriority()
        {

            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = new SqlCommand("select ShipmentID as [Shipment],ISBN as [ISBN],PriorityName as [Priority],FormatName as [Format],PubDate as [Pub Date],TATDate as [TAT Date], DateOfAllocation as [Recieved Date] from TATDelivery where PriorityName=''", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public int GetFileCount(String mShipmentID)
        {
            
            //Data adapter with select command
            SqlCommand selectComm = new SqlCommand();
            selectComm.Connection = this.mConnectionUser;
            selectComm.CommandType = CommandType.Text;

            selectComm.Parameters.Add("@mTAT_ShpID", SqlDbType.NVarChar);
            selectComm.Parameters["@mTAT_ShpID"].Value = mShipmentID;

            selectComm.CommandText = "SELECT COUNT(ShipmentID) FROM ShipmentDetail WHERE ShipmentID=@mTAT_ShpID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = selectComm;

            DataTable table = new DataTable();
            da.Fill(table);

            int mTATShip = 0;

            foreach (DataRow row in table.Rows)
            {
                mTATShip  = int.Parse(row[0].ToString());
            }
            return mTATShip;

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

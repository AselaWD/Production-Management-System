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
    class ShipmentDetailMng
    {
        //ShpID	                bigint 	Unchecked
        //DownloadedDate	    datetime	    Unchecked
        //ShipmentID            varchar(500)	Unchecked
        //Publisher	            varchar(100)	Checked
        //ISBN	                varchar(20)	    Checked
        //DISBN	                varchar(20) 	Checked
        //Title	                varchar(1000)	Checked
        //Author	            varchar(500)	Checked
        //Author1	            varchar(500)	Checked
        //PageCount	            int	            Checked
        //Complexcity	        varchar(50)	    Checked
        //PCPCode	            varchar(50)	    Checked
        //DateOfAllocation	    datetime	    Checked
        //PubDate	            datetime2(7)	Checked
        //Priority	            varchar(50)	    Checked
        //Language	            varchar(50)	    Checked
        //Team	                varbinary(100)	Checked
        //UserID	            varchar(50)	    Checked
        //AuditLoadedDate	    datetime	    Checked
        //AuditCount	        int	            Checked
        //AuditName	            varchar(2000)	Checked
        //AuditStatus	        varchar(50)	    Checked
        //XmittedDate	        datetime	    Checked
        //DueDate	            datetime	    Checked
        //DollerUploadedDate	datetime	    Checked
        //DollerFileName	    varchar(100)	Checked
        //FinalPrice	        float	        Checked
        //Comment	            varchar(5000)	Checked
        //Format	            varchar(50)	    Checked
        //InternalReference	    varchar(5000)   Checked
        //SingleUnits	        float	        Checked
        //QueryDate	            datetime	    Checked
        //TATDelivery	        int	            Checked
        //ProductionDone	    int	            Checked
        //QRDone	            int	            Checked
        //TransmissionDone	    int	            Checked
        //ClientFeedback	    int	            Checked

         //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public ShipmentDetailMng()
        {

        }
        // Constructor Overload
        public ShipmentDetailMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddSipmentFile(ShipmetDetail mFile)
        {
            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_DownloadedDate", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_ISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_DISBN", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_Title", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_Author", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_Author1", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_PageCount", SqlDbType.Int);
            insetComm.Parameters.Add("@Sh_Language", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_PubDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@Sh_Publisher", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_Format", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_Comment", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_AllocatedDate", SqlDbType.DateTime);
            insetComm.Parameters.Add("@Sh_TeamName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@Sh_TATDate", SqlDbType.Int);
            insetComm.Parameters.Add("@Sh_ProductionStatus", SqlDbType.Int);
            insetComm.Parameters.Add("@Sh_QRDoneStatus", SqlDbType.Int);
            insetComm.Parameters.Add("@Sh_TransmissionStatus", SqlDbType.Int);
            insetComm.Parameters.Add("@Sh_ClientFeedback", SqlDbType.Int);

            insetComm.Parameters["@Sh_ShipmentID"].Value = mFile.ID;
            insetComm.Parameters["@Sh_DownloadedDate"].Value = mFile.DownloadedDate;
            insetComm.Parameters["@Sh_ISBN"].Value = mFile.ISBN;
            insetComm.Parameters["@Sh_DISBN"].Value = mFile.DISBN;
            insetComm.Parameters["@Sh_Title"].Value = mFile.Title;
            insetComm.Parameters["@Sh_Author"].Value = mFile.Author;
            insetComm.Parameters["@Sh_Author1"].Value = mFile.Author1;
            insetComm.Parameters["@Sh_PageCount"].Value = mFile.PageCount;
            insetComm.Parameters["@Sh_Language"].Value = mFile.Language;
            insetComm.Parameters["@Sh_PubDate"].Value = mFile.PubDate;
            insetComm.Parameters["@Sh_Publisher"].Value = mFile.Publisher;
            insetComm.Parameters["@Sh_Format"].Value = mFile.Format;
            insetComm.Parameters["@Sh_Comment"].Value = mFile.Comment;
            insetComm.Parameters["@Sh_AllocatedDate"].Value = mFile.DateOfAllocation;
            insetComm.Parameters["@Sh_TeamName"].Value = mFile.Team;
            insetComm.Parameters["@Sh_TATDate"].Value = mFile.TATDelivery;
            insetComm.Parameters["@Sh_ProductionStatus"].Value = mFile.ProductionDone;
            insetComm.Parameters["@Sh_QRDoneStatus"].Value = mFile.QRDone;
            insetComm.Parameters["@Sh_TransmissionStatus"].Value = mFile.TransmissionDone;
            insetComm.Parameters["@Sh_ClientFeedback"].Value = mFile.ClientFeedback;


            insetComm.CommandText = "insert into ShipmentDetail(ShipmentID,DownloadedDate,ISBN,DISBN,Title,Author,Author1,PageCount,Language,PubDate,Publisher,Format,Comment,Team,DateOfAllocation,TATDelivery,ProductionDone,QRDone,TransmissionDone,ClientFeedback)values(@Sh_ShipmentID,@Sh_DownloadedDate,@Sh_ISBN,@Sh_DISBN,@Sh_Title,@Sh_Author,@Sh_Author1,@Sh_PageCount,@Sh_Language,@Sh_PubDate,@Sh_Publisher,@Sh_Format,@Sh_Comment, @Sh_TeamName,@Sh_AllocatedDate,@Sh_TATDate,@Sh_ProductionStatus,@Sh_QRDoneStatus,@Sh_TransmissionStatus,@Sh_ClientFeedback)";
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

        public int UpdateShipment(ShipmetDetail mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_DISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_BookTitle", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Author", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Author1", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_PageCount", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_PCPCode", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Complexcity", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_PubDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@Sh_Publisher", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Language", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_TeamName", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Comment", SqlDbType.NVarChar);

            

            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_ISBN"].Value = mFile.ISBN;
            updateComm.Parameters["@Sh_DISBN"].Value = mFile.DISBN;
            updateComm.Parameters["@Sh_BookTitle"].Value = mFile.Title;
            updateComm.Parameters["@Sh_Author"].Value = mFile.Author;
            updateComm.Parameters["@Sh_Author1"].Value = mFile.Author1;
            updateComm.Parameters["@Sh_PageCount"].Value = mFile.PageCount;
            updateComm.Parameters["@Sh_PCPCode"].Value = mFile.PCPCode;
            updateComm.Parameters["@Sh_Complexcity"].Value = mFile.Complexcity;
            updateComm.Parameters["@Sh_PubDate"].Value = mFile.PubDate;
            updateComm.Parameters["@Sh_Publisher"].Value = mFile.Publisher;
            updateComm.Parameters["@Sh_Language"].Value = mFile.Language;
            updateComm.Parameters["@Sh_TeamName"].Value = mFile.Team;
            updateComm.Parameters["@Sh_Comment"].Value = mFile.Comment;

            updateComm.CommandText = "UPDATE ShipmentDetail SET ISBN=@Sh_ISBN, DISBN=@Sh_DISBN, Title=@Sh_BookTitle, Author=@Sh_Author, Author1=@Sh_Author1, PageCount=@Sh_PageCount, PCPCode=@Sh_PCPCode, Complexcity=@Sh_Complexcity, PubDate=@Sh_PubDate, Publisher=@Sh_Publisher, Language=@Sh_Language, Team=@Sh_TeamName,  Comment=@Sh_Comment WHERE ShipmentID=@Sh_ShipmentID AND ShpID=@Sh_ShpID";

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

        public int UpdateAuditInShipment(ShipmetDetail mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_AuditName", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_AuditLoadedDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@Sh_AuditCount", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_AuditStatus", SqlDbType.NVarChar);

            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_AuditName"].Value = mFile.AuditName;
            updateComm.Parameters["@Sh_AuditLoadedDate"].Value = mFile.AuditLoadedDate;
            updateComm.Parameters["@Sh_AuditCount"].Value = mFile.AuditCount;
            updateComm.Parameters["@Sh_AuditStatus"].Value = mFile.AuditStatus;


            updateComm.CommandText = "UPDATE ShipmentDetail SET AuditName=@Sh_AuditName, AuditLoadedDate=@Sh_AuditLoadedDate, AuditCount=@Sh_AuditCount, AuditStatus=@Sh_AuditStatus WHERE ShipmentID=@Sh_ShipmentID AND ShpID=@Sh_ShpID";

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

        public int UpdateTransmissioInShipment(ShipmetDetail mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_DollarFileName", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_DollarFileUploadedDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@Sh_FinalPrice", SqlDbType.Float);
            updateComm.Parameters.Add("@Sh_XmittedDate", SqlDbType.DateTime);
            updateComm.Parameters.Add("@Sh_TransmissionStatus", SqlDbType.Int);

            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_DollarFileName"].Value = mFile.DollerFileName;
            updateComm.Parameters["@Sh_DollarFileUploadedDate"].Value = mFile.DollerUploadedDate;
            updateComm.Parameters["@Sh_FinalPrice"].Value = mFile.FinalPrice;
            updateComm.Parameters["@Sh_XmittedDate"].Value = mFile.XmittedDate;
            updateComm.Parameters["@Sh_TransmissionStatus"].Value = mFile.TransmissionDone;


            updateComm.CommandText = "UPDATE ShipmentDetail SET DollerFileName=@Sh_DollarFileName, DollerUploadedDate=@Sh_DollarFileUploadedDate, FinalPrice=@Sh_FinalPrice, XmittedDate=@Sh_XmittedDate, TransmissionDone=@Sh_TransmissionStatus WHERE ShipmentID=@Sh_ShipmentID AND ShpID=@Sh_ShpID";

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

        public int UpdateTATOnSipmentFile(ShipmetDetail mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Priority", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_TATDate", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_Team", SqlDbType.NVarChar);

            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_ISBN"].Value = mFile.ISBN;
            updateComm.Parameters["@Sh_Priority"].Value = mFile.Priority;
            updateComm.Parameters["@Sh_TATDate"].Value = mFile.TATDelivery;
            updateComm.Parameters["@Sh_Team"].Value = mFile.Team;

            updateComm.CommandText = "UPDATE ShipmentDetail SET TATDelivery=1, Priority=@Sh_Priority, Team=@Sh_Team WHERE ShipmentID=@Sh_ShipmentID AND ISBN=@Sh_ISBN AND TATDelivery=0";
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

        public int UpdateFreshOnTATSipmentFile(ShipmetDetail mFile)
        {
            //insert databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ISBN", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_Priority", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_TATDate", SqlDbType.Int);

            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_ISBN"].Value = mFile.ISBN;
            updateComm.Parameters["@Sh_Priority"].Value = mFile.Priority;
            updateComm.Parameters["@Sh_TATDate"].Value = mFile.TATDelivery;

            updateComm.CommandText = "update ShipmentDetail set TATDelivery=0, Priority=@Sh_Priority where ShipmentID=@Sh_ShipmentID AND ISBN=@Sh_ISBN AND TATDelivery=1";
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

        public int UpdateProductionDoneStatusInShipment(ShipmetDetail mFile)
        {
            //update databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ProductionDoneStatus", SqlDbType.Int);




            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_ProductionDoneStatus"].Value = mFile.ProductionDone;


            updateComm.CommandText = "UPDATE ShipmentDetail SET ProductionDone=@Sh_ProductionDoneStatus WHERE ShipmentID=@Sh_ShipmentID AND ShpID=@Sh_ShpID";

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

        public int UpdateQRDoneStatusInShipment(ShipmetDetail mFile)
        {
            //update databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_QRDoneStatus", SqlDbType.Int);




            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_QRDoneStatus"].Value = mFile.QRDone;


            updateComm.CommandText = "UPDATE ShipmentDetail SET QRDone=@Sh_QRDoneStatus WHERE ShipmentID=@Sh_ShipmentID AND ShpID=@Sh_ShpID";

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

        public int UpdateFeedbackStatusInShipment(ShipmetDetail mFile)
        {
            //update databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@Sh_ShpID", SqlDbType.Int);
            updateComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@Sh_ClientFeedback", SqlDbType.Int);


            updateComm.Parameters["@Sh_ShpID"].Value = mFile.ShpID;
            updateComm.Parameters["@Sh_ShipmentID"].Value = mFile.ShipmentID;
            updateComm.Parameters["@Sh_ClientFeedback"].Value = mFile.ClientFeedback;


            updateComm.CommandText = "UPDATE ShipmentDetail SET ClientFeedback=@Sh_ClientFeedback WHERE ShipmentID=@Sh_ShipmentID AND ShpID=@Sh_ShpID";

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

        public DataTable GetAllShipments()
        {

            //Data adapter with select command

            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = new SqlCommand("select ShpID as [ID], ShipmentID as [Shipment Name], DownloadedDate as [Downloaded Date], ISBN as [Printed ISBN], DISBN as [Digital ISBN], Publisher as [Publisher], Title as [Book Title], Author as [Primary Author], Author1 as [Secondary Author], PageCount as [Page Count], Complexcity as [Complexcity], PCPCode as [PCP Code], DateOfAllocation as [Date Of Allocation], Language as [Language], PubDate as [Pub Date], Priority as [Priority], Team as [Team], AuditLoadedDate as [Audit Loaded Date], AuditCount as [Audit Count], AuditName as [Audit Name],AuditStatus as [Audit Status], XmittedDate as [Xmitted Date], DueDate as [Due Date], DollerUploadedDate as [$ Uploaded Date], DollerFileName as [$ File Name], FinalPrice as [Final Price], Comment as [Comment], Format as [Format], InternalReference as [Internal Reference], SingleUnits as [Single Units], QueryDate as [Query Date] from ShipmentDetail", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetAllShipmentsByFreshTAT(String mShipmentID, String mTamName)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_TeamName", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_TeamName"].Value = mTamName;

            SelectCommand.CommandText = "SELECT ShpID as[ID], ShipmentID as [Shipment],ISBN as [ISBN],Title as [Book Title],Publisher as [Publisher],Format as [Format],PubDate as [Pub Date], DateOfAllocation as [Recieved Date] FROM ShipmentDetail where TATDelivery=0 AND ShipmentID=@mSh_ShpID AND Team=@mSh_TeamName";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetAllShipmentsByAssignedTAT(String mShipmentID)//INNER JOIN to filter TAT assigned & Production Status Not Assigned files
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT f.ShpID as [ID], f.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date] FROM ShipmentDetail s INNER JOIN ShipmentDetailFormats f ON s.TATDelivery=1 AND f.ProductionStatus='Not Assigned' AND f.ShpID=s.ShpID AND f.ShipmentID=@mSh_ShpID;";

            //SelectCommand.CommandText = "SELECT s.ShpID as [ID], s.ShipmentID as [Shipment], ISBN as [ISBN], DISBN as [Digital ISBN], Title as [Book Title], Author as [Primary Author], Author1 as [Secondary Author], FormatName as [Format], Publisher as [Publisher], PubDate as [Pub Date] FROM ShipmentDetail s,  ShipmentDetailFormats f WHERE s.ShipmentID=@mSh_ShpID AND s.TATDelivery=1 AND f.ProductionStatus='Not Assigned'";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN included

        public DataTable GetAllShipmentsByTransmitted(String mShipmentID)//INNER JOIN to filter Transmitted Files & Format Details
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT s.ShpID as [ID], s.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date], DownloadedDate as [Recived Date], AuditName as [Audit Name], AuditLoadedDate as [Audit Loaded Date], XmittedDate as [Xmitted Date], DollerUploadedDate as [Doller Uploaded Date], DollerFileName as [Doller File Name] FROM  ShipmentDetail s INNER JOIN ShipmentDetailFormats f ON s.TransmissionDone=1 AND s.ClientFeedback=0 AND f.ProductionStatus='QR Done' AND f.ShipmentID=@mSh_ShpID";


            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN included

        public DataTable GetAllISBNByTransmitted(String mShipmentID, String mISBN)//INNER JOIN to filter Transmitted Files & Format Details
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@mSh_ShpID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@mSh_ISBN", SqlDbType.VarChar);

            SelectCommand.Parameters["@mSh_ShpID"].Value = mShipmentID;
            SelectCommand.Parameters["@mSh_ISBN"].Value = mISBN;

            SelectCommand.CommandText = "SELECT s.ShpID as [ID], s.ShipmentID as [Shipment],s.ISBN as [ISBN],s.DISBN as [Digital ISBN], s.Title as [Book Title], s.Author as [Primary Author], s.Author1 as [Secondary Author],f.FormatName as [Format],PageCount as [Page Count], s.Publisher as [Publisher], s.PubDate as [Pub Date], DownloadedDate as [Recived Date], AuditName as [Audit Name], AuditLoadedDate as [Audit Loaded Date], XmittedDate as [Xmitted Date], DollerUploadedDate as [Doller Uploaded Date], DollerFileName as [Doller File Name] FROM  ShipmentDetail s INNER JOIN ShipmentDetailFormats f ON s.TransmissionDone=1 AND s.ClientFeedback=0 AND f.ProductionStatus='QR Done' AND f.ShipmentID=@mSh_ShpID AND ISBN=@mSh_ISBN";


            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        } //INNER JOIN included

        public List<String> GetAllShipmentByName()
        {
            List<String> mShipmentID = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select ShipmentID from ShipmentDetail", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mShipmentID.Add(row[0].ToString());
            }
            return mShipmentID;
        }

        public List<String> GetAllShipmentByPrintISBN()
        {
            List<String> mPrintISBN = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select ISBN from ShipmentDetail", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                mPrintISBN.Add(row[0].ToString());
            }
            return mPrintISBN;
        }

        public String GetAllShpIDByISBN(ShipmetDetail mISBN)
        {

            //insert databse values
            SqlCommand selectComm = new SqlCommand();
            selectComm.Connection = this.mConnectionUser;
            selectComm.CommandType = CommandType.Text;

            selectComm.Parameters.Add("@Sh_ISBN", SqlDbType.NVarChar);

            selectComm.Parameters["@Sh_ISBN"].Value = mISBN.ISBN;
            string a = mISBN.ISBN;
            return a.ToString();

        }

        public int GetLastID()
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;


            SelectCommand.CommandText = "select MAX(ShpID) from ShipmentDetail ";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            int maxNumber = 0;

            foreach (DataRow row in table.Rows)
            {
                maxNumber= Int16.Parse( row[0].ToString());
                
            }
            return maxNumber;
        }

        public int DeleteShipment(String mID)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@Sh_ShipmentID", SqlDbType.VarChar);

            deleteComm.Parameters["@Sh_ShipmentID"].Value = mID;


            deleteComm.CommandText = "delete from ShipmentDetail where ShipmentID=@Sh_ShipmentID";
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

        public int DeleteShipmentFromID(ShipmetDetail mISBN, ShipmetDetail mID)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@Sh_ISBN", SqlDbType.VarChar);
            deleteComm.Parameters.Add("@Sh_ID", SqlDbType.VarChar);

            deleteComm.Parameters["@Sh_ISBN"].Value = mISBN.ISBN;
            deleteComm.Parameters["@Sh_ID"].Value = mID.ID;


            deleteComm.CommandText = "delete from ShipmentDetail where ISBN=@Sh_ISBN AND ShipmentID=@Sh_ID";
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

        public bool ProductionDoneIsExist(int mShpID, String mShipmentID)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;


            SelectCommand.Parameters.Add("@mPR_ShpID", SqlDbType.BigInt);
            SelectCommand.Parameters.Add("@mPR_ShipmentID", SqlDbType.NVarChar);

            SelectCommand.Parameters["@mPR_ShpID"].Value = mShpID;
            SelectCommand.Parameters["@mPR_ShipmentID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT ShpID, ShipmentID FROM ShipmentDetail WHERE ProductionDone=1 AND ShpID=@mPR_ShpID AND ShipmentID=@mPR_ShipmentID";

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

        public bool QRDoneIsExist(int mShpID, String mShipmentID)
        {
            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;


            SelectCommand.Parameters.Add("@mQR_ShpID", SqlDbType.BigInt);
            SelectCommand.Parameters.Add("@mQR_ShipmentID", SqlDbType.NVarChar);

            SelectCommand.Parameters["@mQR_ShpID"].Value = mShpID;
            SelectCommand.Parameters["@mQR_ShipmentID"].Value = mShipmentID;

            SelectCommand.CommandText = "SELECT ShpID, ShipmentID FROM ShipmentDetail WHERE QRDone=1 AND ShpID=@mQR_ShpID AND ShipmentID=@mQR_ShipmentID";

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

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
    //UserID	varchar(50)	        Unchecked
    //UserName	varchar(500)	    Checked
    //UserFullName	varchar(255)	Checked
    //Password	varchar(255)	    Checked
    //UserLevel	varchar(50)	        Checked
    //UserTeam	varchar(100)	    Checked
    //UserDepartment	varchar(50)	Checked

    class UserManager
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public UserManager(){

    }
        // Constructor Overload
        public UserManager(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        public int AddUser(User mUser)
        {

            //insert databse values
            SqlCommand insetComm = new SqlCommand();
            insetComm.Connection = this.mConnectionUser;
            insetComm.CommandType = CommandType.Text;

            insetComm.Parameters.Add("@User_ID", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@User_Name", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@User_FullName", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@User_Password", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@User_Level", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@User_Team", SqlDbType.NVarChar);
            insetComm.Parameters.Add("@User_Department", SqlDbType.NVarChar);
            

            insetComm.Parameters["@User_ID"].Value = mUser.UserID;
            insetComm.Parameters["@User_Name"].Value = mUser.UserName;
            insetComm.Parameters["@User_FullName"].Value = mUser.UserFullName;
            insetComm.Parameters["@User_Password"].Value = mUser.Password;
            insetComm.Parameters["@User_Level"].Value = mUser.UserLevel;
            insetComm.Parameters["@User_Team"].Value = mUser.UserTeam;
            insetComm.Parameters["@User_Department"].Value = mUser.UserDepartment;

            insetComm.CommandText = "insert into UserManagement(UserID,UserName,UserFullName,Password,UserLevel,UserTeam,UserDepartment)values(@User_ID,@User_Name,@User_FullName,@User_Password,@User_Level,@User_Team,@User_Department)";
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

        public int UpdateUser(User mUser)
        {

            //update databse values
            SqlCommand updateComm = new SqlCommand();
            updateComm.Connection = this.mConnectionUser;
            updateComm.CommandType = CommandType.Text;

            updateComm.Parameters.Add("@User_ID", SqlDbType.VarChar);
            updateComm.Parameters.Add("@User_Name", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@User_FullName", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@User_Password", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@User_Level", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@User_Team", SqlDbType.NVarChar);
            updateComm.Parameters.Add("@User_Department", SqlDbType.NVarChar);


            updateComm.Parameters["@User_ID"].Value = mUser.UserID;
            updateComm.Parameters["@User_Name"].Value = mUser.UserName;
            updateComm.Parameters["@User_FullName"].Value = mUser.UserFullName;
            updateComm.Parameters["@User_Password"].Value = mUser.Password;
            updateComm.Parameters["@User_Level"].Value = mUser.UserLevel;
            updateComm.Parameters["@User_Team"].Value = mUser.UserTeam;
            updateComm.Parameters["@User_Department"].Value = mUser.UserDepartment;

            updateComm.CommandText = "update UserManagement set UserName=@User_Name,UserFullName=@User_FullName,Password=@User_Password,UserLevel=@User_Level,UserTeam=@User_Team,UserDepartment=@User_Department where  UserID=@User_ID";
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

        public int DeleteUser(User mUserID)
        {

            //insert databse values
            SqlCommand deleteComm = new SqlCommand();
            deleteComm.Connection = this.mConnectionUser;
            deleteComm.CommandType = CommandType.Text;

            deleteComm.Parameters.Add("@User_ID", SqlDbType.VarChar);
            
            deleteComm.Parameters["@User_ID"].Value = mUserID.UserID;


            deleteComm.CommandText = "delete from UserManagement where UserID=@User_ID";
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

        public DataTable GetAllUsers()
        {

            //Data adapter with select command

            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = new SqlCommand("select UserID as [User ID],UserName as [Calling Name],UserFullName as [User Full Name],UserLevel as [User Level],UserTeam as [Team],UserDepartment as [Department] from UserManagement", this.mConnectionUser);

            //Cast Table Data
            //da.SelectCommand = new SqlCommand("select UserID as [User ID],UserName as [Calling Name],UserFullName as [User Full Name],Password as [Password],UserLevel as [User Level],UserTeam as [Team],UserDepartment as [Department] from UserManagement", this.mConnectionUser);
           
            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable rptViwerGetAllUsers()
        {

            //Data adapter with select command

            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = new SqlCommand("select * from UserManagement", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);
            return table;

        }

        public DataTable GetUserDetails(User mUser)
        {

            //Select databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@User_ID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@User_Pass", SqlDbType.VarChar);

            SelectCommand.Parameters["@User_ID"].Value = mUser.UserID;
            SelectCommand.Parameters["@User_Pass"].Value = mUser.Password;

            SelectCommand.CommandText = "SELECT UserID, UserName,UserFullName,UserLevel,UserTeam,UserDepartment FROM UserManagement where UserID=@User_ID AND Password=@User_Pass";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            return table;

        }

        public List<String> GetAllUserIDs()
        {
            List<String> uID = new List<string>();

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("select UserID from UserManagement", this.mConnectionUser);

            DataTable table = new DataTable();
            da.Fill(table);

            foreach(DataRow row in table.Rows)
            {
                uID.Add(row[0].ToString());
            }
            return uID;
        }

        public User GetUserByID(String mUserID)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@User_ID", SqlDbType.VarChar);
            SelectCommand.Parameters["@User_ID"].Value = mUserID;

            SelectCommand.CommandText = "select UserID,UserName,UserFullName,UserLevel,UserTeam,UserDepartment from UserManagement where UserID = @User_ID";

            //SelectCommand.CommandText = "select UserID,UserName,UserFullName,Password,UserLevel,UserTeam,UserDepartment from UserManagement where UserID = @User_ID";

            //Data adapter with select command
            SqlDataAdapter da = new SqlDataAdapter();

            //Cast Table Data
            da.SelectCommand = SelectCommand;

            DataTable table = new DataTable();
            da.Fill(table);

            User newUser = new User();

            foreach (DataRow row in table.Rows)
            {
                newUser.UserID=(row[0].ToString());
                newUser.UserName = (row[1].ToString());
                newUser.UserFullName = (row[2].ToString());
                newUser.Password = (row[3].ToString());
                newUser.UserLevel = (row[4].ToString());
                newUser.UserTeam = (row[5].ToString());
                newUser.UserDepartment = (row[6].ToString());
            }
            return newUser;
        }

        public bool UserIsExist(String mUserID)

        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@User_ID", SqlDbType.VarChar);

            SelectCommand.Parameters["@User_ID"].Value = mUserID;

            SelectCommand.CommandText = "select UserID,UserName,UserFullName,Password,UserLevel,UserTeam,UserDepartment from UserManagement where UserID = @User_ID";

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

        public bool UserLogin(User mUser)
        {
            //insert databse values
            SqlCommand SelectCommand = new SqlCommand();
            SelectCommand.Connection = this.mConnectionUser;
            SelectCommand.CommandType = CommandType.Text;

            SelectCommand.Parameters.Add("@User_ID", SqlDbType.VarChar);
            SelectCommand.Parameters.Add("@User_Pass", SqlDbType.VarChar);

            SelectCommand.Parameters["@User_ID"].Value = mUser.UserID;
            SelectCommand.Parameters["@User_Pass"].Value = mUser.Password;

            SelectCommand.CommandText = "SELECT UserID,Password FROM UserManagement where UserID=@User_ID AND Password=@User_Pass";

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

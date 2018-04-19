using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class User
    {
        //UserID	varchar(50)	        Unchecked
        //UserName	varchar(500)	    Checked
        //UserFullName	varchar(255)	Checked
        //Password	varchar(255)	    Checked
        //UserLevel	varchar(50)	        Checked
        //UserTeam	varchar(100)	    Checked
        //UserDepartment	varchar(50)	Checked

        private string mUserID;
        private string mUserName;
        private string mUserFullName;
        private string mPassword;
        private string mUserLevel;
        private string mUserTeam;
        private string mUserDepartment;

        //Set properties to User
        public String UserName
        {
            set
            {
                mUserName = value;
            }
            get 
            { 
                return mUserName;
            }
        }

        public String UserID 
        {
            set
            {
                mUserID = value;
            }
            get
            {
                return mUserID;
            }
        
        }

        public String UserFullName {
            set
            {
                mUserFullName = value;
            }
            get
            {

                return mUserFullName;
            }
        }

        public String Password {
            set 
            {
                mPassword = value;
            }
            get 
            {
                return mPassword;
            }

        }

        public String UserLevel {

            set
            {
                mUserLevel = value;
            }
            get {
                return mUserLevel;
            }
        }

        public String UserTeam {
            set
            {
                mUserTeam = value;
            }
            get 
            {
                return mUserTeam;
            }
        }

        public String UserDepartment {
            set 
            {
                mUserDepartment = value;
            }
            get 
            {
                return mUserDepartment;
            }
        }
        }
}

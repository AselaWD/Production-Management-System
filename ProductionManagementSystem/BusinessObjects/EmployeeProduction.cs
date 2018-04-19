using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class EmployeeProduction
    {
        //ProductID	    bigint	        Unchecked
        //ShipmentID	varchar(500)	Unchecked
        //ISBN	        varchar(20)	    Unchecked
        //UserID	    varchar(50)	    Checked
        //PageCount	    int	            Checked
        //FormatName	varchar(100)	Unchecked
        //Status	    varchar(100)	Unchecked
        //DoneDate	    datetime	    Checked

        private int mProductID;
        private string mShipmentID;
        private string mISBN;
        private string mUserID;
        private string mPageCount;
        private string mFormatName;
        private string mStatus;
        private DateTime mDoneDate;

        //Set Properties to EmployeeProduction
        public int ProductID 
        {
            set
            {
                mProductID = value;
            }
            get
            {
                return mProductID;
            }
        }
        public String ShipmentID
        {
            set
            {
                mShipmentID = value;
            }
            get
            {
                return mShipmentID;
            }
        }
        public String ISBN
        {
            set
            {
                mISBN = value;
            }
            get
            {
                return mISBN;
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
        public String PageCount
        {
            set
            {
                mPageCount = value;
            }
            get
            {
                return mPageCount;
            }
        }
        public String FormatName
        {
            set
            {
                mFormatName = value;
            }
            get
            {
                return mFormatName;
            }
        }
        public String Status
        {
            set
            {
                mStatus = value;
            }
            get
            {
                return mStatus;
            }
        }
        public DateTime DoneDate
        {
            set
            {
                mDoneDate = value;
            }
            get
            {
                return mDoneDate;
            }
        }
    }
}

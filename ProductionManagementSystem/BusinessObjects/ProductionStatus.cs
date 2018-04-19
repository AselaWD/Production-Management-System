using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class ProductionStatus
    {
        //ProductID	    bigint	        Unchecked
        //ShipmentID	varchar(500)	Unchecked
        //ISBN	        varchar(20)	    Checked
        //StartDate	    datetime	    Checked
        //FormatName	varchar(100)	Unchecked
        //UserID	    varchar(50) 	Checked
        //Status	    varchar(100)	Checked

        private int mProductID;
        private string mShipmentID;
        private string mISBN;
        private DateTime mStartDate;
        private string mFormatName;
        private string mUserID;
        private string mStatus;

        //Set properties to Production Status

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

        public DateTime StartDate
        {
            set
            {
                mStartDate = value;
            }
            get
            {
                return mStartDate;
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
    }
}

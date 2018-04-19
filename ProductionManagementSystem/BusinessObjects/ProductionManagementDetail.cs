using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class ProductionManagementDetail
    {
        //ShpID	            bigint	        Unchecked
        //ShipmentID	    varchar(500)	Checked
        //FormatName	    varchar(100)	Checked
        //ISBN	            varchar(20) 	Checked
        //UserID	        varchar(50)	    Checked
        //PageCount	        int         	Checked
        //StartDate	        datetime2(7)	Checked
        //ProductionStatus	varchar(100)	Checked

        private int mShpID;
        private string mShipmentID;
        private string mFormat;
        private string mISBN;
        private string mUserID;
        private int mPageCount;
        private DateTime mStartDate;
        private string mProductionStatus;

        //Set properties to ProductionManagementDetail

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
        public int ShpID
        {
            set
            {
                mShpID = value;
            }
            get
            {
                return mShpID;
            }
        }
        public String Format
        {
            set
            {
                mFormat = value;
            }
            get
            {
                return mFormat;
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
        public int PageCount
        {
            set
            {
                mPageCount=value;
            }
            get
            {
                return mPageCount;
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
        public String ProductionStatus
        {
            set
            {
                mProductionStatus = value;
            }
            get
            {
                return mProductionStatus;
            }
        }
    }
}

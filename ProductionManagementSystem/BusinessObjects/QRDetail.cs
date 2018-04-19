using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class QRDetail
    {
        //ProductID	    bigint	        Unchecked
        //ShipmentID	varchar(500)	Unchecked
        //ISBN	        varchar(20)	    Unchecked
        //FormatName	varchar(100)	Unchecked
        //UserID	    varchar(50)	    Unchecked
        //PageCount	    int	            Checked
        //QRDate	    datetime	    Checked
        //Status	    varchar(100)	Checked

        private int mProductID;
        private string mShipmentID;
        private string mISBN;
        private string mFormatName;
        private string mUserID;
        private int mPageCount;
        private DateTime mQRDate;
        private string mStatus;

        //Set properties to QR Detail

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
        public int PageCount
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
        public DateTime QRDate
        {
            set
            {
                mQRDate = value;
            }
            get
            {
                return mQRDate;
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

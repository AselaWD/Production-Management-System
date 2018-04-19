using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class Feedback
    {
        //FeedbackID	varchar(500)	Unchecked
        //ShpID	        bigint	        Unchecked
        //ShipmentID	varchar(500)	Unchecked
        //ISBN	        varchar(20)	    Checked
        //FormatName	varchar(100)	Unchecked
        //FeedbackDate	datetime	    Checked
        //Remark	    varchar(5000)	Checked


        //Set properties to FeedbackTracking

        private int mFeedbackID;
        private int mShpID;
        private string mShipmentID;
        private string mISBN;
        private string mFormatName;
        private DateTime mFeedbackDate;
        private string mRemark;

        public int FeedbackID
        {
            set
            {
                mFeedbackID = value;
            }
            get
            {
                return mFeedbackID;
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
        public string ShipmentID
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
        public DateTime FeedbackDate
        {
            set
            {
                mFeedbackDate = value;
            }
            get
            {
                return mFeedbackDate;
            }
        }
        public String Remark
        {
            set
            {
                mRemark = value;
            }
            get
            {
                return mRemark;
            }
        }
    }
}

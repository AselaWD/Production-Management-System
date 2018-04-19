using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class TATDelivery
    {

        //ShpID	            bigint	        Unchecked
        //ShipmentID	    varchar(500)	Unchecked
        //ISBN	            varchar(20)	    Checked
        //PriorityName      varchar(50)	    Checked
        //FormatName	    varchar(100)	Checked
        //PubDate	        datetime2(7)	Checked
        //TATDate	        datetime2(7)	Checked
        //DateOfAllocation	datetime	    Checked
        //Team                   varchar(100)	Checked

        private int mShpID;
        private string mShipmentID;
        private string mISBN;
        private string mPriority;
        private string mFormat;
        private DateTime mPubDate;
        private DateTime mTATDate;
        private DateTime mDateOfAllocation;
        private string mTeamName;

        //Set properties to Production TAT Delivery

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
        public String PriorityName
        {
            set
            {
                mPriority = value;
            }
            get
            {
                return mPriority;
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
        public DateTime PubDate
        {
            set
            {
                mPubDate = value;
            }
            get
            {
                return mPubDate;
            }
        }
        public DateTime TATDate
        {
            set
            {
                mTATDate = value;
            }
            get
            {
                return mTATDate;
            }
        }
        public DateTime DateOfAllocation 
        {
            set
            {
                mDateOfAllocation = value;
            }
            get
            {
                return mDateOfAllocation;
            }
        }
        public String TeamName 
        {
            set
            {
                mTeamName = value;
            }
            get
            {
                return mTeamName;
            }
        }
    }
}

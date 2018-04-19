using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class ShipmentHeader
    {
        //ID	            varchar(50)	    Unchecked
        //ShipmentID	    varchar(500)	Unchecked
        //FileCount	        int	            Unchecked
        //DownloadedDate	datetime	    Unchecked

        private string mID;
        private string mShipmentID;
        private int mFileCount;
        private DateTime mDownloadedDate;

        //Set properties to Shipment Header

        public String ID
        {
            set
            {
                mID = value;
            }
            get
            {
                return mID;
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
        public int FileCount
        {
            set
            {
                mFileCount = value;
            }
            get
            {
                return mFileCount;
            }
        }
        public DateTime DownloadedDate
        {
            set
            {
                mDownloadedDate = value;
            }
            get
            {
                return mDownloadedDate;
            }
        }
    }
}

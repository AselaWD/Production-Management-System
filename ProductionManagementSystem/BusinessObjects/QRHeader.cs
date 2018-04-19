using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class QRHeader
    {
        //ProductID	    bigint	        Unchecked
        //ShipmentID	varchar(500)	Unchecked
        //ISBN	        varchar(20)	    Unchecked
        //FormatName	varchar(100)	Unchecked

        private int mProductID;
        private string mShipmentID;
        private string mISBN;
        private string mFormatName;

        //Set properties to Production QR Header

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
    }
}

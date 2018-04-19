using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class ProductionManagementHeader
    {
        //ShpID	            bigint	        Unchecked
        //ShipmentID	    varchar(500)	Unchecked
        //FormatName	    varchar(100)	Unchecked

        private int mShpID;
        private string mShipmentID;
        private string mFormatName;

        //Set properties to Production Management Header

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

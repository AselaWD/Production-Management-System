using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{

    class ShipmentDetailFormats
    {
        //ShpID	            bigint	        Unchecked
        //ShipmentID	    varchar(500)	Unchecked
        //FormatName	    varchar(100)	Unchecked
        //ProductionStatus	varchar(100)	Checked

        private int mShpID;
        private string mShipmentID;
        private string mFormatName;
        private string mProductionStatus;

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

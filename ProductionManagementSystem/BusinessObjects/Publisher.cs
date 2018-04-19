using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class Publisher
    {
        //PublisherID	varchar(100)	Unchecked
        //PublisherName	varchar(100)	Checked

        private string mPublisherID;
        private string mPublisherName;

        //Set properties to Publisher

        public String PublisherID
        {
            set
            {
                mPublisherID = value;
            }
            get
            {
                return mPublisherID;
            }
        }

        public String PublisherName
        {
            set
            {
                mPublisherName = value;
            }
            get
            {
                return mPublisherName;
            }
        }

    }
}

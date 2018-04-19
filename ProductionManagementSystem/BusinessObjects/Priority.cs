using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class Priority
    {
    //PriorityID	varchar(50)	Unchecked
    //PriorityName	varchar(50)	Checked

        private string mPriorityID;
        private string mPriorityName;

        //Set properties to Priority

        public String PriorityID
        {
            set{
                mPriorityID = value;
                }
            get
            {
                return mPriorityID;
            }
            
        }
        public String PriorityName
        {
            set
            {
                mPriorityName = value;
            }
            get
            {
                return mPriorityName;
            }
        }
    }
}

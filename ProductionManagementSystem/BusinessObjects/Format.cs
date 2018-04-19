using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class Format
    {
        //FormatID	    varchar(100)	Unchecked
        //FormatName	varchar(100)	Checked

        private string mFormatID;
        private string mFormatName;

        //Set properties to Output Format

        public String FormatID {
            set {
                mFormatID = value;
                }

            get {
                return mFormatID;
                }
        
        }
        public String FormatName {
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

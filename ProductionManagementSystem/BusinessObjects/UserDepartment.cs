using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class UserDepartment
    {
        //DepartmentID	varchar(50)	Unchecked
        //DeparmentName	varchar(50)	Checked

        private string mDepartmentID;
        private string mDeparmentName;

        //Set properties to User Department

        public String DepartmentID
        {
            set
            {
                mDepartmentID = value;
            }
            get
            {
                return mDepartmentID;
            }
        }
        public String DeparmentName
        {
            set
            {
                mDeparmentName = value;
            }
            get
            {
                return mDeparmentName;
            }
        }
    }
}

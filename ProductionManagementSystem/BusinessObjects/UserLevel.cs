using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class UserLevel
    {
        //LevelID	varchar(50)	Unchecked
        //LevelName	varchar(50)	Checked

        private string mLevelID;
        private string mLevelName;

        //Set properties to User Level

        public String LevelID
        {
            set
            {
                mLevelID = value;
            }
            get
            {
                return mLevelID;
            }
        }
        public String LevelName
        {
            set
            {
                mLevelName = value;
            }
            get
            {
                return mLevelName;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class UserTeam
    {
        //TeamID	varchar(50)	    Unchecked
        //TeamName	varchar(100)	Checked

        private string mTeamID;
        private string mTeamName;

        //Set properties to User Team

        public String TeamID
        {
            set
            {
                mTeamID = value;
            }
            get
            {
                return mTeamID;
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

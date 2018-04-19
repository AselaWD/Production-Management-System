using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class InsentiveScheme
    {
        //IncentiveID	    bigint	Unchecked
        //IncentiveMonth	date	Unchecked
        //IncentiveAmount	money	Checked
        //ForBook	        int	    Checked
        //ForPage	        int	    Checked
        //IncentiveRule	    int	    Checked

        private string mIncentiveID;
        private String mIncentiveMonth;
        private float mIncentiveAmount;
        private int mForBook;
        private int mForPage;
        private int mIncentiveRule;

        //Set properties to Insentive Scheme

        public String IncentiveID
        {
            set
            {
                mIncentiveID = value;
            }
            get
            {
                return mIncentiveID;
            }

        }
        public String IncentiveMonth {

            set
            {
                mIncentiveMonth = value;
            }
            get
            {
                return mIncentiveMonth;
            }
        }
        public float IncentiveAmount
        {
            set
            {
                mIncentiveAmount = value;
            }
            get
            {
                return mIncentiveAmount;
            }

        }
        public int ForBook
        {
            set
            {
                mForBook = value;
            }
            get
            {
                return mForBook;
            }
        }
        public int ForPage
        {
            set
            {
                mForPage = value;
            }
            get
            {
                return mForPage;
            }
        }
        public int IncentiveRule
        {
            set
            {
                mIncentiveRule = value;
            }
            get
            {
                return mIncentiveRule;
            }
        }
    }
}

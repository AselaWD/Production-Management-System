using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class ShipmetDetail
    {
        //ShpID	                bigint       	Unchecked
        //ShipmentID	        varchar(500)	Unchecked
        //DownloadedDate	    datetime	    Unchecked
        //ID	                varchar(500)	Unchecked
        //Publisher	            varchar(100)	Checked
        //ISBN	                varchar(20)	    Checked
        //DISBN	                varchar(20) 	Checked
        //Title	                varchar(1000)	Checked
        //Author	            varchar(500)	Checked
        //Author1	            varchar(500)	Checked
        //PageCount	            int	            Checked
        //Complexcity	        varchar(50)	    Checked
        //PCPCode	            varchar(50)	    Checked
        //DateOfAllocation	    datetime	    Checked
        //PubDate	            datetime2(7)	Checked
        //Priority	            varchar(50)	    Checked
        //Language	            varchar(50)	    Checked
        //Team	                varbinary(100)	Checked
        //UserID	            varchar(50)	    Checked
        //AuditLoadedDate	    datetime	    Checked
        //AuditCount	        int	            Checked
        //AuditName	            varchar(2000)	Checked
        //AuditStatus	        varchar(50)	    Checked
        //XmittedDate	        datetime	    Checked
        //DueDate	            datetime	    Checked
        //DollerUploadedDate	datetime	    Checked
        //DollerFileName	    varchar(100)	Checked
        //FinalPrice	        float	        Checked
        //Comment	            varchar(5000)	Checked
        //Format	            varchar(50)	    Checked
        //InternalReference	    varchar(5000)   Checked
        //SingleUnits	        float	        Checked
        //QueryDate	            datetime	    Checked
        //TATDelivery	        int	            Checked
        //ProductionDone	    int	            Checked
        //QRDone	            int	            Checked
        //TransmissionDone	    int	            Checked
        //ClientFeedback	    int	            Checked


        private int mShpID;
        private string mShipmentID;
        private DateTime mDownloadedDate;
        private string mID;
        private string mPublisher;
        private string mISBN;
        private string mDISBN;
        private string mTitle;
        private string mAuthor;
        private string mAuthor1;
        private int mPageCount;
        private string mComplexcity;
        private string mPCPCode;
        private DateTime mDateOfAllocation;
        private DateTime mPubDate;
        private string mPriority;
        private string mLanguage;
        private string mTeam;
        private string mUserID;
        private DateTime mAuditLoadedDate;
        private int mAuditCount;
        private string mAuditName;
        private string mAuditStatus;
        private DateTime mXmittedDate;
        private DateTime mDueDate;
        private DateTime mDollerUploadedDate;
        private string mDollerFileName;
        private float mFinalPrice;
        private string mComment;
        private string mFormat;
        private string mInternalReference;
        private float mSingleUnits;
        private DateTime mQueryDate;
        private int mTATDelivery;
        private int mProductionDone;
        private int mQRDone;
        private int mTransmissionDone;
        private int mClientFeedback;


        //Set properties to Shipmet Detail

        public int ShpID
        {   set
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

        public DateTime DownloadedDate
        {
            set
            {
                mDownloadedDate = value;
            }
            get
            {
                return mDownloadedDate;
            }
        }

        public String ID
        {
            set
            {
                mID = value;
            }
            get
            {
                return mID;
            }
        }

        public String Publisher
        {
            set
            {
                mPublisher = value;
            }
            get
            {
                return mPublisher;
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
        public String DISBN
        {
            set
            {
                mDISBN = value;
            }
            get
            {
                return mDISBN;
            }
        }
        public String Title
        {
            set
            {
                mTitle = value;
            }
            get
            {
                return mTitle;
            }
        }
        public String Author
        {
            set
            {
                mAuthor = value;
            }
            get
            {
                return mAuthor;
            }
        }
        public String Author1
        {
            set
            {
                mAuthor1 = value;
            }
            get
            {
                return mAuthor1;
            }
        }
        public int PageCount
        {
            set
            {
                mPageCount = value;
            }
            get
            {
                return mPageCount;
            }
        }

        public String Complexcity
        {
            set
            {
                mComplexcity = value;
            }
            get
            {
                return mComplexcity;
            }
        }

        public String PCPCode
        {
            set
            {
                mPCPCode = value;
            }
            get
            {
                return mPCPCode;
            }
        }

        public DateTime DateOfAllocation
        {
            set
            {
                mDateOfAllocation = value;
            }
            get
            {
                return mDateOfAllocation;
            }
        }

        public DateTime PubDate
        {
            set
            {
                mPubDate = value;
            }
            get
            {
                return mPubDate;
            }
        }

        public String Priority 
        {
            set
            {
                mPriority = value;
            }
            get
            {
                return mPriority;
            }
        }

        public String Language
        {
            set
            {
                mLanguage = value;
            }
            get
            {
                return mLanguage;
            }
        }

        public String Team
        {
            set
            {
                mTeam = value;
            }
            get
            {
                return mTeam;
            }
        }

        public String UserID
        {
            set
            {
                mUserID = value;
            }
            get
            {
                return mUserID;
            }
        }

        public DateTime AuditLoadedDate
        {
            set
            {
                mAuditLoadedDate = value;
            }
            get
            {
                return mAuditLoadedDate;
            }
        }

        public int AuditCount
        {
            set
            {
                mAuditCount = value;
            }
            get
            {
                return mAuditCount;
            }
        }

        public String AuditName
        {
            set
            {
                mAuditName = value;
            }
            get
            {
                return mAuditName;
            }
        }

        public String AuditStatus
        {
            set
            {
                mAuditStatus = value;
            }
            get
            {
                return mAuditStatus;
            }
        }

        public DateTime XmittedDate
        {
            set
            {
                mXmittedDate = value;
            }
            get
            {
                return mXmittedDate;
            }
        }

        public DateTime DueDate
        {
            set
            {
                mDueDate = value;
            }
            get
            {
                return mDueDate;
            }
        }

        public DateTime DollerUploadedDate
        {
            set
            {
                mDollerUploadedDate = value;
            }
            get
            {
                return mDollerUploadedDate;
            }
        }

        public String DollerFileName
        {
            set
            {
                mDollerFileName = value;
            }
            get
            {
                return mDollerFileName;
            }
        }

        public float FinalPrice
        {
            set
            {
                mFinalPrice = value;
            }
            get
            {
                return mFinalPrice;
            }
        }

        public String Comment
        {
            set
            {
                mComment = value;
            }
            get
            {
                return mComment;
            }
        }

        public String Format
        {
            set
            {
                mFormat = value;
            }
            get
            {
                return mFormat;
            }
        }

        public String InternalReference
        {
            set
            {
                mInternalReference = value;
            }
            get
            {
                return mInternalReference;
            }
        }

        public float SingleUnits
        {
            set
            {
                mSingleUnits = value;
            }
            get
            {
                return mSingleUnits;
            }
        }

        public DateTime QueryDate
        {
            set
            {
                mQueryDate = value;
            }
            get
            {
                return mQueryDate;
            }
        }
        public int TATDelivery
        {
            set
            {
                mTATDelivery = value;
            }
            get
            {
                return mTATDelivery;
            }
        }
        public int ProductionDone
        {
            set
            {
                mProductionDone = value;
            }
            get
            {
                return mProductionDone;
            }
        }
        public int QRDone
        {
            set
            {
                mQRDone = value;
            }
            get
            {
                return mQRDone;
            }
        }
        public int TransmissionDone
        {
            set
            {
                mTransmissionDone = value;
            }
            get
            {
                return mTransmissionDone;
            }
        }
        public int ClientFeedback
        {
            set
            {
                mClientFeedback = value;
            }
            get
            {
                return mClientFeedback;
            }
        }
    }
}

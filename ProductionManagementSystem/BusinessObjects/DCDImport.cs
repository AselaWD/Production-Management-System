using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManagementSystem.BusinessObjects
{
    class DCDImport
    {
        private string mISBN;
        private string mdISBN;
        private string mBookTitle;
        private string mAuthor;
        private string mAuthor2;
        private string mPageCount;
        private string mPubDate;
        private string mPublisher;
        private string mLanguage;
        private string mFormat;
        private string mComment;

        //Set Properies to Import Excel Data Headers
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
        public String dISBN
        {
            set
            {
                mdISBN = value;
            }
            get
            {
                return mdISBN;
            }
        }
        public String BookTitle
        {
            set
            {
                mBookTitle = value;
            }
            get
            {
                return mBookTitle;
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
        public String Author2
        {
            set
            {
                mAuthor2 = value;
            }
            get
            {
                return mAuthor2;
            }
        }
        public String PageCount
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
        public String PubDate
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
    }
}

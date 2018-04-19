using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProductionManagementSystem.BusinessObjects;

namespace ProductionManagementSystem.BusinessService
{
    //ShipmentID	    varchar(500)	Checked
    //ISBN	            varchar(20)	    Checked
    //ProductionID	    varchar(100)	Unchecked
    //Format	        varchar(100)	Checked
    //UserID	        varchar(50) 	Checked
    //StartDate	        datetime2(7)	Checked
    //ProductionStatus	varchar(100)	Checked

    class DCDImportMng
    {
        //Connection 
        SqlConnection mConnectionUser;

        //Default connection
        public DCDImportMng()
        {
        }
        // Constructor Overload
        public DCDImportMng(SqlConnection conn)
        {
            mConnectionUser = conn;
        }

        
    }
}

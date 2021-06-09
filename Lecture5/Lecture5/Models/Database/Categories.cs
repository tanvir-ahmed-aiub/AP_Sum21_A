using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lecture5.Models.Database
{
    public class Categories
    {
        SqlConnection conn;
        public Categories(SqlConnection conn) {
            this.conn = conn;
        }
        void Insert() { 
        }
    }
}
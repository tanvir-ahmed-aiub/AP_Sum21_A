using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Lecture5.Models.Database
{
    public class Database
    {
        public Products Products { get; set; }
        public Categories Categories { get; set; }
        public Database() {
            string connString = @"Server=DESKTOP-1HKAK02;Database=PMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Products = new Products(conn);
            Categories = new Categories(conn);

        }
    }
}
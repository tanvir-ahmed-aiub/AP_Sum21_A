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
        public List<Category> GetAll() {
            string query = "select * from Categories";
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Category> data = new List<Category>();
            while (reader.Read()) {
                var c = new Category()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                };
                data.Add(c);
            }
            conn.Close();
            return data;
        }

    }
}
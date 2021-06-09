using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace Lecture5.Models.Database
{
    public class Products
    {
        SqlConnection conn;

        public Products(SqlConnection conn) {
            this.conn = conn;
        }
        public void Insert(Product p) {
            //string query = String.Format("Insert into Products values ('{0}','{1}',{2},{3})", p.Name, p.Description, p.Price, p.Qty);
            string query = "Insert into Products values(@name,@desc,@price,@qty)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name",p.Name);
            cmd.Parameters.AddWithValue("@desc",p.Description);
            cmd.Parameters.AddWithValue("@price",p.Price);
            cmd.Parameters.AddWithValue("@qty",p.Qty);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Product> GetAll() {
            List<Product> products = new List<Product>();
            string query = "select * from Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                Product p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Qty = reader.GetInt32(reader.GetOrdinal("Qty")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                };
                products.Add(p);
            }
            conn.Close();
            return products;
        }
        public Product Get(int id) {
            Product p = null;
            string query = $"select * from Products Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) {
                p = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    Qty = reader.GetInt32(reader.GetOrdinal("Qty")),
                    Description = reader.GetString(reader.GetOrdinal("Description")),
                };
            }
            conn.Close();
            return p;
        }
        public void Update(Product p) {
            string query = $"Update Products Set Name='{p.Name}', Price={p.Price} ,Qty={p.Qty}, Description='{p.Description}' Where Id = {p.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        void Delete(Product p) { 
        }
    }
}
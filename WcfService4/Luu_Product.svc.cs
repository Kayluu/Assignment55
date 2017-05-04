using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace WcfService4
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Luu_Product" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Luu_Product.svc or Luu_Product.svc.cs at the Solution Explorer and start debugging.
    public class Luu_Product : ILuu_Product
    {

        public List<Product> ReturnProducts()
        {
            List<Product> products = new List<Product>();

            string _connectionString = WebConfigurationManager.ConnectionStrings["spring17_g9ConnectionString"].ConnectionString;

            //create connection
            SqlConnection con = new SqlConnection(_connectionString);

            //create command object 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Product_ID, Name, Description, Price FROM Product";
            cmd.Connection = con;

            using (con)
            {
                con.Open(); //open connection
                SqlDataReader reader = cmd.ExecuteReader(); // execute command
                while (reader.Read()) //read data
                {
                    Product p = new Product();

                    p.Product_ID = (int)reader["Product_ID"];
                    p.Name = (string)reader["Name"];
                    p.Description = (string)reader["Description"];

                    products.Add(p);

                }

            }

            // add data to the list


            return products;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        public  List<Product> GetList()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products",connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["name"].ToString(),
                    UnitInStock = Convert.ToInt32(reader["UnitInStock"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])

                };
                products.Add(product);
            }
            reader.Close();
            connection.Close();
            return products;
        }
        public void Add(Product product)
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@unitInStock)", connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@unitInStock", product.UnitInStock);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Product product)
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Update Products set Name=@name,UnitPrice=@unitPrice,UnitInStock=@unitInStock where Id =@id", connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@unitInStock", product.UnitInStock);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int Id )
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=ETrade;integrated security=true");

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Delete from Products where Id =@id", connection);
            command.Parameters.AddWithValue("@id", Id);
           
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}

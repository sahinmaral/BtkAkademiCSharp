using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNETDemo
{
    class ProductDal
    {
        static readonly SqlConnection _sqlConnection =
            new SqlConnection("Server=SAHINMARAL;Database=EtradeDb;Trusted_Connection=True;");

        private static void ConnectionControl()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
        }
        public List<Product> GetAll()
        {

           ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Products", _sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            List<Product> products = new List<Product>();

            while (sqlDataReader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(sqlDataReader["Id"]),
                    Name = sqlDataReader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(sqlDataReader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(sqlDataReader["UnitPrice"])
                };

                products.Add(product);
            }

            sqlDataReader.Close();
            _sqlConnection.Close();

            return products;

        }

        public void Add(Product product)
        {

            ConnectionControl();

            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Products (Name,StockAmount,UnitPrice) VALUES (@name,@stockAmount,@unitPrice)",_sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);

            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();

            SqlCommand sqlCommand =
                new SqlCommand("UPDATE Products SET Name = @name , StockAmount = @stockAmount , UnitPrice = @unitPrice WHERE Id = @id",_sqlConnection);

            sqlCommand.Parameters.AddWithValue("@name", product.Name);
            sqlCommand.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            sqlCommand.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            sqlCommand.Parameters.AddWithValue("@id", product.Id);

            sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public void Delete(int id)
        {
            ConnectionControl();

            SqlCommand sqlCommand =
                new SqlCommand("DELETE FROM Products WHERE Id = @id", _sqlConnection);

            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            _sqlConnection.Close();
        }


    }
}

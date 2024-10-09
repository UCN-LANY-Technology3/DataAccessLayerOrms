using ProductManagerDAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerDAL.Daos.ADO
{
    internal class ProductDao(string connectionString) : BaseDao(connectionString), IDao<Product>
    {
        private readonly string _selectProductsSql = "SELECT * FROM Products";
        private readonly string _selectProductSql = "SELECT * FROM Products WHERE Id = @id";
        private readonly string _updateProductSql = "UPDATE Products SET Price = @price, Description = @description, Name = @name WHERE Id = @id";


        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Read()
        {
            using IDbConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            IDbCommand command = connection.CreateCommand();
            command.CommandText = _selectProductsSql;

            IDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                byte[] version = new byte[8];
                reader.GetBytes(4, 0, version, 0, 8);

                Product product = new()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.GetString(2),
                    Price = reader.GetDecimal(3),
                    Version = version
                };

                yield return product;
            }
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

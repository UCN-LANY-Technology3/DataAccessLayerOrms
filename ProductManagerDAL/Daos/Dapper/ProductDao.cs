using Dapper;
using ProductManagerDAL.Entities;
using System.Data;
using System.Data.SqlClient;

namespace ProductManagerDAL.Daos.Dapper
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

            IEnumerable<Product> result = connection.Query<Product>(_selectProductsSql);
                        
            return result;
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

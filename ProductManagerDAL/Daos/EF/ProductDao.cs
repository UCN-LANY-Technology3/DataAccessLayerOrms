using Microsoft.EntityFrameworkCore;
using ProductManagerDAL.Entities;
using System.Data;

namespace ProductManagerDAL.Daos.EF
{
    internal class ProductDao(string connectionString) : BaseDao(connectionString), IDao<Product>
    {
        private ProductContext _context = new(connectionString); // EF Data Context

        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Read()
        {
            return [.. _context.Products];
        }

        public Product Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product entity)
        {
            throw new NotImplementedException();
        }

    }
}

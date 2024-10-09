using Microsoft.EntityFrameworkCore;
using ProductManagerDAL.Entities;

namespace ProductManagerDAL.Daos.EF
{
    internal class ProductContext(string connectionString) : DbContext
    {
        private readonly string _connectionString = connectionString;

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}

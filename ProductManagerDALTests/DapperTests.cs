using ProductManagerDAL.Entities;
using ProductManagerDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerDALTests
{
    public class DapperTests
    {
        private readonly string _connectionString = "Server=192.168.56.101; Database=CafeSanchez; User Id=sa; Password=P@$$w0rd; TrustServerCertificate=True";
        private IDao<Product> _dao;

        [SetUp]
        public void Setup()
        {
            _dao = DaoFactory.Create("Dapper", _connectionString);
        }

        [Test]
        public void Test1()
        {
            var result = _dao.Read();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(9));
        }
    }
}

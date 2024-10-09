using ProductManagerDAL.Entities;
using ProductManagerDAL;

namespace ProductManagerDALTests
{
    public class ADOTests
    {
        private readonly string _connectionString = "Server=192.168.56.101; Database=CafeSanchez; User Id=sa; Password=P@$$w0rd; TrustServerCertificate=True";
        private IDao<Product> _dao;

        [SetUp]
        public void Setup()
        {
            _dao = DaoFactory.Create("ADO", _connectionString);
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
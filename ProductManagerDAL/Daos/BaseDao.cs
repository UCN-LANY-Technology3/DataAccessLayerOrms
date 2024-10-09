using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerDAL.Daos
{
    internal abstract class BaseDao(string connectionString)
    {
        public string ConnectionString { get; } = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
    }
}

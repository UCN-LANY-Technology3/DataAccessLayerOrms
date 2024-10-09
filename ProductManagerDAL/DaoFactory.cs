using Microsoft.EntityFrameworkCore;
using ProductManagerDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerDAL;

public static class DaoFactory
{
    public static IDao<Product> Create(string orm, string connectionString)
    {
        return orm switch
        {
            "EF" => new Daos.EF.ProductDao(connectionString),
            "Dapper" => new Daos.Dapper.ProductDao(connectionString),
            "ADO" => new Daos.ADO.ProductDao(connectionString),
            _ => throw new DaoException("Unknown ORM type"),
        };
    }
}

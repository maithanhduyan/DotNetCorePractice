using Dapper;
using DatabaseConnectionPool.DBConnectionPool;
using DatabaseConnectionPool.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DatabaseConnectionPool.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        public ProductRepository() { }
        internal IDbConnection Connection
        {
            get
            {
                return DataSourceConnectionPool.GetDbConnect();
            }
        }
        public void Add(Product item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> FindAll()
        {
            IEnumerable<Product> products = Connection.Query<Product>("SELECT * FROM product");
            return products;
        }

        public Product FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}

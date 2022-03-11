using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.AppConnection;
using WareHouse.Data.SqlModels;
using Dapper;
namespace WareHouse.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool Delete(string productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            using IDbConnection db = new SqlConnection(ReturnAppConection.ConnectionString);
            if (db.State== ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<Product>("select * from Product", commandType: CommandType.Text);
        }

        public bool Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

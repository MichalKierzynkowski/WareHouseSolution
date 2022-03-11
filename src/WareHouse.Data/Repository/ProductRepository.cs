
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.AppConnection;
using WareHouse.Data.SqlModels;
using Dapper;
using Microsoft.Data.SqlClient;

namespace WareHouse.Data.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool CheckExistenceOfBarNumber(decimal barNumber)
        {
            using (var connection = new SqlConnection(ReturnAppConection.ConnectionString))
            {
                var exists = connection.Query<object>(
                        "SELECT 1 WHERE EXISTS (SELECT 1 FROM Product WHERE BarNumber = @barNumber)", new { barNumber })
                    .Any();

                connection.Close();
                return exists;
            }
        }

        public void Delete(string productId)
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

        public Guid Insert(Product product)
        {
            using IDbConnection db = new SqlConnection(ReturnAppConection.ConnectionString);
                if (db.State==ConnectionState.Closed)
            {
                db.Open();
            }
             db.Query<Product>(@"INSERT INTO Product (IdProduct,IdTypeProduct,BarNumber,DescriptionProduct,IdPurchaseMethod,Quantity,CurrentSellingPrice,IsReturned) values
            (@IdProduct, @IdTypeProduct, @BarNumber, @DescriptionProduct, @IdPurchaseMethod, @Quantity, @CurrentSellingPrice, @IsReturned);",product);
            return product.IdProduct;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        
    }
}

using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.AppConnection;
using WareHouse.Data.SqlModels;

namespace WareHouse.Data.PurchaseRepository
{
    public class PurchaseRepository : IPurchaseRepository
    {
        public void Insert(Purchase purchase)
        {
            using IDbConnection db = new SqlConnection(ReturnAppConection.ConnectionString);
            if (db.State == ConnectionState.Closed)
            {
                db.Open();
            }
            db.Query<Purchase>(@"INSERT INTO Purchase (IdPurchase,IdProduct,DatePurchase,Amount,PurchasePrice) values (@IdPurchase,@IdProduct,@DatePurchase,@Amount,@PurchasePrice);", purchase);

        }
    }
}

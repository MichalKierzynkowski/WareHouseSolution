using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.SqlModels;
using Dapper;
namespace ClassesLibrary.AddItemClasses.Queries
{
    public class AddProductAndPurchaseToDataBase
    {
        public Product Product { get; set; }
        public string ConnectionString { get; }
        public Purchase Purchase { get; set; }
       

        public AddProductAndPurchaseToDataBase(Product product)
        {
           
            Product= product;
            Purchase = Product.Purchase;
            AddProduct();
        }

        public void AddProduct()
        {

           
            string insertSql = @"INSERT INTO Product (IdProduct,IdTypeProduct,BarNumber,DescriptionProduct,IdPurchaseMethod,Quantity,CurrentSellingPrice,IsReturned) values
            (@IdProduct,@IdTypeProduct,@BarNumber,@DescriptionProduct,@IdPurchaseMethod,@Quantity,@CurrentSellingPrice,@IsReturned);";
            using(var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                connection.Execute(insertSql,Product);
                connection.Close();
            }
          
        }
        public void AddPurchase()
        {

        }



    }
}

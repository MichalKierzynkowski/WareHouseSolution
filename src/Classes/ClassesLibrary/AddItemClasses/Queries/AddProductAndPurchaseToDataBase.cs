using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Data.SqlModels;

namespace ClassesLibrary.AddItemClasses.Queries
{
    public class AddProductAndPurchaseToDataBase
    {
        public Product Product { get; set; }
        public string ConnectionString { get; }
        public Purchase Purchase { get; set; }
       

        public AddProductAndPurchaseToDataBase(Product product,string connectionString)
        {
            ConnectionString = connectionString;
            Product= product; 
            Product.Purchase = Purchase;
        }

        public void AddProduct()
        {

            

            string insertSql = @"INSERT INTO Product (Type_Product,Bar_Number,Description_Product,Purchase_Method,Quantity,Offer_Price,IsReturned) Values (@Type_Product,@Bar_Number,@Description,@Purchase_Method,@Quantity,@OfferPrice,'Nie');";

            SqlConnection cnn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(insertSql, cnn);

           
            
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void AddPurchase()
        {

        }



    }
}

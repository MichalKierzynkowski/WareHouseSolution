using WareHouse.Data.PurchaseRepository;
using WareHouse.Data.Repository;
using WareHouse.Data.SqlModels;

namespace ClassesLibrary.AddItemClasses.Queries
{
    public class CreateProductAndPurchase
    {
        public Product Product { get; set; }
        public Purchase Purchase { get; set; }
        private ProductRepository _productRepository { get; set; }
        private PurchaseRepository _purchaseRepository { get; set; }

        public CreateProductAndPurchase(Product product)
        {
            _productRepository = new ProductRepository();
            _purchaseRepository = new PurchaseRepository();
            Product = product;
            Purchase = Product.Purchase;
            CreateProduct();
            CreatePurchase();

        }

        public void CreateProduct()
        {
            _productRepository.Insert(Product);

        }
        public void CreatePurchase()
        {
            _purchaseRepository.Insert(Purchase);
        }


    }
}

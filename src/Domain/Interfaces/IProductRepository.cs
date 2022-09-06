using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product GetByRegistrationNumber(int registrationNumber);

        Product GetById(int id);

        Product Add(Product product);

        void Update(Product product);

        void Delete(Product product);
    }
}
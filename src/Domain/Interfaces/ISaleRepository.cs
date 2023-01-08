using Domain.Entities;

namespace Domain.Interfaces
{
    public interface ISaleRepository
    { 
        IEnumerable<Sale> GetAll();
        Sale GetById(int id);
        Sale Add(Sale sale);
        void Update(Sale sale);
        void Delete(Sale sale);
    }
}

using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IReturnRepository
    {
        IEnumerable<Return> GetAll();

        Return GetById(int id);

        Return Add(Return returnItem);

        void Update(Return returnItem);

        void Delete(Return returnItem);
    }
}

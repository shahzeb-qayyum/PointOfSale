using PointOfSale.Domain.Entities;

namespace PointOfSale.DataAccessLayer.Infrastructure.Contracts
{
    public interface ICategoryService
    {
        Category Insert(Category category);
        Category Update(Category category);
        Category GetById(int Id);
        bool Delete(int Id);
        List<Category> GetAll();
    }
}

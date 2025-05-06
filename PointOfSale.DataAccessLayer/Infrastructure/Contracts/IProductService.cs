using PointOfSale.Domain.Entities;

namespace PointOfSale.DataAccessLayer.Infrastructure.Contracts
{
    public interface IProductService
    {
        Product Insert(Product product);
        Product Update(Product product);
        Product GetById(int Id);
        bool Delete(int Id);
        List<Product> GetAll();
    }
}

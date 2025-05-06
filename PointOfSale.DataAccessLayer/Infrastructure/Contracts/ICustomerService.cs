using PointOfSale.Domain.Entities;

namespace PointOfSale.DataAccessLayer.Infrastructure.Contracts
{
    public interface ICustomerService
    {
        Customer Insert(Customer customer);

        List<Customer> GetAll();

        Customer Update(Customer customer);

        bool Delete(int Id);

        Customer GetById(int Id);
    }
}

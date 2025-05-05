using PointOfSale.DataAccessLayer.Infrastructure.Contracts;
using PointOfSale.Domain.Entities;

namespace PointOfSale.DataAccessLayer.Infrastructure.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ECommerceDbContext db;

        public CustomerService(ECommerceDbContext context)
        {
            this.db = context;
        }
        public bool Delete(int Id)
        {
            var customerToDelete = GetById(Id);
            db.Customers.Remove(customerToDelete);
            db.SaveChanges();
            return true;
        }

        public List<Customer> GetAll()
        {
            var customers = db.Customers.ToList();
            return customers;
        }

        public Customer GetById(int Id)
        {
            var customer = db.Customers.Where(cust => cust.Id == Id).FirstOrDefault();
            return customer!;
        }

        public Customer Insert(Customer customer)
        {
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }

        public Customer Update(Customer customer)
        {
            var CustomerToUpdate = GetById(customer.Id);
            CustomerToUpdate.FirstName = customer.FirstName;
            CustomerToUpdate.LastName = customer.LastName;
            CustomerToUpdate.Email = customer.Email;
            CustomerToUpdate.Phone = customer.Phone;
            db.SaveChanges();
            return CustomerToUpdate;
        }
    }
}

using PointOfSale.DataAccessLayer.Infrastructure.Contracts;
using PointOfSale.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.DataAccessLayer.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ECommerceDbContext db;
        public EmployeeService(ECommerceDbContext context)
        {
            this.db = context;
        }
        public bool Delete(int Id)
        {
            var EmployeeToDelete = GetById(Id);
            db.Employees.Remove(EmployeeToDelete);
            db.SaveChanges();
            return true;
        }

        public List<Employee> GetAll()
        {
            var Employee = db.Employees.ToList();
            return Employee;
        }

        public Employee GetById(int Id)
        {
            var Employee = db.Employees.Where(cust => cust.Id == Id).FirstOrDefault();
            return Employee!;
        }

        public Employee Insert(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return employee;
        }

        public Employee Update(Employee employee)
        {
            var EmployeeToUpdate = GetById(employee.Id);
            EmployeeToUpdate.FirstName = employee.FirstName;
            EmployeeToUpdate.LastName = employee.LastName;
            EmployeeToUpdate.Email = employee.Email;
            EmployeeToUpdate.Phone = employee.Phone;
            db.Employees.Update(EmployeeToUpdate);
            db.SaveChanges();
            return employee;
        }
    }
}

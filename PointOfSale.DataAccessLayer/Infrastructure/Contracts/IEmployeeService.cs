using PointOfSale.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.DataAccessLayer.Infrastructure.Contracts
{
    public interface IEmployeeService
    {
        Employee Insert(Employee employee);

        List<Employee> GetAll();

        Employee Update(Employee employee);

        bool Delete(int Id);

        Employee GetById(int Id);
    }
}

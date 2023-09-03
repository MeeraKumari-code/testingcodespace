//add necessary using statements
using System.Collections.Generic;
using System.Linq;
using CustomersApi.Models;
using CustomersApi.Repository;

namespace CustomersApi.Repository
{
   //implement interface with List<Customer> as data source
    public class CustomerRepository : ICustomerRepository
    {
        //create private field to store data
        private List<Customers> _customers;
        //create constructor to initialize data
        public CustomerRepository()
        {
            _customers = new List<Customers>()
            {
                new Customers(){Id=1, Name="Keyboard", Price=20, Brand="Logitech", Quantity=10},
                new Customers(){Id=2, Name="Mouse", Price=10, Brand="Logitech", Quantity=20},
                new Customers(){Id=3, Name="Monitor", Price=100, Brand="Dell", Quantity=5},
                new Customers(){Id=4, Name="Laptop", Price=500, Brand="Dell", Quantity=2},
                new Customers(){Id=5, Name="Headset", Price=50, Brand="Logitech", Quantity=15},
            };
        }
        //implement interface methods
        public IEnumerable<Customers> GetCustomers()
        {
            return _customers;
        }
        public Customers GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(p => p.Id == id);
        }
        public void AddCustomer(Customers customer)
        {
            _customers.Add(customer);
        }
        public void UpdateCustomer(Customers customer)
        {
            var customerToUpdate = _customers.FirstOrDefault(p => p.Id == customer.Id);
            if (customerToUpdate != null)
            {
                customerToUpdate.Name = customer.Name;
                customerToUpdate.Price = customer.Price;
                customerToUpdate.Brand = customer.Brand;
                customerToUpdate.Quantity = customer.Quantity;
            }
        }
        public void DeleteCustomer(int id)
        {
            var customerToDelete = _customers.FirstOrDefault(p => p.Id == id);
            if (customerToDelete != null)
            {
                _customers.Remove(customerToDelete);
            }
        }
    }
}
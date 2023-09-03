//add necessary using statements
using System.Collections.Generic;
using System.Linq;
using CustomersApi.Models;
using CustomersApi.Repository;

public interface ICustomerRepository
{
    //create method to get all customers
    IEnumerable<Customers> GetCustomers();
    //create method to get customer by id
    Customers GetCustomerById(int id);
    //create method to add customer
    void AddCustomer(Customers customer);
    //create method to update customer
    void UpdateCustomer(Customers customer);
    //create method to delete customer
    void DeleteCustomer(int id);
}
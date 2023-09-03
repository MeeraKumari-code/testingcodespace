//add necessary using statements
using System.Collections.Generic;
using System.Linq;
using CustomersApi.Controllers;
using CustomersApi.Models;
using CustomersApi.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//add Moq nuget package
using Moq;

namespace CustomerApiTestProject
{
    //create class CustomerControllerTests
    public class CustomerControllerTests
    {
        //create private fields: mockRepository, controller
        private Mock<ICustomerRepository> mockRepository;
        private CustomerController controller;
        //create test initialize method
        [TestInitialize]
        public void TestInitialize()
        {
            //create new mock repository
            mockRepository = new Mock<ICustomerRepository>();
            //create new controller with mock repository
            controller = new CustomerController(mockRepository.Object);
        }
        //create test method to test GetCustomers method
        [TestMethod]
        public void GetCustomersTest()
        {
            //arrange
            //create new list of customers
            List<Customers> customers = new List<Customers>();
            //add new customer to list
            customers.Add(new Customers { Id = 1, Name = "Test Customer 1", Price = 1.99, Brand = "Test Brand 1", Quantity = 1 });
            //add new customer to list
            customers.Add(new Customers { Id = 2, Name = "Test Customer 2", Price = 2.99, Brand = "Test Brand 2", Quantity = 2 });
            //add new customer to list
            customers.Add(new Customers { Id = 3, Name = "Test Customer 3", Price = 3.99, Brand = "Test Brand 3", Quantity = 3 });
            //set up mock repository to return list of customers
            mockRepository.Setup(m => m.GetCustomers()).Returns(customers);
            //act
            //call GetCustomers method
            var result = controller.GetCustomers() as List<Customers>;
            //assert
            //check if result is not null
            Assert.IsNotNull(result);
            //check if result is of type List<Customers>
            Assert.IsInstanceOfType(result, typeof(List<Customers>));
            //check if result count is equal to 3
            Assert.AreEqual(3, result.Count);
        }
        //create test method to test GetCustomerById method
        [TestMethod]
        public void GetCustomerByIdTest()
        {
            //arrange
            //create new customer
            Customers customer = new Customers { Id = 1, Name = "Test Customer 1", Price = 1.99, Brand = "Test Brand 1", Quantity = 1 };
            //set up mock repository to return customer
            mockRepository.Setup(m => m.GetCustomerById(1)).Returns(customer);
            //act
            //call GetCustomerById method
            var result = controller.GetCustomerById(1) as Customers;
            //assert
            //check if result is not null
            Assert.IsNotNull(result);
            //check if result is of type Customers
            Assert.IsInstanceOfType(result, typeof(Customers));
            //check if result id is equal to 1
            Assert.AreEqual(1, result.Id);
        }
    }

}
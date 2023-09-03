//add necessary using statements
using System.Collections.Generic;
using System.Linq;
using CustomersApi.Models;
using CustomersApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CustomersApi.Controllers
{
    //create CustomerController class
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        //create private field of type ICustomerRepository
        private readonly ICustomerRepository _customerRepository;
        //create constructor with parameter of type ICustomerRepository
        public CustomerController(ICustomerRepository customerRepository)
        {
            //assign parameter to private field
            _customerRepository = customerRepository;
        }
        //create method to get all customers
        [HttpGet]
        public IActionResult GetCustomers()
        {
            //return Ok with all customers
            return Ok(_customerRepository.GetCustomers());
        }
        //create method to get customer by id
        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            //return Ok with customer by id
            return Ok(_customerRepository.GetCustomerById(id));
        }
        //create method to add customer
        [HttpPost]
        public IActionResult AddCustomer(Customers customer)
        {
            //add customer
            _customerRepository.AddCustomer(customer);
            //return Ok
            return Ok();
        }
        //create method to update customer
        [HttpPut]
        public IActionResult UpdateCustomer(Customers customer)
        {
            //update customer
            _customerRepository.UpdateCustomer(customer);
            //return Ok
            return Ok();
        }
        //create method to delete customer
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            //delete customer
            _customerRepository.DeleteCustomer(id);
            //return Ok
            return Ok();
        }
    }
}
//add using statement
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Models;
using ProductsApi.Repository;

namespace ProductsApi.Controllers
{
    //create ProductController class
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        //create private field of type IproductRepository
        private readonly IproductRepository _productRepository;
        //create constructor with parameter of type IproductRepository
        public ProductController(IproductRepository productRepository)
        {
            //assign parameter to private field
            _productRepository = productRepository;
        }
        //create method to get all products
        [HttpGet]
        public IActionResult GetProducts()
        {
            //return Ok with all products
            return Ok(_productRepository.GetProducts());
        }
        //create method to get product by id
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            //return Ok with product by id
            return Ok(_productRepository.GetProductById(id));
        }
        //create method to add product
        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            //add product
            _productRepository.AddProduct(product);
            //return Ok
            return Ok();
        }
        //create method to update product
        [HttpPut]
        public IActionResult UpdateProduct(Products product)
        {
            //update product
            _productRepository.UpdateProduct(product);
            //return Ok
            return Ok();
        }
        //create method to delete product
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            //delete product
            _productRepository.DeleteProduct(id);
            //return Ok
            return Ok();
        }
    }
}
//add necessary using statements
using System.Collections.Generic;
using System.Linq;
using ProductsApi.Models;
using ProductsApi.Repository;

namespace ProductsApi.Repository
{
    public interface IproductRepository
    {
        //create method to get all products
        IEnumerable<Products> GetProducts();
        //create method to get product by id
        Products GetProductById(int id);
        //create method to add product
        void AddProduct(Products product);
        //create method to update product
        void UpdateProduct(Products product);
        //create method to delete product
        void DeleteProduct(int id);
    }
}
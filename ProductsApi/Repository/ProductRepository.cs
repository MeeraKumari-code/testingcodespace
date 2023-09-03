//add necessary using statements
using System.Collections.Generic;
using System.Linq;
using ProductsApi.Models;
using ProductsApi.Repository;

namespace ProductsApi.Repository
{
    //implement interface with List<Product> as data source
    public class ProductRepository : IproductRepository
    {
        //create private field to store data
        private  List<Products> _products;
        //create constructor to initialize data
        public ProductRepository()
        {
            _products = new List<Products>()
            {
                new Products(){Id=1, Name="Keyboard", Price=20, Brand="Logitech", Quantity=10},
                new Products(){Id=2, Name="Mouse", Price=10, Brand="Logitech", Quantity=20},
                new Products(){Id=3, Name="Monitor", Price=100, Brand="Dell", Quantity=5},
                new Products(){Id=4, Name="Laptop", Price=500, Brand="Dell", Quantity=2},
                new Products(){Id=5, Name="Headset", Price=50, Brand="Logitech", Quantity=15},
            };
        }
        //implement interface methods
        public IEnumerable<Products> GetProducts()
        {
            return _products;
        }
        public Products GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void AddProduct(Products product)
        {
            _products.Add(product);
        }
        public void UpdateProduct(Products product)
        {
            var productToUpdate = _products.FirstOrDefault(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.Brand = product.Brand;
                productToUpdate.Quantity = product.Quantity;
            }
        }
        public void DeleteProduct(int id)
        {
            var productToDelete = _products.FirstOrDefault(p => p.Id == id);
            if (productToDelete != null)
            {
                _products.Remove(productToDelete);
            }
        }
    }
}
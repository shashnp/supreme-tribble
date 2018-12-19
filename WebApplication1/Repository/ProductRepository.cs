using System;
using System.Collections.Generic;
using System.Web.Configuration;
using WebApplication1.Context;
using WebApplication1.DomainModels;
using WebApplication1.Interfaces;

namespace WebApplication1.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly WebProjectContext _webProjectContext;
        private List<Product> products = new List<Product>();
        private int nextId = 1;

        public ProductRepository(WebProjectContext webProjectContext)
        {
            _webProjectContext = webProjectContext;
            // Add products for the Demonstration 
            Add(new Product { Name = "TV", Category = "Electronics", Price = 100 });
            Add(new Product { Name = "Computer", Category = "Electronics", Price = 1000 });
            Add(new Product { Name = "Laptop", Category = "Electronics", Price = 8000 });
            Add(new Product { Name = "Google Pixel 2", Category = "Phone", Price = 150 });
        }

        public IEnumerable<Product> GetAll()
        {
            return _webProjectContext.Products.Include("Customer");
            //throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Add(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException("product");
            }

            //TODO: Save record to DB;
            product.Id = nextId++;
            products.Add(product);
            return product;

        }

        public bool Update(Product item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
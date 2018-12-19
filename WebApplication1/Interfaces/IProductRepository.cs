using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DomainModels;
using WebApplication1.Repository;

namespace WebApplication1.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product Get(int id);

        Product Add(Product product);

        bool Update(Product item);

        bool Delete(int id);
    }
}
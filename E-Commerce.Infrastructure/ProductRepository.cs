using E_Commerce.Application.contracts;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        public Product Add(Product client)
        {
            throw new NotImplementedException();
        }

        public Product Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> getAll()
        {
            throw new NotImplementedException();
        }

        public Product getOne(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product client)
        {
            throw new NotImplementedException();
        }
    }
}

using E_Commerce.Application.contracts;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class OrderRepository : IOrderRepository
    {
        public Order Add(Order client)
        {
            throw new NotImplementedException();
        }

        public Order Create(Order entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Order> getAll()
        {
            throw new NotImplementedException();
        }

        public Order getOne(int id)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order client)
        {
            throw new NotImplementedException();
        }
    }
}

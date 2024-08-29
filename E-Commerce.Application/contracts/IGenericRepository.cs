using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.contracts
{
    public interface IGenericRepository<T>
    {
        public T getOne(int id);
        public IQueryable<T> getAll();

        public T Create(T entity);
        public void Delete(int id);

        public T Add(T client);
        public T Update(T client);
    }
}

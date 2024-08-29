using E_Commerce.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public interface IGenericServices<T>
    {
        public T Add(T product);
        //public ProductDTO Update(ProductDTO product);
        public void Delet(int productId);
        public T GetOne(int productId);
        public ICollection<T> GetallProducts();
        public ICollection<T> GetallProductsDTO();
    }
}

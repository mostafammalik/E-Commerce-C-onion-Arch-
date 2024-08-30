using AutoMapper;
using E_Commerce.Application.contracts;
using E_Commerce.DTO;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;
        public ProductServices(IProductRepository productRepository ,IMapper _imapper)
        {
            this.productRepository = productRepository;
            mapper = _imapper;
        }
        public ProductDTO Add(ProductDTO product )
        {
            var _product =  mapper.Map<Product>( product);
            var _productDTO =  productRepository.Add(_product);  
            var finalProduct =mapper.Map<ProductDTO>(_productDTO);
            return finalProduct;
        }

        public ProductDTO Create(ProductDTO product)
        {
            var _product = mapper.Map<Product>(product);
            return mapper.Map<ProductDTO>(_product);
        }

        public void Delet(int productId)
        {

            productRepository.getAll()
                .Select(product => product.Id = productId).FirstOrDefault();
            ////productRepository.Delete()
        }

        public ICollection<GetAllProductsDTO> GetAllProducts()
        {
            return productRepository.getAll()
                .Select(p => new GetAllProductsDTO()
                {
                    Name = p.Name,
                    Description = p.Description
                })
                .ToList();
        }

        public ICollection<ProductDTO> GetallProductsM()
        {
            return productRepository.getAll()
                                     .Select(p => new ProductDTO()
                                     {
                                         Name = p.Name,
                                         Description = p.Description,
                                         Id = p.Id
                                     }).ToList();
        }

        public ICollection<GetAllProductsDTO> GetallProductsDTOM()
        {
            return productRepository.getAll()
                                     .Select(p => new GetAllProductsDTO()
                                     {
                                         Name = p.Name,
                                         Description = p.Description,
                                         Id = p.Id
                                     }).ToList();
        }

        public ProductDTO GetOne(int productId)
        {
            var _product = productRepository.getAll()
                                    .Where(p => p.Id == productId)
                                    .Select(p => new ProductDTO()
                                    { Name = p.Name, Description = p.Description }).FirstOrDefault();
            return _product;
        }

        ICollection<ProductDTO> IGenericServices<ProductDTO>.GetallProductsDTO()
        {
            return GetallProductsM();
        }

        public ICollection<ProductDTO> GetallProducts()
        {
            throw new NotImplementedException();
        }
    }
}

using AutoMapper;
using E_Commerce.DTO;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            
                CreateMap<Category, CategoryDTO>().ReverseMap();
                CreateMap<Product,ProductDTO>().ReverseMap();
            CreateMap<GetAllProductsDTO, Product>().ReverseMap();
            
        }
    }
}

using AutoMapper;
using E_Commerce.Application.contracts;
using E_Commerce.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class CategoryServices : ICategoryServices
    {
        private ICategoryRepository categoryRepository;
        private readonly  IMapper mapper;
        public CategoryServices(ICategoryRepository categoryRepository ,IMapper _imapper)
        {
            this.categoryRepository = categoryRepository;
            mapper = _imapper;
        }
        public CategoryDTO Add(CategoryDTO category)
        { 
            var cat =mapper.Map<Category>(category); 
            var catRepo =categoryRepository.Add(cat); 
            
            return mapper.Map<CategoryDTO>(catRepo);
        }

        public void Delet(int categoryId)
        {
            throw new NotImplementedException();
        }

        public ICollection<CategoryDTO> GetallProducts()
        {
            throw new NotImplementedException();
        }

        public CategoryDTO GetOne(int categoryId)
        {
           return mapper.Map<CategoryDTO>
                ( categoryRepository.getOne(categoryId));
        }

        public ICollection<CategoryDTO> GetallProductsDTO()
        {
            throw new NotImplementedException();
        }
    }
}

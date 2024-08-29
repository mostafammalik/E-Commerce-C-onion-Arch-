using E_Commerce.Application.contracts;
using E_Commerce.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class CategoryRepository : ICategoryRepository
    {
        EcommerceContext context; 
        public CategoryRepository(EcommerceContext context)
        {
            this.context = context;
        }
        public Category Add(Category category)
        {
            return context.Categories.Add(category).Entity;


        }

        public Category Create(Category entity)
        {
            return context.Categories.Add(entity).Entity;
        }

        public void Delete(int id)
        {
            var category =  context.Categories.Where(cat => cat.Id == id).FirstOrDefault();  
            context.Categories.Remove(category);
         
        }

        public IQueryable<Category> getAll()
        {
            return context.Categories;
        }

        public Category getOne(int id)
        {
            return
                context.Categories.Where(cat => cat.Id == id).FirstOrDefault();
        }

        public int GetProductCountByCategoryId(int categoryId)
        {
            return
                 context.Products.Count(p => p.CatID == categoryId);
        }

        public IQueryable<Category> SearchByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category category)
        {
            return new Category();
        }
    }
}

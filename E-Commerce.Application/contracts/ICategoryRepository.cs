﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.contracts
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        int GetProductCountByCategoryId(int categoryId);
        public IQueryable<Category> SearchByName(string Name);

    }
}

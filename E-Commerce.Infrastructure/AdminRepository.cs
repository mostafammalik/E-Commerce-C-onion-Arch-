using E_Commerce.Application.contracts;
using E_Commerce.Context;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class AdminRepository:IAdminRepository
    {
        private readonly EcommerceContext context;

        public AdminRepository(EcommerceContext _context)
        {
            context = _context;
        }
        public Admin getAdmin(string password, string name)
        {
            return context.Admins.SingleOrDefault(a => a.Name == name && a.Password == password);
        }
    }
}

using E_Commerce.Application.contracts;
using E_Commerce.Application.Mapper;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IAdminRepository adminRepository;
       
        public AdminServices(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }

        public bool check(string username, string password)
        {
            var user = adminRepository.getAdmin(username,password);
            if (user == null)
                return false;
            return true;
        }
    }
}

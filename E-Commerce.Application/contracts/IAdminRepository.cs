using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.contracts
{
    public  interface IAdminRepository
    {
        public Admin getAdmin(string password,string name);
    }
}

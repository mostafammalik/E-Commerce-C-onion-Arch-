using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    { 
        public int Id { set; get; } 
        public Client client { set; get; } 
        public ICollection<Product> Products { set; get; } 
        public DateTime date_time { set; get; }
    }
}

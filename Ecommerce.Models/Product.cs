using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category category { get; set; }
        public DateTime? Expiredate { set; get; }
        public string Image { get; set; }
       public int? AdminId { get; set; }
        [ForeignKey("Client")]
        public Client client { get; set; }

       public decimal Price { get; set; }
        [ForeignKey("category")]
        public int? CatID { get; set; }
       

        //public ICollection<ProductInOrder> ProductInOrders { get; set; }
        //public ICollection<Item> items { get; set; }
        //public ICollection<ProductCartItem> productCartItems { get; }
    }
}

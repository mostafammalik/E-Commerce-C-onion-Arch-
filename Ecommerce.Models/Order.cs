using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Order
    { 
        public int Id { set; get; } 
        public Client? client { set; get; }
        [ForeignKey("Client")]
        public int? Client_ID { get; set; }
        public ICollection<Product> Products { set; get; } 
        public DateTime date_time { set; get; }
        public decimal totalprice { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
    public enum OrderStatus
    {
        processing = 0,
        shipped = 1,
        delivered = 2,
    }
}

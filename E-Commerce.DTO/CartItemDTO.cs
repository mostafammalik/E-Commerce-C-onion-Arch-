using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTO
{
    public class CartItemDTO
    {
        public int Id { get; set; }

        [ForeignKey("client")]
        public int clientId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}

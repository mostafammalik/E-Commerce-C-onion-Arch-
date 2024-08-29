using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Cartitem
    {
        public int Id { get; set; }

        [ForeignKey("client")]
        public int client_Id { get; set; }
        public Client client { get; set; }


        
    }
}

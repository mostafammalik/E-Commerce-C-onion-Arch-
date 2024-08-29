using System;
namespace Ecommerce.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int password { get; set; }
        public string address { get; set; }
        public ICollection<Product> products { get; set; }


    }
}


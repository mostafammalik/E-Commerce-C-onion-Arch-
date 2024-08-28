﻿using System;
using System.Collections.Generic;
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
    }
}

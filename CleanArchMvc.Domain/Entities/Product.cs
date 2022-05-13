﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product
    {
        public Product()
        {

        }
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Desciption { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get;  set; }
    }
}

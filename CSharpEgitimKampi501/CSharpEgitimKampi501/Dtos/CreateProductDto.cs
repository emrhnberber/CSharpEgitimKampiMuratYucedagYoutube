﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Dtos
{
    public class CreateProductDto
    {
        public int ProductStock { get; set; }

        public string ProductName { get; set; }

        public string ProductCategory { get; set; }

        public decimal ProductPrice { get; set; }
    }
}

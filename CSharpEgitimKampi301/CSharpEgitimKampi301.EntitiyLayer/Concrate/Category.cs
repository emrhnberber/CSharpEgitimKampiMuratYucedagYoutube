﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntitiyLayer.Concrate
{
    public class Category
    {
        public int CategoryId { get; set; }

        public int CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }
    }
}

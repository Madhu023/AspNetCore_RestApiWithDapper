﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore_RestApiWithDapper.Models
{
    public class Product
    {
        public long Id { get; set; }

        public long CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime CreationDate { get; set; }
    }
}

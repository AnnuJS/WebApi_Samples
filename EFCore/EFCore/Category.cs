using System;
using System.Collections.Generic;

namespace EFCore
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}

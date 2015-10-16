using System;
using System.Collections.Generic;
using OnlineStore.Infrastructure.Domain;
using OnlineStore.Model.Categories;

namespace OnlineStore.Model.Products
{
    public class ProductTitle : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public ProductColor Color { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }

}

using System;
using OnlineStore.Infrastructure.Domain;
using OnlineStore.Model.Products;

namespace OnlineStore.Model.Categories
{
    public class Category : EntityBase<int>, IAggregateRoot, IProductAttribute
    {               
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineStore.Infrastructure.Domain;

namespace OnlineStore.Model.Products
{
    public class Brand : EntityBase<int>, IProductAttribute
    {        
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}

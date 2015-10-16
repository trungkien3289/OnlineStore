﻿using System;
using OnlineStore.Infrastructure.Domain;

namespace OnlineStore.Model.Products
{
    public class ProductColor : EntityBase<int>, IProductAttribute
    {
        public string Name { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }     
    }
}

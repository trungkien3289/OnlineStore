using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineStore.Infrastructure.Domain;

namespace OnlineStore.Model.Products
{
    public interface IProductRepository : IReadOnlyRepository<Product, int>
    {
    }
}

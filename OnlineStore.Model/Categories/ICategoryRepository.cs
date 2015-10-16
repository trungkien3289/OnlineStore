using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnlineStore.Infrastructure.Domain;

namespace OnlineStore.Model.Categories
{
    public interface ICategoryRepository : IReadOnlyRepository<Category,int>
    {
    }
}

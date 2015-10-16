using OnlineStore.Infrastructure.Domain;

namespace OnlineStore.Model.Products
{
    public interface IProductTitleRepository : IReadOnlyRepository<ProductTitle, int> 
    {       
    }
}

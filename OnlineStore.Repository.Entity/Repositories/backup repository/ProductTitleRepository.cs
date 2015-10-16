using OnlineStore.Infrastructure;
using OnlineStore.Infrastructure.UnitOfWork;
using OnlineStore.Model.Products;

namespace OnlineStore.Repository.Entity.Repositories
{
    public class ProductTitleRepository : Repository<ProductTitle, int>,
                                                           IProductTitleRepository
    {
        public ProductTitleRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }
}

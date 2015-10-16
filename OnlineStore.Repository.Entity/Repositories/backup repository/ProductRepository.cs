using OnlineStore.Infrastructure.UnitOfWork;
using OnlineStore.Model.Products;

namespace OnlineStore.Repository.Entity.Repositories
{
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        public ProductRepository(IUnitOfWork uow)
            : base(uow)
        {
        }

        public override void AppendCriteria(ICriteria criteria)
        {
            criteria.CreateAlias("Title", "ProductTitle");
            criteria.CreateAlias("ProductTitle.Category", "Category");
            criteria.CreateAlias("ProductTitle.Brand", "Brand");
            criteria.CreateAlias("ProductTitle.Color", "Color");
        }
    }

}

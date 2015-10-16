using OnlineStore.Infrastructure.UnitOfWork;
using OnlineStore.Model.Categories;

namespace OnlineStore.Repository.Entity.Repositories
{
    public class CategoryRepository : Repository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(IUnitOfWork uow)
            : base(uow)
        {
        }
    }

}

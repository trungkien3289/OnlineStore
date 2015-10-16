using OnlineStore.Services.Messaging.ProductCatalogService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Services.Interfaces
{
    public interface IProductCatalogService
    {
        GetFeaturedProductsResponse GetFeaturedProducts();
        GetProductsByCategoryResponse GetProductsByCategory(GetProductsByCategoryRequest request);
        GetProductResponse GetProduct(GetProductRequest request);
        GetAllCategoriesResponse GetAllCategories();
    }
}

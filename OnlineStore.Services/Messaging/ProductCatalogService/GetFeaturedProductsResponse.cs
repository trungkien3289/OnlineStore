using OnlineStore.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Services.Messaging.ProductCatalogService
{
    public class GetFeaturedProductsResponse
    {
        public IEnumerable<ProductSummaryView> Products { get; set; }
    }
}

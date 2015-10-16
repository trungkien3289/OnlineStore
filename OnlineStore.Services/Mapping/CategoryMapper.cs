using AutoMapper;
using OnlineStore.Model.Categories;
using OnlineStore.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Services.Mapping
{
    public static class CategoryMapper
    {
        public static IEnumerable<CategoryView> ConvertToCategoryViews(this IEnumerable<Category> categories)
        {
            return Mapper.Map<IEnumerable<Category>,IEnumerable<CategoryView>>(categories);
        }
    }
}

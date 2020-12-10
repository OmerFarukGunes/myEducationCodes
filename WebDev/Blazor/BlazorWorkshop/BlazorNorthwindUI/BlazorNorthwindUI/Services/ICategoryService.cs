using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public interface ICategoryService
    {
        Task<CategoryListViewModel[]> GetCategories();
    }
}

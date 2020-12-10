using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    interface IProductService
    {
        Task<ProductListViewModel[]> GetProducts();

        Task Add(ProductViewModel productListViewModel);
        Task Save(ProductViewModel productViewModel);
        Task<ProductViewModel> GetProductById(int ProductId);
    }
}

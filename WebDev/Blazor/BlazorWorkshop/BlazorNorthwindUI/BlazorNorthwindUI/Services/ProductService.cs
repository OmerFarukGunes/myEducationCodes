using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task Add(ProductViewModel ProductViewModel)
        {
            //asenkron operasyon yaptigimiz zaman await bekle desemk async asenkron demek.
            await _httpClient.PostAsJsonAsync(requestUri: "http://localhost:44399/Databases/Northwind/Tables/dbo.products", ProductViewModel);
        }

        public Task<ProductViewModel> GetProductById(int ProductId)
        {
            return _httpClient.GetFromJsonAsync<ProductViewModel>(requestUri: "http://localhost:44399/api/products/getbyid?productid="+ProductId);
        }

        public Task<ProductListViewModel[]> GetProducts()
        {
            return _httpClient.GetFromJsonAsync<ProductListViewModel[]>(requestUri: "http://localhost:44399/api/products/getall");
        }

        public async Task Save(ProductViewModel ProductViewModel)
        {
            await _httpClient.PostAsJsonAsync(requestUri: "http://localhost:44399/api/products/update", ProductViewModel);
        }
    }
}

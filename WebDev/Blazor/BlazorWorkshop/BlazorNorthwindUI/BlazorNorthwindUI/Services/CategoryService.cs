using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{

    public class CategoryService:ICategoryService
    {

        private HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public Task<CategoryListViewModel[]> GetCategories()
        {
            return _httpClient.GetFromJsonAsync<CategoryListViewModel[]>(requestUri: "http://localhost:44399/api/products/getall");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorIntro.Models;
using Microsoft.AspNetCore.Components;
namespace BlazorIntro.Services
{
    public class JsonPlaceHolderApi {
        private HttpClient _http;
        public JsonPlaceHolderApi(HttpClient http)
        {
            _http = http;
        }
        public Task<todoItem[]> GetToDos()
         {
            return _http.GetFromJsonAsync<todoItem[]>(requestUri:"http://jsonplaceholder.typicode.com/todos");
         }
    }
}

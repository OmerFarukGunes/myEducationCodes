using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazor.Extensions.Storage;
using BlazorNorthwindUI.Models;

namespace BlazorNorthwindUI.Services
{

    public class AuthService : IAuthService
    {
        HttpClient _httpClient;
        LocalStorage _localStorage;
        public bool IsLoggedIn { get; set; }

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Login(LoginModel loginModel)

        {

            var response = await _httpClient.PostAsJsonAsync<TokenModel>("https://localhost:44335/api/auth/login", loginModel);


            if (!String.IsNullOrEmpty(response.Token))

            {

                await _localStorage.SetItem("token", response.Token);

                IsLoggedIn = true;

            }

        }

        public async Task Logout()
        {
            IsLoggedIn = false;
        }
        private async Task SetAuthorizationHeader()
        {
            if(!_httpClient.DefaultRequestHeaders.Contains(name:"Authorization"))
            {
                var token = await _localStorage.GetItem<string>("token");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(scheme: "Bearer", parameter: token);
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorNorthwindUI.Services;
using Blazor.Extensions.Storage;

namespace BlazorNorthwindUI
{
    public class Startup
    {
            public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
            services.AddSingleton<ICategoryService, CategoryService>();
            services.AddSingleton<IAuthService, AuthService>();
            services.AddStorage();
        }
    }
}

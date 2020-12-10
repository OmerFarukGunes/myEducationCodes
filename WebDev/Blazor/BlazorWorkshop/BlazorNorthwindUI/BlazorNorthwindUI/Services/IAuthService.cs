using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public interface IAuthService
    {
        Task Login(LoginModel loginModel);
        Task Logout();
    }
}

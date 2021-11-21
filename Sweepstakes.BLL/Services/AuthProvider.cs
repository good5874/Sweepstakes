using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Sweepstakes.BLL.Interfaces;
using Sweepstakes.Common.Enum;
using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sweepstakes.BLL.Services
{
    public class AuthProvider : IAuthProvider
    {
        private IUserRepository userRepository;

        public AuthProvider(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        private async Task Authenticate(User user, HttpContext httpContext)
        {
            var claims = new List<Claim>
            {
                new Claim("Email", user.Email, "string"),
                new Claim("Role", user.RoleId.ToString(), "string")
            };
            ClaimsIdentity id = new ClaimsIdentity(claims);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public void Login(string email, string password, HttpContext httpContext)
        {
            var user = userRepository.Get(email);

            if (user != null && user.Password == password)
            {
                Authenticate(user, httpContext).Wait();
            }
            else
            {
                throw new Exception("Wrong login or password");
            }
        }

        public void Logout(HttpContext httpContext)
        {
            httpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
        }

        public void Registration(string fullName, string phone, string email, string password, HttpContext httpContext)
        {

            var user = userRepository.Get(email);
            if (user == null)
            {
                userRepository.Create(new User(0, fullName, phone, email, password, (int)Roles.User));
            }
            else
            {
                throw new Exception("User exists");
            }
        }
    }
}

using Microsoft.AspNetCore.Http;

namespace Sweepstakes.BLL.Interfaces
{
    public interface IAuthProvider
    {
        void Registration(string fullName, string phone, string email, string password, HttpContext httpContext);
        void Login(string email, string password, HttpContext httpContext);
        void Logout(HttpContext httpContext);
    }
}

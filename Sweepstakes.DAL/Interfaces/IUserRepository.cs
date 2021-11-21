using Sweepstakes.Common.Models;

namespace Sweepstakes.DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User Get(string email);
    }
}

using Microsoft.Extensions.Configuration;
using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class UserRepository : AbstractCRUDRepository<User>, IUserRepository
    {
        public UserRepository(IConfiguration configuration) : base(configuration) { }

        public User Get(string email)
        {
            return ExecuteScalarSqlQuery($"SELECT * FROM dbo.[User] WHERE (Email = '{email}')");
        }
    }
}

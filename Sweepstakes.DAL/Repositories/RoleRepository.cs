using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class RoleRepository : AbstractCRUDRepository<Role>, IRoleRepository
    {
        public RoleRepository(string conection) : base(conection) { }
    }
}

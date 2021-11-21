using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class TeamRepository: AbstractCRUDRepository<Team>, ITeamRepository
    {
        public TeamRepository(string conection) : base(conection) { }
    }
}

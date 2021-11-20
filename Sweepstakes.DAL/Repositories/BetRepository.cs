using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class BetRepository : AbstractCRUDRepository<Bet>, IBetRepository
    {
        public BetRepository(string conection) : base(conection) { }
    }
}

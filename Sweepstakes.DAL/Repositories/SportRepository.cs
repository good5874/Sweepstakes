using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class SportRepository : AbstractCRUDRepository<Sport>, ISportRepository
    {
        public SportRepository(string conection) : base(conection) { }
    }
}

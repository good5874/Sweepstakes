using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class CurrencyRepository : AbstractCRUDRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(string conection) : base(conection) { }
    }
}

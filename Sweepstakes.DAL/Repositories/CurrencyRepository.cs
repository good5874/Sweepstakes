using Microsoft.Extensions.Configuration;
using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class CurrencyRepository : AbstractCRUDRepository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(IConfiguration configuration) : base(configuration) { }
    }
}

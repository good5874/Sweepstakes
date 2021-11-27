using Microsoft.Extensions.Configuration;
using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class EventRepository : AbstractCRUDRepository<Event>, IEventRepository
    {
        public EventRepository(IConfiguration configuration) : base(configuration) { }
    }
}

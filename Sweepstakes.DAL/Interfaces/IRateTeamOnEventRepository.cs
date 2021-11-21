using Sweepstakes.Common.Models;
using System.Collections.Generic;

namespace Sweepstakes.DAL.Interfaces
{
    public interface IRateTeamOnEventRepository
    {
        IEnumerable<RateTeamOnEvent> GetAll();
        RateTeamOnEvent Get(int eventId, int teamId);
        void Create(RateTeamOnEvent item);
        void Delete(int eventId, int teamId);
        void Update(RateTeamOnEvent item);
    }
}

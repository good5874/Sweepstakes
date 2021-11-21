using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;
using System.Collections.Generic;

namespace Sweepstakes.DAL.Repositories
{
    public class RateTeamOnEventRepository : AbstractRepository<RateTeamOnEvent>, IRateTeamOnEventRepository
    {
        public RateTeamOnEventRepository(string conection) : base(conection) { }

        public void Create(RateTeamOnEvent item)
        {
            ExecuteScalarSqlQuery($"INSERT INTO RateTeamOnEvent VALUES ('{item.EventId}', '{item.TeamId}', '{item.Coefficient}')");
        }

        public void Delete(int eventId, int teamId)
        {
            ExecuteScalarSqlQuery($"DELETE FROM RateTeamOnEvent WHERE ((EventId = '{eventId}') AND (TeamId = '{teamId}')) ");
        }

        public RateTeamOnEvent Get(int eventId, int teamId)
        {
            return ExecuteScalarSqlQuery($"SELECT * FROM RateTeamOnEvent WHERE ((EventId = '{eventId}') AND (TeamId = '{teamId}'))");
        }

        public IEnumerable<RateTeamOnEvent> GetAll()
        {
            return ExecuteSqlQuery("SELECT * FROM RateTeamOnEvent");
        }

        public void Update(RateTeamOnEvent item)
        {
            ExecuteScalarSqlQuery($"UPDATE RateTeamOnEvent SET Coefficient = '{item.Coefficient}' WHERE ((EventId = '{item.EventId}') AND (TeamId = '{item.TeamId}'))");
        }
    }
}

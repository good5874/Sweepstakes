using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL
{
    public interface IUnitOfWork
    {
        IBetRepository Bet { get; }
        ICurrencyRepository Currency { get; }
        IEventRepository Event { get; }
        IRateTeamOnEventRepository RateTeamOnEvent { get; }
        IRoleRepository Role { get; }
        ISportRepository Sport { get; }
        ITeamRepository Team { get; }
    }
}

using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL
{
    public interface IUnitOfWork
    {
        IBetRepository Bet { get; }
    }
}

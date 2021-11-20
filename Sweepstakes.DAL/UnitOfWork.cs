using Sweepstakes.DAL.Interfaces;
using Sweepstakes.DAL.Repositories;

namespace Sweepstakes.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private BetRepository betRepository;

        public string Conection { get; private set; }

        public UnitOfWork(string Conection)
        {
            this.Conection = Conection;
        }

        public IBetRepository Bet
        {
            get
            {
                if (betRepository == null)
                    betRepository = new BetRepository(Conection);
                return betRepository;
            }
        }
    }
}

using Sweepstakes.DAL.Interfaces;
using Sweepstakes.DAL.Repositories;

namespace Sweepstakes.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private BetRepository betRepository;
        private CurrencyRepository currencyRepository;
        private EventRepository eventRepository;
        private RateTeamOnEventRepository rateTeamOnEventRepository;
        private RoleRepository roleRepository;
        private SportRepository sportRepository;

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
        
        public ICurrencyRepository Currency
        {
            get
            {
                if (currencyRepository == null)
                    currencyRepository = new CurrencyRepository(Conection);
                return currencyRepository;
            }
        }
        
        public IEventRepository Event
        {
            get
            {
                if (eventRepository == null)
                    eventRepository = new EventRepository(Conection);
                return eventRepository;
            }
        }
        
        public IRateTeamOnEventRepository RateTeamOnEvent
        {
            get
            {
                if (rateTeamOnEventRepository == null)
                    rateTeamOnEventRepository = new RateTeamOnEventRepository(Conection);
                return rateTeamOnEventRepository;
            }
        }
        
        public IRoleRepository Role
        {
            get
            {
                if (roleRepository == null)
                    roleRepository = new RoleRepository(Conection);
                return roleRepository;
            }
        }
        
        public ISportRepository Sport
        {
            get
            {
                if (sportRepository == null)
                    sportRepository = new SportRepository(Conection);
                return sportRepository;
            }
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sweepstakes.DAL.Interfaces;
using Sweepstakes.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes.DI
{
    public static class Startup
    {
        public static void DataAccessInitializer(this IServiceCollection services)
        {
            services.AddTransient<IBetRepository, BetRepository>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IRateTeamOnEventRepository, RateTeamOnEventRepository>();
            services.AddTransient<ISportRepository, SportRepository>();
            services.AddTransient<ITeamRepository, TeamRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}

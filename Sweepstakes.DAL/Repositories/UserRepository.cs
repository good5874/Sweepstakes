﻿using Sweepstakes.Common.Models;
using Sweepstakes.DAL.Abstracts;
using Sweepstakes.DAL.Interfaces;

namespace Sweepstakes.DAL.Repositories
{
    public class UserRepository : AbstractCRUDRepository<User>, IUserRepository
    {
        public UserRepository(string conection) : base(conection) { }
    }
}
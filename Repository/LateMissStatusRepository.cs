﻿using WatchMNS.Database;
using WatchMNS.Models;
using WatchMNS.Repository.Interfaces;

namespace WatchMNS.Repository
{
    public class LateMissStatusRepository : AbstractRepository<LateMissStatus>, ILateMissStatusRepository
    {
        public LateMissStatusRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}

﻿using WatchMNS.Database;
using WatchMNS.Models;

namespace WatchMNS.Repository
{
    public class LateMissStatusRepository : AbstractRepository<LateMissStatus>
    {
        public LateMissStatusRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }
    }
}
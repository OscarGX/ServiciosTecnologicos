﻿using Caamtroh.Repository.Infraestructure.Contract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caamtroh.Repository.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CaamtrohDataBaseEntities _dbContext;
        
        public UnitOfWork()
        {
            _dbContext = new CaamtrohDataBaseEntities();
        }

        public DbContext Db
        {
            get { return _dbContext; }
        }

        public void Dispose()
        {
        }
    }
}
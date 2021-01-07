﻿using eKarte.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace eKarte.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Spol = new SpolRepository(_db);
            TipOsoblja = new TipOsobljaRepository(_db);
            Osoblje = new OsobljeRepository(_db);
            Aerodrom = new AerodromRepository(_db);
            Drzava = new DrzavaRepository(_db);
            Grad = new GradRepository(_db);
        }

        public ISpolRepository Spol { get;  }

        public ITipOsobljaRepository TipOsoblja { get; private set; }

        public IOsobljeRepository Osoblje { get; private set; }
        public IAerodromRepository Aerodrom { get; private set; }
        public IDrzavaRepository Drzava { get; private set; }
        public IGradRepository Grad { get; private set; }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

﻿using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JamSesh.Context;

namespace JamSesh.Repositories
{
    public class Repository<T> where T : class
    {
        private DbContext db;
        private JamSeshContext context;

        public Repository(DbContext db)
        {
            this.db = db;
        }

        public Repository(JamSeshContext context)
        {
            this.context = context;
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Create(T entity)
        {
            db.Set<T>().Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
            Save();
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }    
}

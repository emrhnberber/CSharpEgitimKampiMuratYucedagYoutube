﻿using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositores
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        KampContext context = new KampContext();
        private readonly DbSet<T> _ojbect;

        public GenericRepository()
        {
            _ojbect=context.Set<T>();
        }
        public void Delete(T entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _ojbect.ToList();
        }

        public T GetById(int id)
        {
            return _ojbect.Find(id);
        }

        public void Insert(T entity)
        {
            var addedentity = context.Entry(entity);
            addedentity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
﻿using PaySin.DataAccessLayer.Abstract;
using PaySin.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySin.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var context=new Context();
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context= new Context();
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            using var context=new Context();
            return context.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            using var context = new Context();
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }
    }
}

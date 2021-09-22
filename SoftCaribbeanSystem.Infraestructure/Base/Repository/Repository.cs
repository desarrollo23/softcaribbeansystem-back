using SoftCaribbeanSystem.Infraestructure.Base.Context;
using SoftCaribbeanSystem.Model.Base.Entity;
using SoftCaribbeanSystem.Model.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftCaribbeanSystem.Infraestructure.Base.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private MyDbContext _myDbContext;


        public Repository(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public void Add(T entity)
        {
            _myDbContext.Add(entity);
            _myDbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = _myDbContext.Set<T>().FirstOrDefault(x => x.Id == id);

            if (entity != null)
            {
                _myDbContext.Remove(entity);
                _myDbContext.SaveChanges();
            }
        }

        public virtual IList<T> FindAll()
        {
            return _myDbContext.Set<T>().ToList();
        }

        public virtual T FindById(int id)
        {
            return _myDbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public virtual void Update(T entity)
        {
            _myDbContext.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _myDbContext.SaveChanges();
        }

        public virtual T FindBy(Func<T, bool> predicate)
        {
            return _myDbContext.Set<T>().FirstOrDefault(predicate);
        }
    }
}
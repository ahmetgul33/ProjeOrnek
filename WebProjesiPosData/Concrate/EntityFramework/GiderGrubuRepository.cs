using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using WebProjesiDataAccess.Models;
using WebProjesiPosData.Abstract;

namespace WebProjesiPosData.Concrate.EntityFramework
{
    public class GiderGrubuRepository : IGiderGrubuRepository
    {
        protected readonly WebContext DbContext;
        protected readonly DbSet<GiderGrubu> DbSet;

        public GiderGrubuRepository (WebContext dbContect)
        {
           this.DbContext = dbContect;
        }
        public void Add(GiderGrubu entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Added;
            this.DbContext.Set<GiderGrubu>().Add(entity);
            this.Save();
        }

        public void Delete(GiderGrubu entity)
        {
            this.DbContext.Entry(entity).State = EntityState.Deleted;
            this.Save();
        }

        public GiderGrubu Get(Expression<Func<GiderGrubu, bool>> filter )
        {
            return this.DbContext.GiderGrubu.SingleOrDefault(filter);

        }

        public IEnumerable<GiderGrubu> GetAll(Expression<Func<GiderGrubu, bool>> filter)
        {
            //return DbSet.Where(filter).ToList();

            return filter == null
                  ? DbContext.Set<GiderGrubu>().ToList()
                  : DbContext.Set<GiderGrubu>().Where(filter).ToList();
        }

        public void Save()
        {
            this.DbContext.SaveChanges();
        }

        public void Update(GiderGrubu entity)
        {
            throw new NotImplementedException();
        }
    }
}

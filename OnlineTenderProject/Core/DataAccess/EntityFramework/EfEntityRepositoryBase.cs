using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TDataContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TDataContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (var context = new TDataContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TDataContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using(var context=new TDataContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TDataContext())
            {
                return filter == null
                    ? context.Set<IEntity>().ToList();
                    :context.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TDataContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

using Company.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Company.Core.DataAccess.EntityFramework
{
    /// <summary>
    /// Represents an entity repository
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public class EfEntityReporsitoryBase<TEntity, TContext> : IEntityReporsitoryBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        /// <summary>
        /// Adds the given entity to the database using entity framework core.
        /// </summary>
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Mark the IsDeleted field of the given entity correctly in the database using entity framework core.
        /// </summary>
        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                entity.IsDeleted = true;
                deleteEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Returns a single record of the given entity from the database using entity framework core.
        /// </summary>
        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        /// <summary>
        /// Returns the list record of the given entity from the database using entity framework core.
        /// </summary>
        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        /// <summary>
        /// Removes the given entity from the database using entity framework core.
        /// </summary>
        public void Remove(TEntity entity)
        {
            using (var context = new TContext())
            {
                var removeEntity = context.Entry(entity);
                removeEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Updates the given entity in the database using entity framework core.
        /// </summary>
        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

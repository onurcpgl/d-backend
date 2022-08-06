using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        
    {
        protected readonly DbContext _divanDataContext;

        public EfEntityRepositoryBase(DbContext dbContext)
        {
            _divanDataContext = dbContext;
        }
        public void Add(TEntity entity)
        {
            
                var addedEntity = _divanDataContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                _divanDataContext.SaveChanges();
            
        }

        public void Delete(TEntity entity)
        {
           
                var deletedEntity = _divanDataContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                _divanDataContext.SaveChanges();
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

           
                return _divanDataContext.Set<TEntity>().SingleOrDefault(filter);

            
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _divanDataContext.Set<TEntity>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties.Any())
            {
                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }
            }
            return  query.ToList();  
        }

        public void Update(TEntity entity)
        {
            
                var upadatedEntity = _divanDataContext.Entry(entity);
                upadatedEntity.State = EntityState.Modified;
                _divanDataContext.SaveChanges();
            
        }
    }
}

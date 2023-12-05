using Microsoft.EntityFrameworkCore;
using OddiyBlogSayt.Domain.Common;
using OddiyBlogSayt.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OddiyBlogSayt.Persistence.Repositories
{
    public abstract class EntityRepositoryBase<TEntity, TContext> where TEntity : class, IEntity where TContext : BlogPostDbContext
    {
        private readonly BlogPostDbContext _blogPostDbContext;
        
        protected TContext BlogPostDbContext => (TContext) _blogPostDbContext;

        public EntityRepositoryBase(BlogPostDbContext blogPostDbContext)
        {
            _blogPostDbContext = blogPostDbContext;
        }

        protected IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false)
        {
            var initialQuery = _blogPostDbContext.Set<TEntity>().Where(entity => true);

            if(predicate != null)
                initialQuery = initialQuery.Where(predicate);

            if (asNoTracking)
                initialQuery = initialQuery.AsNoTracking();

            return initialQuery;
        }   

        protected ValueTask<TEntity> GetByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
        {
            if (asNoTracking)
                return new(_blogPostDbContext.Set<TEntity>()
                    .AsNoTracking()
                    .FirstOrDefaultAsync(entity => entity.Id == id, cancellationToken: cancellationToken));

            return _blogPostDbContext.Set<TEntity>().FindAsync();
        }

        protected ValueTask<ICollection<TEntity>> GetByIdAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            var initialQuery = _blogPostDbContext.Set<TEntity>().Where(entity => true);

            if (asNoTracking)
                initialQuery = initialQuery.AsNoTracking();

            return new(initialQuery.Where(entity => ids.Contains(entity.Id)).ToList());
        }

        protected async ValueTask<TEntity> CreateAsync(TEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            _blogPostDbContext.Add(entity);

            if(saveChanges)
                await _blogPostDbContext.SaveChangesAsync(cancellationToken);

            return entity;
        }

        protected async ValueTask<TEntity> UpdateAsync(TEntity entity, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            _blogPostDbContext.Set<TEntity>().Update(entity);

            if (saveChanges)
                await _blogPostDbContext.SaveChangesAsync(cancellationToken: cancellationToken);

            return entity;
        }


    }
}

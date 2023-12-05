using OddiyBlogSayt.Domain.Entities;
using OddiyBlogSayt.Persistence.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OddiyBlogSayt.Persistence.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public ValueTask<Blog> CreateAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Blog> DeleteAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Blog> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Blog> Get(Expression<Func<Blog, bool>> predicate, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ICollection<Blog>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Blog> GetByIdAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Blog> UpdateAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }
    }
}

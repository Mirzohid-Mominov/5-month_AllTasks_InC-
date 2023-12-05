using OddiyBlogSayt.Application.Common.Identity.Services;
using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;

namespace OddiyBlogSayt.Infrastructure.Common.Identity.Services
{
    public class BlogService : IBlogService
    {
        public ValueTask<Blog> CreateAsync(Blog blog, bool asNoTracking = false, CancellationToken cancellationToken = default)
        {

        }

        public ValueTask<Blog> DeleteAsync(Blog blog, bool asNoTracking = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Blog> DeleteByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
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

        public ValueTask<Blog> GetByIdAsync(Blog id, bool asNoTracking = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Blog> UpdateAsync(Blog blog, bool asNoTracking = false, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}

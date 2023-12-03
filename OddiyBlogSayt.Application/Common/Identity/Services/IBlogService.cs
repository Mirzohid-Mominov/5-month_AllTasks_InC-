using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;

namespace OddiyBlogSayt.Application.Common.Identity.Services;

public interface IBlogService
{
    IQueryable<Blog> Get(Expression<Func<Blog, bool>> predicate, bool asNoTracking =  false);

    ValueTask<ICollection<Blog>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Blog> GetByIdAsync(Blog id, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Blog> CreateAsync(Blog blog, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Blog> UpdateAsync(Blog blog, bool asNoTracking = false, CancellationToken cancellationToken= default);

    ValueTask<Blog> DeleteAsync(Blog blog, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Blog> DeleteByIdAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default);
}

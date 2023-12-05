using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;

namespace OddiyBlogSayt.Persistence.Repositories.Interface;

public interface IBlogRepository
{
    IQueryable<Blog> Get(Expression<Func<Blog, bool>> predicate, bool asNoTracking = false);

    ValueTask<ICollection<Blog>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Blog> GetByIdAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false);

    ValueTask<Blog> CreateAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false);

    ValueTask<Blog> UpdateAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false);

    ValueTask<Blog> DeleteAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false);

    ValueTask<Blog> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default, bool asNoTracking = false);
}

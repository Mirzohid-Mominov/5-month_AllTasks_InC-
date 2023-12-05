using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;
namespace OddiyBlogSayt.Persistence.Repositories.Interface;

public interface ICommentRepository
{
    IQueryable<Comment> Get(Expression<Func<Comment, bool>> predicate, bool asNoTracking = false);

    ValueTask<ICollection<Comment>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Comment> GetByIdAsync(Comment comment, bool asNoTracking = false, CancellationToken cancellationToken = default);

    ValueTask<Comment> CreateAsync(Comment comment, CancellationToken cancellationToken = default, bool asNoTracking = false);

    ValueTask<Comment> UpdateAsync(Comment comment, CancellationToken cancellationToken, bool asNoTracking = false);

    ValueTask<Comment> DeleteAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false);

    ValueTask<Comment> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default, bool asNoTracking = false);
}

  
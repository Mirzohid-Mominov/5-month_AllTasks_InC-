using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;

namespace OddiyBlogSayt.Application.Common.Identity.Services;

public interface ICommentService
{
    IQueryable<Comment> Get(Expression<Func<Comment, bool>> predicate, bool asNoTracking = false);

    ValueTask<ICollection<Comment>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellation = default);

    ValueTask<Comment> GetByIdAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false);

    ValueTask<Comment> CreateAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false);

    ValueTask<Comment> UpdateAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false);

    ValueTask<Comment> DeleteAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false);

    ValueTask<Comment> DeleteByIdAsync(Guid id, CancellationToken cancellation = default, bool asNoTracking = false);
}

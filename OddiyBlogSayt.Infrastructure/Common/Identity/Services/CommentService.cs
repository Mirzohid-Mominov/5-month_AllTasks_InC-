using OddiyBlogSayt.Application.Common.Identity.Services;
using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;

namespace OddiyBlogSayt.Infrastructure.Common.Identity.Services
{
    public class CommentService : ICommentService
    {
        public ValueTask<Comment> CreateAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Comment> DeleteAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Comment> DeleteByIdAsync(Guid id, CancellationToken cancellation = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Comment> Get(Expression<Func<Comment, bool>> predicate, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<ICollection<Comment>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellation = default)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Comment> GetByIdAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Comment> UpdateAsync(Comment comment, CancellationToken cancellation = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }
    }
}

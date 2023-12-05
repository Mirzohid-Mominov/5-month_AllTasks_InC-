using OddiyBlogSayt.Domain.Entities;
using OddiyBlogSayt.Persistence.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OddiyBlogSayt.Persistence.Repositories;

public class CommentRepository : ICommentRepository
{
    public ValueTask<Comment> CreateAsync(Comment comment, CancellationToken cancellationToken = default, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Comment> DeleteAsync(Blog blog, CancellationToken cancellationToken = default, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Comment> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Comment> Get(Expression<Func<Comment, bool>> predicate, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ICollection<Comment>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Comment> GetByIdAsync(Comment comment, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<Comment> UpdateAsync(Comment comment, CancellationToken cancellationToken, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }
}

using OddiyBlogSayt.Domain.Entities;
using OddiyBlogSayt.Persistence.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OddiyBlogSayt.Persistence.Repositories;

public class UserRepository : EntityRepositoryBase
{
    public ValueTask<User> CreateAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> DeletByIdeAsync(Guid id, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> DeleteAsync(User user, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> Get(Expression<Func<User, bool>> predicate, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<ICollection<User>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> GetByIdAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> UpdateAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false)
    {
        throw new NotImplementedException();
    }
}

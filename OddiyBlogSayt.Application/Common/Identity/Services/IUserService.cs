using OddiyBlogSayt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OddiyBlogSayt.Application.Common.Identity.Services
{
    public interface IUserService
    {
        IQueryable<User> Get(Expression<Func<User, bool>> predicate, bool asNoTracking = false);

        ValueTask<ICollection<User>> GetByIdAsync(IEnumerable<Guid> ids, bool asNoTracking = false, CancellationToken cancellationToken = default);

        ValueTask<User> GetByIdAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false);

        ValueTask<User> CreateAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false);

        ValueTask<User> UpdateAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false);

        ValueTask<User> DeleteAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false);

        ValueTask<User> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default, bool asNoTracking = false);
    }
}

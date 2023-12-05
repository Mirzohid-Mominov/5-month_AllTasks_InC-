using OddiyBlogSayt.Application.Common.Identity.Services;
using OddiyBlogSayt.Domain.Entities;
using System.Linq.Expressions;

namespace OddiyBlogSayt.Infrastructure.Common.Identity.Services
{
    public class UserService : IUserService
    {
        public ValueTask<User> CreateAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> DeleteAsync(User user, CancellationToken cancellationToken = default, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public ValueTask<User> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default, bool asNoTracking = false)
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
}

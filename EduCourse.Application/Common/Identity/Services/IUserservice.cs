using EduCourse.Domain.Entities;
using System.Linq.Expressions;

namespace EduCourse.Application.Common.Identity.Services;

public interface IUserservice
{
    IQueryable<User> Get(Expression<Func<User, bool>>? predicate = null);

    ValueTask<User?> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);

    ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<User> DeleteAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default);

    ValueTask<User> DeleteByIdAsync(Guid userId, bool saveChanges = true, CancellationToken cancellationToken = default);

}

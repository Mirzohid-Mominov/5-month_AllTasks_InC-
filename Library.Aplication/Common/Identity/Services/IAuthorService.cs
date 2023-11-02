using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.Common.Identity.Services
{
    public interface IAuthorService
    {
        IQueryable<Author> Get(Expression<Func<Author, bool>>? predicate = null);

        ValueTask<Author?> GetByIdAsync(Guid authorId, CancellationToken cancellationToken = default);

        ValueTask<Author> CreateAsync(Author author, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<Author> UpdateAsync(Author author, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<Author> DeleteAsync(Author author, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<Author> DeleteByIdAsync(Guid authorId, bool saveChanges = true, CancellationToken cancellationToken = default);
    }
}

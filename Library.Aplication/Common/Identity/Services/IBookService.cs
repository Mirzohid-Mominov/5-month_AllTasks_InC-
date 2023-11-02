using Library.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Aplication.Common.Identity.Services
{
    public interface IBookService
    {
        IQueryable<Book> Get(Expression<Func<Book, bool>>? predicate = null);

        ValueTask<Book?> GetByIdAsync(Guid bookId, CancellationToken cancellationToken = default);

        ValueTask<Book> CreateAsync(Book book, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<Book> UpdateAsync(Book book, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<Book> DeleteAsync(Book book, bool saveChanges = true, CancellationToken cancellationToken = default);

        ValueTask<Book> DeleteByIdAsync(Guid bookId, bool saveChanges = true, CancellationToken cancellationToken = default);
    }
}

using Library.Aplication.Common.Identity.Services;
using Library.Domain.Entities;
using Library.Persistence.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Common.Identity.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _appDbContext;

        public BookService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Book> Get(Expression<Func<Book, bool>>? predicate = null) =>
            predicate != null ? _appDbContext.Books.Where(predicate) : _appDbContext.Books;
        
        public ValueTask<Book?> GetByIdAsync(Guid bookId, CancellationToken cancellationToken = default)
        {
            return _appDbContext.Books.FindAsync(bookId);
        }

        public async ValueTask<Book> CreateAsync(Book book, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            await _appDbContext.Books.AddAsync(book, cancellationToken);

            if (saveChanges)
                await _appDbContext.SaveChangesAsync(cancellationToken);

            return book;
        }
        
        public async ValueTask<Book> UpdateAsync(Book book, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            _appDbContext.Books.Update(book);

            if (saveChanges)
                await _appDbContext.SaveChangesAsync(cancellationToken);

            return book;
        }
            
        public async ValueTask<Book> DeleteAsync(Book book, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            _appDbContext.Books.Remove(book);

            if (saveChanges)
                await _appDbContext.SaveChangesAsync(cancellationToken);

            return book;
        }

        public async ValueTask<Book> DeleteByIdAsync(Guid bookId, bool saveChanges = true, CancellationToken cancellationToken = default)
        {
            var foundBook =  _appDbContext.Books.Find(bookId);

            if (foundBook is null)
                throw new InvalidOperationException($"Book with id {bookId} not found");

            _appDbContext.Books.Remove(foundBook);

            if (saveChanges)
                await _appDbContext.SaveChangesAsync(cancellationToken);

            return foundBook;
        }
    }
}

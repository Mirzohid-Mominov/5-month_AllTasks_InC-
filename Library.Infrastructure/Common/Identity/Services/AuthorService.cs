using Library.Aplication.Common.Identity.Services;
using Library.Domain.Entities;
using Library.Persistence.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Common.Identity.Services;

public class AuthorService : IAuthorService
{
    private readonly AppDbContext _appDbContext;

    public AuthorService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IQueryable<Author> Get(Expression<Func<Author, bool>>? predicate = null) =>
        predicate != null ? _appDbContext.Authors.Where(predicate) : _appDbContext.Authors;

    public ValueTask<Author?> GetByIdAsync(Guid authorId, CancellationToken cancellationToken = default)
    {
        return _appDbContext.Authors.FindAsync(authorId);
    }
    
    public async ValueTask<Author> CreateAsync(Author author, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        await _appDbContext.Authors.AddAsync(author, cancellationToken);

        await _appDbContext.SaveChangesAsync();

        return author;
    }
    
    public async ValueTask<Author> UpdateAsync(Author author, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        _appDbContext.Authors.Update(author);

        if (saveChanges)
            await _appDbContext.SaveChangesAsync(cancellationToken);    

        return author;
    }

    public async ValueTask<Author> DeleteAsync(Author author, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        _appDbContext.Authors.Remove(author);

        if (saveChanges)
            await _appDbContext.SaveChangesAsync(cancellationToken);

        return author;
    }

    public async ValueTask<Author> DeleteByIdAsync(Guid authorId, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        var foundAuthor = _appDbContext.Authors.Find(authorId);

        if (foundAuthor is null)
            throw new InvalidOperationException($"Author with id {authorId} not found");

        _appDbContext.Authors.Remove(foundAuthor);

        if (saveChanges)
            await _appDbContext.SaveChangesAsync(cancellationToken);

        return foundAuthor;
    }
}

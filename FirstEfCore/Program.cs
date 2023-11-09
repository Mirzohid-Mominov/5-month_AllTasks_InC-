using ConsoleApp2.Domain.Entities;
using ConsoleApp2.Persistence.DataContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddDbContext<AppDbContext>();

var serviceProvider = services.BuildServiceProvider();

var appDbContext = serviceProvider.GetRequiredService<AppDbContext>();

if(appDbContext.Authors.Any())
{
    appDbContext.Authors.AddRange(new Author
    {
        FirstName = "John",
        LastName = "Doe"
    },
    new Author
    {
        FirstName = "Jonibek",
        LastName = "Hoshimov"
    });
    
    var changesRowsCount = await appDbContext.SaveChangesAsync();
}

if(appDbContext.Authors.Any() && !appDbContext.Books.Any())
{
    appDbContext.Books.AddRange(new Book
    {
        Title = "Asp.NET Core in Action 2018",
        Description = "Programming",
        AuthorId = appDbContext.Authors.First().Id
    },
    new Book
    {
        Title = "Asp.NET Core in Action 2021",
        Description = "Programming",
        AuthorId = appDbContext.Authors.Skip(1).First().Id
    });

    var changedRowsCount = await appDbContext.SaveChangesAsync ();
}

var sameBookA = await appDbContext.Books.FirstAsync(book => book.Id.Equals(Guid.Parse("393f9c34-10fa-4184-84bc-73eb55b339bf")));

sameBookA.Title = "Test upgrade";

appDbContext.Update(sameBookA);

var sameBookB = await appDbContext.Books.FirstAsync(book => book.Id.Equals(Guid.Parse("393f9c34-10fa-4184-84bc-73eb55b339bf")));


Console.WriteLine();

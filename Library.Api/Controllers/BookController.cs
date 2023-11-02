using Library.Aplication.Common.Identity.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService _bookService;

    public BookController(IBookService bookService)
    {
        _bookService = bookService;
    }

    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        var data = await _bookService.Get().ToListAsync();
        return data.Any() ? Ok(data) : NotFound();    
    }

    [HttpGet("{bookId:guid}")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid bookId)
    {
        var data = await _bookService.GetByIdAsync(bookId);
        return data != null ? Ok(data) : NotFound();
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync([FromBody] Book book)
    {
        var createdBook = await _bookService.CreateAsync(book);

        return CreatedAtAction(nameof(GetById),
            new
            {
                bookId = createdBook.Id
            },
            createdBook);
    }

    [HttpPut]
    public async ValueTask<IActionResult> Update([FromBody] Book book)
    {
        await _bookService.UpdateAsync(book);
        return Ok();
    }

    [HttpDelete]
    public async ValueTask<IActionResult> Delete([FromRoute] Guid bookId)
    {
        await _bookService.DeleteByIdAsync(bookId);
        return Ok();
    }
}

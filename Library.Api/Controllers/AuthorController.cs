using Library.Aplication.Common.Identity.Services;
using Library.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthorController : ControllerBase
{
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
        _authorService = authorService;
    }

    [HttpGet]
    public async ValueTask<IActionResult> get()
    {
        var data = await _authorService.Get().ToListAsync();
        return data.Any() ? Ok(data) : NotFound();
    }

    [HttpGet("authorId:guid")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid authorId)
    {
        var data = await _authorService.GetByIdAsync(authorId);
        return data != null ? Ok(data) : NotFound();
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync([FromBody] Author author)
    {
        var createdAuthor = await _authorService.CreateAsync(author);

        return CreatedAtAction(nameof(GetById),
            new
            {
                authorId = createdAuthor.Id
            },
            createdAuthor);
    }


    [HttpPut]
    public async ValueTask<IActionResult> Update([FromBody] Author author)
    {
        await _authorService.UpdateAsync(author);
        return Ok();
    }

    [HttpDelete("{authorId:guid}")]
    public async ValueTask<IActionResult> Delete([FromRoute] Guid auhtorId)
    {
        await _authorService.DeleteByIdAsync(auhtorId);
        return Ok();
    }
}

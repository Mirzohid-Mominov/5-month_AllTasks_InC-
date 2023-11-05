using EduCourse.Application.Common.Identity.Services;
using EduCourse.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace N67.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserservice _userService;

    public UsersController(IUserservice userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async ValueTask<IActionResult> Get()
    {
        var users = await _userService.Get().ToListAsync();
        return users.Any() ? Ok(users) : NotFound();
    }

    [HttpGet("{userId:guid}")]
    public async ValueTask<IActionResult> GetById([FromRoute] Guid userId)
    {
        var user = await _userService.GetByIdAsync(userId);
        return user != null ? Ok(user) : NotFound();
    }

    [HttpPost]
    public async ValueTask<IActionResult> CreateAsync([FromBody] User user)
    {
        var createdUser = await _userService.CreateAsync(user);
        return CreatedAtAction(nameof(GetById),
            new
            {
                userId = createdUser.Id
            },
            createdUser);
    }

    [HttpPut]
    public async ValueTask<IActionResult> Update([FromBody] User user)
    {
        await _userService.UpdateAsync(user);
        return Ok();
    }

    [HttpDelete("{userId:guid}")]
    public async ValueTask<IActionResult> Delete([FromRoute] Guid userId)
    {
        await _userService.DeleteByIdAsync(userId);
        return Ok();
    }
}
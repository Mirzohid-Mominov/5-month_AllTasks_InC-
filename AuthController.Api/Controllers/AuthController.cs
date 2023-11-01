using AuthController.Api.Models;
using AuthController.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthController.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly TokenGeneratorService _tokenGeneratorService;

    public AuthController(TokenGeneratorService tokenGeneratorService)
    {
        _tokenGeneratorService = tokenGeneratorService;
    }

    [HttpPost]
    public IActionResult Login([FromBody] LoginDetails loginDetails)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            EmailAddress = loginDetails.EmailAddress,
            Password = loginDetails.Password
        };

        var data = _tokenGeneratorService.GetToken(user);
        return Ok(data);
    }
}

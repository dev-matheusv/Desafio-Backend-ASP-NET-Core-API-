using DesafioKognit.Models;
using DesafioKognit.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioKognit.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody] User user)
    {
        await _userService.AddUserAsync(user);
        return Ok("User added successfully.");
    }
}
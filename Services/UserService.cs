using DesafioKognit.Models;
using DesafioKognit.Repositories.Interfaces;
using DesafioKognit.Services.Interfaces;

namespace DesafioKognit.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task AddUserAsync(User user)
    {
        await _userRepository.AddUserAsync(user);
    }
}
using DesafioKognit.Models;

namespace DesafioKognit.Services.Interfaces;

public interface IUserService
{
    Task AddUserAsync(User user);
}
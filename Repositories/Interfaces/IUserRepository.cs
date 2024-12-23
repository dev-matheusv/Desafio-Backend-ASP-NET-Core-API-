using DesafioKognit.Data;
using DesafioKognit.Models;

namespace DesafioKognit.Repositories.Interfaces;

public interface IUserRepository
{
    Task AddUserAsync(User user);
}

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _context;

    public UserRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}
using DesafioKognit.Data;
using DesafioKognit.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioKognit.Repositories.Interfaces;

public interface IWalletRepository
{
    Task AddWalletAsync(Wallet wallet);
    Task<List<Wallet>> GetWalletsByUserIdAsync(int userId);
}

public class WalletRepository : IWalletRepository
{
    private readonly AppDbContext _context;

    public WalletRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddWalletAsync(Wallet wallet)
    {
        _context.Wallets.Add(wallet);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Wallet>> GetWalletsByUserIdAsync(int userId)
    {
        return await _context.Wallets.Where(w => w.UserID == userId).ToListAsync();
    }
}
using DesafioKognit.Models;

namespace DesafioKognit.Services.Interfaces;

public interface IWalletService
{
    Task AddWalletAsync(Wallet wallet);
    Task<List<Wallet>> GetWalletsByUserIdAsync(int userId);
}
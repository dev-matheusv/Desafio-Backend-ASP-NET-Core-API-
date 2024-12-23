using DesafioKognit.Models;
using DesafioKognit.Repositories.Interfaces;
using DesafioKognit.Services.Interfaces;

namespace DesafioKognit.Services;

public class WalletService : IWalletService
{
    private readonly IWalletRepository _walletRepository;

    public WalletService(IWalletRepository walletRepository)
    {
        _walletRepository = walletRepository;
    }

    public async Task AddWalletAsync(Wallet wallet)
    {
        wallet.UltimaAtualizacao = DateTime.UtcNow;
        await _walletRepository.AddWalletAsync(wallet);
    }

    public async Task<List<Wallet>> GetWalletsByUserIdAsync(int userId)
    {
        return await _walletRepository.GetWalletsByUserIdAsync(userId);
    }
}
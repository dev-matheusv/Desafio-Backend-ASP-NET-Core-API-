using DesafioKognit.Models;
using DesafioKognit.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioKognit.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WalletController : ControllerBase
{
    private readonly IWalletService _walletService;

    public WalletController(IWalletService walletService)
    {
        _walletService = walletService;
    }

    [HttpPost]
    public async Task<IActionResult> AddWallet([FromBody] Wallet wallet)
    {
        await _walletService.AddWalletAsync(wallet);
        return Ok("Wallet added successfully.");
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetWallets(int userId)
    {
        var wallets = await _walletService.GetWalletsByUserIdAsync(userId);
        return Ok(wallets);
    }
}
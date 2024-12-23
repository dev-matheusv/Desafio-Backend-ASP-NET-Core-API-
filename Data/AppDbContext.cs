using System.Reflection;
using DesafioKognit.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioKognit.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Wallet> Wallets { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(u => u.ID);
        modelBuilder.Entity<User>()
            .Property(u => u.Nascimento)
            .HasColumnType("date"); // Para garantir que o banco de dados armazene apenas a data
        
        modelBuilder.Entity<Wallet>().HasKey(w => w.ID);
        modelBuilder.Entity<Wallet>()
            .HasOne<User>()
            .WithMany()
            .HasForeignKey(w => w.UserID);
        modelBuilder.Entity<Wallet>()
            .Property(w => w.ValorAtual)
            .HasColumnType("decimal(18,2)");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
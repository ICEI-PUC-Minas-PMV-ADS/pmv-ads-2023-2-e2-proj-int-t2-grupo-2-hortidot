using HortiDot.Models;
using Microsoft.EntityFrameworkCore;

namespace HortiDot.Config
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }
        
        public DbSet<Fornecedor> fornecedores { get; set; }

        public DbSet<Comprador> compradores { get; set; }

        public DbSet<Cotacao> cotacoes { get; set; }

    }
}

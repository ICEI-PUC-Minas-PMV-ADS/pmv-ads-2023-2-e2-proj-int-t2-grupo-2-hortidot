using HortiDot.Models;
using Microsoft.EntityFrameworkCore;

namespace HortiDot.Config
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base(options) { }
        
        public DbSet<Fornecedor> fornecedores { get; set; }
    }
}

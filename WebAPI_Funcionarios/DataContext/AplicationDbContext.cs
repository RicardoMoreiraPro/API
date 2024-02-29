using Microsoft.EntityFrameworkCore;
using WebAPI_Funcionarios.Models;

namespace WebAPI_Funcionarios.DataContext
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}

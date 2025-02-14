using Microsoft.EntityFrameworkCore;
using ProvaPratica.Entities;

namespace ProvaPratica.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FuncionarioDB;ConnectRetryCount=0");
        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }

    }
}

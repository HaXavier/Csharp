using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    // Entity Framework Code First
    // Classe que define a estrutura do banco de dados
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        // Definir quais as classes serviram para as tabelas no banco de dados
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
using System;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program    {
        static void Main(string[] args)
        {
            //using var db = new Data.ApplicationContext();
            
            //db.Database.Migrate(); //Indicada apenas para usar em desenvolvimento, não em produção
            
            Console.WriteLine("Hello, World!");
        }
    }
}


/* Para testar a conexão com o LocalDb - dotnet run

using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using var context = new MeuDbContext();

            try
            {
                // Tenta abrir uma conexão com o banco de dados
                await context.Database.CanConnectAsync();
                Console.WriteLine("Conexão com o banco de dados bem-sucedida!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Falha ao conectar com o banco de dados: {ex.Message}");
            }
        }
    }

    public class MeuDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Substitua pela sua string de conexão
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CursoEFCore;Trusted_Connection=True;");
        }
    }
}*/
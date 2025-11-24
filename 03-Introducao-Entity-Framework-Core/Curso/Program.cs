using Microsoft.EntityFrameworkCore;

namespace CursoEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db =  new Data.ApplicationContext();
            
            // para verificar se existe Migração pendente
            var existe = db.Database.GetPendingMigrations().Any();
            if (existe)
            {
                // aplicação da regra de negócio
            }
            Console.WriteLine("Hello, World!");                
        }        
    }
}

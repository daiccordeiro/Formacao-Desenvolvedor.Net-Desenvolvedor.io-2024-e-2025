using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class TesteEFController : Controller
    {
        // propriedade para acessar o contexto do banco de dados    
        public AppDbContext Db { get; set; }

        // criando a instância do AppDbContext através da injeção de dependência
        public TesteEFController(AppDbContext db)
        {
            Db = db;
        }   

        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Daiane",
                Email = "hello@daiane.com",
                DataNascimento = new DateTime(1989, 10, 23),
                Avaliacao = 8,
                Ativo = true
            };

            // Adicionando o aluno ao contexto e salvando as alterações no banco de dados   
            Db.Alunos.Add(aluno);
            Db.SaveChanges();


            // Buscando os alunos no Db e ATUALIZANDO o aluno com o nome "Daiane" para "Daiane Cordeiro"
            var alunosChange = Db.Alunos.Where(a => a.Nome == "Daiane").FirstOrDefault();
            alunosChange.Nome = "Daiane Cordeiro";

            Db.Alunos.Update(alunosChange);
            Db.SaveChanges();


            // Buscando os alunos no Db e EXCLUINDO o aluno com o nome "Daiane"
            //var alunosChange = Db.Alunos.Where(a => a.Nome.Contains("Daiane")).FirstOrDefault(); 
            Db.Alunos.Remove(alunosChange); 
            Db.SaveChanges(); 

            return View();
        }
    }
}

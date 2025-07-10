using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class ModelsController: Controller

    {
        public IActionResult Index()
        {
            //var aluno new Aluno();
            var aluno =  new Aluno()
            {
                Nome = "A",
                Email = "Daiane",
                EmailConfirmacao = "daiccordeiro.com"
            };
            
            if (TryValidateModel(aluno))
            {
                return View(aluno);
            }

            var ms = ModelState;

            // Trazendo uma lista com os erros 
            var erros = ModelState.Select(x => x.Value.Errors)
                                        .Where(y => y.Count > 0)
                                        .ToList();

            erros.ForEach(r => Console.WriteLine(r.First().ErrorMessage));

            return View();
        }
    }
}

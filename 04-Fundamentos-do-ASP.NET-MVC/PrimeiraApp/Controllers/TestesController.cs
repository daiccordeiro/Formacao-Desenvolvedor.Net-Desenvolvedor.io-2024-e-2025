using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;

namespace PrimeiraApp.Controllers
{
    [Route("/", Order = 0)] // Transformando em raiz (padrão) da página
    [Route("minha-conta", Order = 1)]
    [Route("gestao-da-conta", Order = 2)]
    public class TestesController : Controller
    {
        // GET: /Home
        //[Route("inicio")] - a Index não tem rota, é a 1ª a ser chamada
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Details
        [HttpGet("detalhes/{id:int}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        // Método GET/POST passar a mesma rota - "novo"
        // GET: /Create
        [HttpGet("novo")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Create
        [HttpPost("novo")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: /Edit
        [HttpGet("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: /Edit
        [HttpPost("detalhes/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: /Delete
        [HttpGet("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: /Delete
        [HttpPost("excluir/{id:int}")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

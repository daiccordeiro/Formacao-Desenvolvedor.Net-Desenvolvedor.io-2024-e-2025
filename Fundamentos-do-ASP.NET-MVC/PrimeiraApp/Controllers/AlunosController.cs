using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrimeiraApp.Data;
using PrimeiraApp.Models;

namespace PrimeiraApp.Controllers
{
    public class AlunosController : Controller
    {
        // Contexto do banco de dados para acessar os dados dos alunos  
        private readonly AppDbContext _context;

        // Construtor para injetar o AppDbContext  
        public AlunosController(AppDbContext context)
        {
            _context = context;
        }

        // Trazendo a lista de alunos do banco de dados e exibindo na view INDEX (de forma assincrona)
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.ToListAsync());
        }

        // GET: Alunos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken] // Garante que o envio do formulário seja seguro
        public async Task <IActionResult> Create([Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao,Ativo")]Aluno aluno)
        {
            _context.Alunos.Add(aluno); // Adiciona o aluno ao contexto do banco de dados
            await _context.SaveChangesAsync(); // Salva alterações no banco de dados
            return RedirectToAction(nameof(Index)); // Redireciona para a ação INDEX após a criação
        }


        // GET: Alunos/Details
        public async Task<IActionResult> Details(int id)
        {            
            var aluno = await _context.Alunos.FirstOrDefaultAsync(m => m.Id == id);
            return View(aluno);
        }


        // GET: Alunos/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            return View(aluno);
        }

        // POST: Alunos/Edit
        [HttpPost]
        [ValidateAntiForgeryToken] // Garante que o envio do formulário seja seguro
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao,Ativo")] Aluno aluno)
        {
            _context.Update(aluno); 
            await _context.SaveChangesAsync(); 
            return RedirectToAction(nameof(Index)); 
        }

    }
}

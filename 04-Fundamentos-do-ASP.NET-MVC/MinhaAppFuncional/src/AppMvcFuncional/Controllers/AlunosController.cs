﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppMvcFuncional.Data;
using AppMvcFuncional.Models;
using Microsoft.AspNetCore.Authorization;

namespace AppMvcFuncional.Controllers
{
    [Authorize]
    [Route("meus-alunos")]
    public class AlunosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AlunosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Alunos
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            ViewBag.Sucesso = "Listagem bem sucedida!"; // Mensagem de sucesso para a listagem

            return _context.Aluno != null ?
                        View(await _context.Aluno.ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Aluno'  is null.");            
        }


        // GET: Alunos/Details/5
        [Route("detalhes/{id:int?}")]
        public async Task<IActionResult> Details(int id)
        {
            if (_context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }


        // GET: Alunos/Create
        [Route("novo")]
        public IActionResult Create()
        {
            return View();
        }


        // POST: Alunos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("novo")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,DataNascimento,Email,EmailConfirmacao,Avaliacao,Ativo")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aluno);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }


        // GET: Alunos/Edit/5
        [Route("editar/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            if (_context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno.FindAsync(id);
            
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }


        // POST: Alunos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("editar/{id:int}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,DataNascimento,Email,Avaliacao,Ativo")] Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            ModelState.Remove("EmailConfirmacao"); // Remove a validação do campo EmailConfirmacao, pois não é necessário no Edit   

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                TempData["Sucesso"] = "Aluno editado com sucesso!"; // Mensagem de sucesso

                return RedirectToAction(nameof(Index));
            }
            return View(aluno);
        }


        // GET: Alunos/Delete/5
        [Route("excluir/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (_context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }


        // POST: Alunos/Delete/5
        [HttpPost("excluir/{id:int}"), ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Aluno == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Aluno'  is null.");
            }

            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno != null)
            {
                _context.Aluno.Remove(aluno);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(int id)
        {
            return _context.Aluno.Any(e => e.Id == id);
        }
    }
}

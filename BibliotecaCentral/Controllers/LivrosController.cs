using BibliotecaCentral.Data;
using BibliotecaCentral.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BibliotecaCentral.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public LivrosController(AppDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livro>>> GetClientes()
        {
            return await _context.Livros.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> CriarLivros(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
            return Ok("Livro Adicionado.");
        }

    }
}

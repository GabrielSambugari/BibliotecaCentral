using BibliotecaCentral.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaCentral.Data
{

    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Livro> Livros { get; set; }

    }
}

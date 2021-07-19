using System.Collections.Generic;
using SnackApp.Context;
using SnackApp.Models;

namespace SnackApp.Repositories
{
    public class CategoriaRepository : ICategoriasRepository
    {
        // ctor for Dependency Injection
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
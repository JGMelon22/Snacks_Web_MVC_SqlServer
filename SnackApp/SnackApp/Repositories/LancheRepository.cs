using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SnackApp.Context;
using SnackApp.Models;

namespace SnackApp.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        // ctor
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        // Access Lanches table
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(p => p.IsLanchePreferido).Include(c => c.Categoria);


        public Lanche1 GetLancheById<Lanche1>(int lancheId)
        {
            throw new System.NotImplementedException();
        }
        
        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
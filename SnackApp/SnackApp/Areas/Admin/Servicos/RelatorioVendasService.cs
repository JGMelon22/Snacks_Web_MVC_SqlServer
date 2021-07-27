using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SnackApp.Context;
using SnackApp.Models;

namespace SnackApp.Areas.Admin.Servicos
{
    public class RelatorioVendasService
    {
        // Report Logic
        // Dependency injection
        private readonly AppDbContext context;

        public RelatorioVendasService(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in context.Pedidos select obj;

            if (minDate.HasValue)
                resultado = resultado
                    .Where(x => x.PedidoEnviado >= minDate.Value);

            if (maxDate.HasValue)
                resultado = resultado
                    .Where(x => x.PedidoEnviado <= maxDate.Value);

            // Include into the result the items and snacks
            // return and organize them
            return await resultado
                .Include(l => l.PedidoItens)
                .ThenInclude(l => l.Lanche)
                .OrderByDescending(x => x.PedidoEnviado)
                .ToListAsync();
        }
    }
}
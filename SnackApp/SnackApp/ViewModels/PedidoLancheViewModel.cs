using System.Collections.Generic;
using SnackApp.Models;

namespace SnackApp.ViewModels
{
    public class PedidoLancheViewModel
    {
        // prop
        public Pedido Pedido { get; set; }

        // List of PedidoDetalhe
        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
using System.Collections;
using System.Collections.Generic;
using SnackApp.Models;

namespace SnackApp.Repositories
{
    public interface ICategoriasRepository
    {
        // Methods
        IEnumerable<Categoria> Categorias { get; }
    }
}
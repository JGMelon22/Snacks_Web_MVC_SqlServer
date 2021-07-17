using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnackApp.Models
{
    public class Categoria
    {
        // prop
        public int CategoriaId { get; set; }

        [StringLength(100)] public string CategoriaNome { get; set; }

        [StringLength(200)] public string Descricao { get; set; }

        // Informs to the ED the relationship (one to many)
        // using List
        public List<Lanche> Type { get; set; }
    }
}
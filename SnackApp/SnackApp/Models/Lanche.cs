using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnackApp.Models
{
    public class Lanche
    {
        // prop
        // Calling it as Id makes the EF to create a PK
        public int LancheId { get; set; }

        // DataAnnotation
        [StringLength(100)] public string Nome { get; set; }
        [StringLength(100)] public string DescricaoCurta { get; set; }
        [StringLength(255)] public string DescricaoDetalhada { get; set; }
        [Column(TypeName = "decimal(18,2)")] public decimal Preco { get; set; }
        [StringLength(200)] public string ImagemUrl { get; set; }
        [StringLength(200)] public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }

        /*
         The virtual keyword is used to modify a method, 
         property, indexer, or event declaration
          and allow for it to be overridden in a derived class. 
          For example, this method can be overridden 
          by any class that inherits it:
         */
        public virtual Categoria Categoria { get; set; }
    }
}
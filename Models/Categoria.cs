using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DelfimTec.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage ="O tamanho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Infrme o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é 200 caracteres")]
        [Required(ErrorMessage = "Infrme a descrição da categoria")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }



        //Relacionamento

        public List<Produto> Produtos { get; set; }
    }
}

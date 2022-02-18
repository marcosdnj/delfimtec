﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DelfimTec.Models
{
    [Table("Lanches")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto deve ser informado")]
        [Display(Name = "Nome do produto")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descrição do produto deve ser informada")]
        [Display(Name = "Descrição do produto")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }


        [Required(ErrorMessage = "O descrição detalhada do produto deve ser informada")]
        [Display(Name = "Descrição detalhada do produto")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage = "Informe o preço do produto")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 29999.99, ErrorMessage = "O preço deve estar entre 1 e 29999,99")]
        public decimal Preco { get; set; }


        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImageUrl { get; set; }


        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }


        [Display(Name = "Preferido?")]
        public bool IsProdutoPreferido { get; set; }


        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }



        //Propriedade para relacionamento abaixo
        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }


    }
}

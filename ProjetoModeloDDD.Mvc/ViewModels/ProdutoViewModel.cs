using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.Mvc.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int produtoId { get; set; }

        [Display(Name ="Descrição")]
        [Required(ErrorMessage ="o Campo Descrição é obrigatório, preencha-o!")]
        [MaxLength(150,ErrorMessage ="O tamanho máx é 150 caracteres")]
        public string descProd { get; set; }

        [Display(Name = "Preço")]
        [Range(typeof(decimal),"0","999999999999999")]
        [Required(ErrorMessage = "o Campo preço é obrigatório, preencha-o!")]
        public decimal valorProd { get; set; }

        public bool ativoProd { get; set; }

        public int clienteId { get; set; }

        public virtual ClienteViewModel ClientesViewModel { get; set; }
    }
}
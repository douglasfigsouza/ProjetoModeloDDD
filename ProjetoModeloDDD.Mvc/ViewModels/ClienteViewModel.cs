using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.Mvc.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int clienteId { get; set; }

        [Display(Name ="Nome")]
        [Required(ErrorMessage ="O Campo nome é Requerido, Digite-o")]
        [MaxLength(150, ErrorMessage ="O numero máximo de caracteres é 150!")]
        [MinLength(3, ErrorMessage ="O numero minimo de caracteres é 3")]
        public string nomeCli { get; set; }

        [Display(Name = "Sobrenome")]
        [Required(ErrorMessage = "O Campo seobrenome é Requerido, Digite-o")]
        [MaxLength(150, ErrorMessage = "O numero máximo de caracteres é 150!")]
        [MinLength(3, ErrorMessage = "O numero minimo de caracteres é 3")]
        public string sobrenomeCli { get; set; }

        [ScaffoldColumn(false)]
        public DateTime dataCadastro { get; set; }
        public bool ativoCli { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage ="O formato de E-mail não é valido!")]
        public string emailCli { get; set; }

        public virtual IEnumerable<ProdutoViewModel> ProdutosViewModel { get; set; }
    }
}
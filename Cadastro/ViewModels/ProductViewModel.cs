using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Cadastro;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int IdProduto { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O sobrenome é requerido.")]
        public int Value { get; set; }

        [Display(Name = "Disponível")]
        public bool Available { get; set; }

        [ForeignKey("EntidadeEstrangeira")]
        [Display(Name = "Nome")]
        public ClientViewModel Id { get; set; }
    }
}

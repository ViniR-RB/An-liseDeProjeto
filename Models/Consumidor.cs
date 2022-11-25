using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace prova_AnaliseProjeto.Models
{
    public class Consumidor
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        public string? Nome { get; set; }


         public virtual ICollection<Pedido>? Pedido { get; set; }
    }
}
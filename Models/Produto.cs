using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace prova_AnaliseProjeto.Models
{
    public class Produto

    {
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Display(Name = "Descrição")]
        public string? descricao { get; set; }
        // public Pedido? Pedido { get; set; }


    }
}
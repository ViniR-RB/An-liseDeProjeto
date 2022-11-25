using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace prova_AnaliseProjeto.Models
{
    public class CartaoDeCredito : Pagamento
    {
        [Display(Name = "Código")]
        public string? numero { get; set; }

        
    }
}
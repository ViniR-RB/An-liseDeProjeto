using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace prova_AnaliseProjeto.Models
{
    public class Pagamento
    {
        [Display(Name = "Código")]
        public int Id { get; set; }


        [Display(Name = "Data_Do_Pagamento")]
        public DateTime DateTime { get; set; }

        public string? Discriminator { get; }


        public double? Valor { get; set; }
    }
}
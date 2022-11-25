using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace prova_AnaliseProjeto.Models
{
    public class Pedido
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        public int? PagamentoId { get; set; }
        public virtual Pagamento? Pagamento { get; set; }


        [Display(Name = "Data_Do_Pedido")]
        public DateTime DateTime { get; set; }



        public List<Produto>? items { get; set; }


        // public ICollection<Produto>? Produto { get; set; }



        public int? ConsumidorId { get; set; }
        public virtual Consumidor? Consumidor { get; set; }
    }
}
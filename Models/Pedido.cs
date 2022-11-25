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
        public virtual ICollection<Produto>? Produto { get; set; }



        public Pagamento? Pagamento { get; set; }




        public int? ConsumidorId { get; set; }
        public virtual Consumidor? Consumidor { get; set; }
    }
}
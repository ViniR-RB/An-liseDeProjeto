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


        public int? PedidoId { get; set; }
        public virtual Pedido? Pedido { get; set; }

        public double? Valor { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova_AnaliseProjeto.Models
{
    public class Boleto : Pagamento
    {
public Pedido? Pedido { get; set; }
    }
}
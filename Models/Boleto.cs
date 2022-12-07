using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova_AnaliseProjeto.Models
{
    public class Boleto : Pagamento
    {
        public DateTime data_de_vencimento { get; set; }

        public string? cod_de_barra { get; set; }
    }
}
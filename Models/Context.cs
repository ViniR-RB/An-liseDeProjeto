using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace prova_AnaliseProjeto.Models
{

    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) :

        base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<Consumidor> Consumidor { get; set; }

        public DbSet<Pagamento> Pagamento { get; set; }


        public DbSet<CartaoDeCredito> CartaoDeCredito { get; set; }

        public DbSet<Boleto> Boleto { get; set; }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<Produto> Produto { get; set; }

    }

}

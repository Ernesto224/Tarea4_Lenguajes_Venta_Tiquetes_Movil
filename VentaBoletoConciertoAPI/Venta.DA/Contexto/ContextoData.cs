using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.DA.Entidades;
using Ventan.DA.Entidades;

namespace Ventan.DA.Contexto
{
    public class ContextoData:DbContext
    {
        public ContextoData(DbContextOptions options):base(options) { 
            
        }

        public DbSet<UsuarioDA>UsuarioDA{ get; set; }
        public DbSet<ConciertoDA>ConciertoDA { get; set; }
        public DbSet<TipoZonaDA> TipoZonaDA { get; set; }
        public DbSet<AsientoDA>AsientoDA { get; set; }
        public DbSet<BoletoDA>BoletoDA { get; set; }
        public DbSet<ReservaDA>ReservaDA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservaDA>().HasKey(llave => new { llave.idUsuario, llave.idBoleto});
        }

    }
}

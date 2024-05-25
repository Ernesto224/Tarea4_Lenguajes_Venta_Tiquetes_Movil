using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venta.BC.Modelos;
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
        public DbSet<ReservaDA>ReservaDA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReservaDA>()
                .HasKey(r => new { r.idUsuario, r.idAsiento });

            modelBuilder.Entity<AsientoDA>()
                .HasOne(a => a.TipoZona)
                .WithMany()
                .HasForeignKey(a => a.idTipoZona);

            modelBuilder.Entity<AsientoDA>()
                .HasOne(a => a.Concierto)
                .WithMany()
                .HasForeignKey(a => a.idConcierto);
        }

    }
}

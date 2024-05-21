using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventan.DA.Entidades;

namespace Ventan.DA.Contexto
{
    public class ContextoData:DbContext
    {
        public ContextoData(DbContextOptions options):base(options) { 
            
        }
        public DbSet<UsuarioDA>UsuarioDA{ get; set; }
        public DbSet<ConciertoDA>ConciertoDA { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Examen.Models;

namespace Examen.Data
{
    public class ExamenContext : DbContext
    {
        public ExamenContext (DbContextOptions<ExamenContext> options)
            : base(options)
        {
        }

        public DbSet<Examen.Models.AnthonyRodriguez_tabla1> AnthonyRodriguez_tabla1 { get; set; } = default!;
    }
}

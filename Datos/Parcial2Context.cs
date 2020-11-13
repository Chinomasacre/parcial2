using System;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class Parcial2Context:DbContext
    {
        public Parcial2Context(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Pago> Pagos { get; set; }

    }
}

using System;
using System.Data.Entity;

namespace EntityFrameworkTP4
{
     class AgendaContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Telefono> Telefonos { get; set; }
    }
}
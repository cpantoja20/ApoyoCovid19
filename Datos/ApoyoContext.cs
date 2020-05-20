using System;
using Entity;
using Microsoft.EntityFrameworkCore;



namespace Datos
{
    public class ApoyoContext : DbContext
    {
        public ApoyoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Apoyo> Apoyos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Odonto.Domain.Entities;
using System.Reflection;

namespace Odonto.Infrastructure.Persistence.Context
{
    public sealed class OdontoContext : DbContext
    {
        public OdontoContext() { }

        public OdontoContext(DbContextOptions<OdontoContext> options) : base(options) { }

        public DbSet<Services> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        //=>
        //modelBuilder.ApplyConfigurationsFromAssembly(typeof(OdontoContext).Assembly);
        {
            /*
             * Note: 
             * CI(Case Insensitive) = Insensible a mayúsculas y minúsculas "Hola = hola"
             * AS(Accent Sensitive) = sensible a acentos.
             */
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //OR
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(OdontoContext).Assembly);

            base.OnModelCreating(modelBuilder);
            //OnModelCreatingPartial(modelBuilder);
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

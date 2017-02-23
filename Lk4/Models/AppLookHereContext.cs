using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Lk4.Models.Mapping;

namespace Lk4.Models
{
    public partial class AppLookHereContext : DbContext
    {
        static AppLookHereContext()
        {
            Database.SetInitializer<AppLookHereContext>(null);
        }

        public AppLookHereContext(): base("Name=AppLookHereContext")
        {

        }

        public DbSet<Aluno> Alunoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlunoMap());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
        }
    }
}

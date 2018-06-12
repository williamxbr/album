using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Repositorio.ConfigEntidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Eniwine.Album.Copa.Repositorio.Contexto
{
    public class RepositorioContexto : DbContext
    {
        public RepositorioContexto() : base("AlbumEniwine")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Figurinha> Figurinhas { get; set; }
        public DbSet<Troca> Trocas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioFigurinha> UsuarioFigurinhas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new FigurinhaConfig());
            modelBuilder.Configurations.Add(new TrocaConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
        }
    }
}

using Eniwine.Album.Copa.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Album.Copa.Repositorio.ConfigEntidades
{
    public class UsuarioFigurinhaConfig : EntityTypeConfiguration<UsuarioFigurinha>
    {
        public UsuarioFigurinhaConfig()
        {
            HasKey(p => p.UsuarioFigurinhaId);

            Property(p => p.UsuarioFigurinhaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(f => f.Figurinha)
                .WithMany()
                .HasForeignKey(f => f.FigurinhaId);

            HasRequired(f => f.Usuario)
                .WithMany()
                .HasForeignKey(f => f.UsuarioId);
        }
    }
}

using Eniwine.Album.Copa.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Album.Copa.Repositorio.ConfigEntidades
{
    public class TrocaConfig : EntityTypeConfiguration<Troca>
    {
        public TrocaConfig()
        {
            HasKey(t => t.TrocaId);
            Property(t => t.TrocaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            HasRequired(f => f.UsuarioSolicitante)
                .WithMany()
                .HasForeignKey(f => f.UsuarioIdSolicitante);

            HasRequired(f => f.UsuarioRequerido)
                .WithMany()
                .HasForeignKey(f => f.UsuarioIdSolicitante);
        }
    }
}

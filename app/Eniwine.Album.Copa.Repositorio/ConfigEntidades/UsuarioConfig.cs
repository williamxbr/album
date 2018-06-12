using Eniwine.Album.Copa.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Album.Copa.Repositorio.ConfigEntidades
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(p => p.UsuarioId);
            Property(p => p.UsuarioId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(p => p.Login)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new System.ComponentModel.DataAnnotations.Schema.IndexAttribute() { IsUnique = true }));
        }
    }
}

using Eniwine.Album.Copa.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Eniwine.Album.Copa.Repositorio.ConfigEntidades
{
    public class FigurinhaConfig : EntityTypeConfiguration<Figurinha>
    {
        public FigurinhaConfig()
        {
            HasKey(f => f.FigurinhaId);
            Property(f => f.FigurinhaId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
        }
    }
}

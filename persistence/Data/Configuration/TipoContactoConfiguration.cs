using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TipoContactoConfiguration : IEntityTypeConfiguration<Tipocontacto>
    {
        public void Configure(EntityTypeBuilder<Tipocontacto> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("tipocontacto");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
        }
    }
}
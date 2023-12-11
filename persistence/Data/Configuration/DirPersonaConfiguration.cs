using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class DirPersonaConfiguration : IEntityTypeConfiguration<Dirpersona>
    {
        public void Configure(EntityTypeBuilder<Dirpersona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("dirpersona");

            builder.HasIndex(e => e.IdPersona, "IdPersona");

            builder.HasIndex(e => e.IdTipoDireccion, "IdTipoDireccion");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");

            builder.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Dirpersonas)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("dirpersona_ibfk_1");

            builder.HasOne(d => d.IdTipoDireccionNavigation).WithMany(p => p.Dirpersonas)
                .HasForeignKey(d => d.IdTipoDireccion)
                .HasConstraintName("dirpersona_ibfk_2");
        }
    }
}
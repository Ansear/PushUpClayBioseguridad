using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ContactoPerConfiguration : IEntityTypeConfiguration<Contactoper>
    {
        public void Configure(EntityTypeBuilder<Contactoper> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contactoper");

            builder.HasIndex(e => e.IdPersona, "IdPersona");

            builder.HasIndex(e => e.IdTipoContacto, "IdTipoContacto");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.IdPersonaNavigation).WithMany(p => p.Contactopers)
                .HasForeignKey(d => d.IdPersona)
                .HasConstraintName("contactoper_ibfk_1");

            builder.HasOne(d => d.IdTipoContactoNavigation).WithMany(p => p.Contactopers)
                .HasForeignKey(d => d.IdTipoContacto)
                .HasConstraintName("contactoper_ibfk_2");
        }
    }
}
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("persona");

            builder.HasIndex(e => e.IdCategoria, "IdCategoria");

            builder.HasIndex(e => e.IdCiudad, "IdCiudad");

            builder.HasIndex(e => e.IdPersona, "IdPersona").IsUnique();

            builder.HasIndex(e => e.IdTipoPersona, "IdTipoPersona");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");

            builder.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("persona_ibfk_2");

            builder.HasOne(d => d.IdCiudadNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdCiudad)
                .HasConstraintName("persona_ibfk_3");

            builder.HasOne(d => d.IdTipoPersonaNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdTipoPersona)
                .HasConstraintName("persona_ibfk_1");

            builder.HasOne(d => d.User).WithOne(p => p.Persona)
            .HasForeignKey<Persona>(d => d.IdUser)
            .HasConstraintName("persona_user_fk");
        }
    }
}
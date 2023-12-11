using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class TurnosConfiguration : IEntityTypeConfiguration<Turno>
    {
        public void Configure(EntityTypeBuilder<Turno> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("turnos");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.HoraTurnoFin)
                .HasColumnType("time")
                .HasColumnName("horaTurnoFin");
            builder.Property(e => e.HoraTurnoInicio)
                .HasColumnType("time")
                .HasColumnName("horaTurnoInicio");
            builder.Property(e => e.NombreTurno)
                .HasMaxLength(255)
                .HasColumnName("nombreTurno");
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("turnos");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.HoraTurnoFin)
                .HasColumnType("time")
                .HasColumnName("horaTurnoFin");
            builder.Property(e => e.HoraTurnoInicio)
                .HasColumnType("time")
                .HasColumnName("horaTurnoInicio");
            builder.Property(e => e.NombreTurno)
                .HasMaxLength(255)
                .HasColumnName("nombreTurno");
        }
    }
}
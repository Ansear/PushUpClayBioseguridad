using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
    {
        public void Configure(EntityTypeBuilder<Programacion> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("programacion");

            builder.HasIndex(e => e.IdContrato, "IdContrato");

            builder.HasIndex(e => e.IdEmpleado, "IdEmpleado");

            builder.HasIndex(e => e.IdTurno, "IdTurno");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdContrato)
                .HasConstraintName("programacion_ibfk_1");

            builder.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdEmpleado)
                .HasConstraintName("programacion_ibfk_3");

            builder.HasOne(d => d.IdTurnoNavigation).WithMany(p => p.Programacions)
                .HasForeignKey(d => d.IdTurno)
                .HasConstraintName("programacion_ibfk_2");
        }
    }
}
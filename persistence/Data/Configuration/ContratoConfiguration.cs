using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("contrato");

            builder.HasIndex(e => e.IdEstado, "IdEstado");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Fechacontrato).HasColumnName("fechacontrato");

            builder.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("contrato_ibfk_1");
        }
    }
}
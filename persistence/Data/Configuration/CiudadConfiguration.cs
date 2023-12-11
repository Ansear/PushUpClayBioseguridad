using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
    {
        public void Configure(EntityTypeBuilder<Ciudad> builder)
        {
            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("ciudad");

            builder.HasIndex(e => e.IdDep, "IdDep");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.Nombreciud)
                .HasMaxLength(255)
                .HasColumnName("nombreciud");

            builder.HasOne(d => d.IdDepNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.IdDep)
                .HasConstraintName("ciudad_ibfk_1");
        }
    }
}
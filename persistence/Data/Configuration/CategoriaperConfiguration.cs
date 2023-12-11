using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class CategoriaperConfiguration : IEntityTypeConfiguration<Categoriaper>
    {
        public void Configure(EntityTypeBuilder<Categoriaper> builder)
        {

            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("categoriaper");

            builder.Property(e => e.Id).ValueGeneratedNever();
            builder.Property(e => e.NombreCategoria)
                .HasMaxLength(255)
                .HasColumnName("nombreCategoria");
        }
        
    }
}
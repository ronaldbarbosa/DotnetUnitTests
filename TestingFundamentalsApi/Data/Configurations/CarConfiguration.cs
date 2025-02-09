using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestingFundamentalsApi.Entities;

namespace TestingFundamentalsApi.Data.Configurations;

internal sealed class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name)
            .HasMaxLength(100);
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductGit.Entity;

namespace ProductGit.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
        }
    }
}

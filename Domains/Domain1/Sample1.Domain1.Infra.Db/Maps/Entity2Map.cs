using Sample1.Domain1.Storage.ModelsDbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sample1.Domain1.Infra.Db.Maps
{
    public class Entity2Map : IEntityTypeConfiguration<Entity2Dbo>
    {
        public void Configure(EntityTypeBuilder<Entity2Dbo> builder)
        {
            builder.ToTable("Entity2");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500);

            builder.HasData(
                new Entity2Dbo { Id = 1, Name = "Item1", Description = "Item 1 descrption" },
                new Entity2Dbo { Id = 2, Name = "Item2", Description = "Item 2 descrption" },
                new Entity2Dbo { Id = 3, Name = "Item3", Description = "Item 3 descrption" }

            );
        }
    }
}
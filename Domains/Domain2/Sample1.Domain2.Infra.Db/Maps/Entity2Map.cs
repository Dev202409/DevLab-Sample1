using Sample1.Domain2.Storage.ModelsDbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sample1.Domain2.Infra.Db.Maps
{
    public class Entity2Map : IEntityTypeConfiguration<Entity2Dbo>
    {
        public void Configure(EntityTypeBuilder<Entity2Dbo> builder)
        {
            builder.ToTable("Entity2");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Title).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Year);

            builder.HasData(
                new Entity2Dbo { Id = 1, Title = "Item1Title", Year = 1990 },
                new Entity2Dbo { Id = 2, Title = "Item2Title", Year = 2008 },
                new Entity2Dbo { Id = 3, Title = "Item3Title", Year = 1972 }

            );
        }
    }
}
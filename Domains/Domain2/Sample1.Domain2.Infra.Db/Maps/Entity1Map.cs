using Sample1.Domain2.Storage.ModelsDbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sample1.Domain2.Infra.Db.Maps
{
    public class Entity1Map : IEntityTypeConfiguration<Entity1Dbo>
    {
        public void Configure(EntityTypeBuilder<Entity1Dbo> builder)
        {
            builder.ToTable("Entity1");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.IsActive).IsRequired();


            builder.HasData(
                new Entity1Dbo { Id = 1, Name = "Item1Name", IsActive = false },
                new Entity1Dbo { Id = 2, Name = "Item2Name", IsActive = true }
            );
        }
    }
}
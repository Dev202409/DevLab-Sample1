using Sample1.Domain1.Storage.ModelsDbo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Sample1.Domain1.Infra.Db.Maps
{
    public class Entity1Map : IEntityTypeConfiguration<Entity1Dbo>
    {
        public void Configure(EntityTypeBuilder<Entity1Dbo> builder)
        {
            builder.ToTable("Entity1");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Label).HasMaxLength(50).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.EFTest);

            builder.HasData(
                new Entity1Dbo { Id = 1, IsActive = true, Label = "Label1" },
                new Entity1Dbo { Id = 2, IsActive = true, Label = "Label2" },
                new Entity1Dbo { Id = 3, IsActive = true, Label = "Label3" },
                new Entity1Dbo { Id = 4, IsActive = true, Label = "Label4" },
                new Entity1Dbo { Id = 5, IsActive = true, Label = "Label5" },
                new Entity1Dbo { Id = 6, IsActive = true, Label = "Label6" }
            );
        }
    }
}
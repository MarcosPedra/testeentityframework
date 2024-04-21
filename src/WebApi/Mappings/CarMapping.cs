using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Domain.Models;

namespace WebApi.Mappings
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car");

            builder.Property(p => p.Brand)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(p => p.Model)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(p => p.Color)
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(p => p.YearManufacture)
                .HasColumnType("datetime");

            builder.HasData(
                new Car(Guid.NewGuid(), "Ford", "F600", "Cinza", Convert.ToDateTime("2024-01-01")),
                new Car(Guid.NewGuid(), "Fiat", "Uno", "Branco", Convert.ToDateTime("2023-01-01")),
                new Car(Guid.NewGuid(), "Chevrolet", "Onix", "Preto", Convert.ToDateTime("2024-01-01")),
                new Car(Guid.NewGuid(), "Fiat", "Siena", "Prata", Convert.ToDateTime("2016-01-01")),
                new Car(Guid.NewGuid(), "Ford", "F1000", "Chumbo", Convert.ToDateTime("2000-01-01"))
                );

        }
    }
}

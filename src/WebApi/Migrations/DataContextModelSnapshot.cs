﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Context;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApi.Domain.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<DateTime>("YearManufacture")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("Car", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5509ba04-6128-41b2-bc50-1ce7b6577e68"),
                            Brand = "Ford",
                            Color = "Cinza",
                            Model = "F600",
                            YearManufacture = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("c927299c-01a0-4316-8531-0944c727960f"),
                            Brand = "Fiat",
                            Color = "Branco",
                            Model = "Uno",
                            YearManufacture = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("78665b5b-e8ba-4528-82c9-446e7dafa2d3"),
                            Brand = "Chevrolet",
                            Color = "Preto",
                            Model = "Onix",
                            YearManufacture = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("aaabbdb8-63fc-4009-94dd-625f31815381"),
                            Brand = "Fiat",
                            Color = "Prata",
                            Model = "Siena",
                            YearManufacture = new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = new Guid("da808ea4-8cb0-4be7-852d-3211a1c1b2bc"),
                            Brand = "Ford",
                            Color = "Chumbo",
                            Model = "F1000",
                            YearManufacture = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

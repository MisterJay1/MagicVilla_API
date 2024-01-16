﻿// <auto-generated />
using System;
using SigmaVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace SigmaVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231108074210_SeedVillaTableWithDateCreated")]
    partial class SeedVillaTableWithDateCreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SigmaVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedCreated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "",
                            DateCreated = new DateTime(2023, 11, 8, 9, 42, 10, 152, DateTimeKind.Local).AddTicks(9654),
                            Details = "Set on a beautiful street with an amazing view to a sunset.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1280x900/295090917.jpg?k=d17621b71b0eaa0c7a37d8d8d02d33896cef75145f61e7d96d296d88375a7d39&o=&hp=1",
                            Name = "Royal Villa",
                            Occupancy = 5,
                            Rate = 200.0,
                            Sqft = 550,
                            UpdatedCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "",
                            DateCreated = new DateTime(2023, 11, 8, 9, 42, 10, 152, DateTimeKind.Local).AddTicks(9708),
                            Details = "Set on a green street.",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCwKconmBwaneB1wv1YNzCNnq9u013ul1l8FW07Y9XEY5WTIAS_75cb_vbz4FyU2nyzCM&usqp=CAU",
                            Name = "Green Villa",
                            Occupancy = 7,
                            Rate = 300.0,
                            Sqft = 750,
                            UpdatedCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "",
                            DateCreated = new DateTime(2023, 11, 8, 9, 42, 10, 152, DateTimeKind.Local).AddTicks(9710),
                            Details = "Set on a blue street.",
                            ImageUrl = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/301483778.jpg?k=b1f449beb857de98e8287c34956b672956926c2d03ac185ff8d9a348622c157a&o=&hp=1",
                            Name = "Blue Villa",
                            Occupancy = 9,
                            Rate = 500.0,
                            Sqft = 950,
                            UpdatedCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "",
                            DateCreated = new DateTime(2023, 11, 8, 9, 42, 10, 152, DateTimeKind.Local).AddTicks(9713),
                            Details = "Set on a red street.",
                            ImageUrl = "https://image.architonic.com/prj2-3/20714433/swissfineline-reference--villalakezurich-pic01-villa-zurichsee-1-arcit18.jpg",
                            Name = "Red Villa",
                            Occupancy = 11,
                            Rate = 700.0,
                            Sqft = 1150,
                            UpdatedCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "",
                            DateCreated = new DateTime(2023, 11, 8, 9, 42, 10, 152, DateTimeKind.Local).AddTicks(9715),
                            Details = "Set on an orange street.",
                            ImageUrl = "https://www.myistria.com/UserDocsImages/app/objekti/1384/slika_hd/06052022024444_Villa-in-Pula-Villa%20Old%20Olive%20I%20-%20n3.jpg?preset=carousel-1-webp",
                            Name = "Orange Villa",
                            Occupancy = 31,
                            Rate = 900.0,
                            Sqft = 1350,
                            UpdatedCreated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

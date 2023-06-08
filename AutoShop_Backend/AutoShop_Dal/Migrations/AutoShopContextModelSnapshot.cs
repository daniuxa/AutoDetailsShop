﻿// <auto-generated />
using AutoShop_Dal.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoShop_Dal.Migrations
{
    [DbContext(typeof(AutoShopContext))]
    partial class AutoShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AutoShop_Dal.BaseProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("imgSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseProducts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseProduct");
                });

            modelBuilder.Entity("AutoShop_Dal.Candle", b =>
                {
                    b.HasBaseType("AutoShop_Dal.BaseProduct");

                    b.HasDiscriminator().HasValue("Candle");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Candle1",
                            Price = 80m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/1.jfif?updatedAt=1685827454525"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Candle2",
                            Price = 90m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/2.jpeg?updatedAt=1685827454853"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Candle3",
                            Price = 100m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/3.jpg?updatedAt=1685827454580"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Candle4",
                            Price = 110m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/4.jfif?updatedAt=1685827454594"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Candle5",
                            Price = 120m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/5.jfif?updatedAt=1685827454567"
                        });
                });

            modelBuilder.Entity("AutoShop_Dal.Filter", b =>
                {
                    b.HasBaseType("AutoShop_Dal.BaseProduct");

                    b.HasDiscriminator().HasValue("Filter");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            Name = "Filter1",
                            Price = 80m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/1_1_.jfif?updatedAt=1685827457946"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Filter2",
                            Price = 90m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/2_2_.jpg?updatedAt=1685827458352"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Filter3",
                            Price = 100m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/3.jfif?updatedAt=1685827457943"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Filter4",
                            Price = 110m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/4_1_.jfif?updatedAt=1685827457685"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Filter5",
                            Price = 120m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/5_2_.jfif?updatedAt=1685827457863"
                        });
                });

            modelBuilder.Entity("AutoShop_Dal.Oil", b =>
                {
                    b.HasBaseType("AutoShop_Dal.BaseProduct");

                    b.HasDiscriminator().HasValue("Oil");

                    b.HasData(
                        new
                        {
                            Id = 11,
                            Name = "Oil1",
                            Price = 80m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/1_1_.jpg?updatedAt=1685827460666"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Oil2",
                            Price = 90m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/2_3_.jpg?updatedAt=1685827460895"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Oil3",
                            Price = 100m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/3_2_.jpg?updatedAt=1685827460952"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Oil4",
                            Price = 110m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/4_1_.jpg?updatedAt=1685827460517"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Oil5",
                            Price = 120m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/5_1_.jpg?updatedAt=1685827460692"
                        });
                });

            modelBuilder.Entity("AutoShop_Dal.Pad", b =>
                {
                    b.HasBaseType("AutoShop_Dal.BaseProduct");

                    b.HasDiscriminator().HasValue("Pad");

                    b.HasData(
                        new
                        {
                            Id = 16,
                            Name = "Pad1",
                            Price = 80m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/1.jpg?updatedAt=1685827454696"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Pad2",
                            Price = 90m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/2.jpg?updatedAt=1685827454879"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Pad3",
                            Price = 100m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/3.jpeg?updatedAt=1685827454840"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Pad4",
                            Price = 110m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/4.png?updatedAt=1685827455133"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Pad5",
                            Price = 120m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/5_1_.jfif?updatedAt=1685827454582"
                        });
                });

            modelBuilder.Entity("AutoShop_Dal.Wiper", b =>
                {
                    b.HasBaseType("AutoShop_Dal.BaseProduct");

                    b.HasDiscriminator().HasValue("Wiper");

                    b.HasData(
                        new
                        {
                            Id = 21,
                            Name = "Wiper1",
                            Price = 80m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/2_1_.jpg?updatedAt=1685827457778"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Wiper2",
                            Price = 90m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/5.jpg?updatedAt=1685827457699"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Wiper3",
                            Price = 100m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/1.webp?updatedAt=1685827457985"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Wiper4",
                            Price = 110m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/3_1_.jpg?updatedAt=1685827457654"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Wiper5",
                            Price = 120m,
                            imgSrc = "https://ik.imagekit.io/i8gs619wfp/4.jpg?updatedAt=1685827457551"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

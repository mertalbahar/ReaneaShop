﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace ReaneaShopApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20231102123054_Category")]
    partial class Category
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Entities.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Toka"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cüzdan"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Anahtarlık"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Çanta"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Marteniçka"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Oyuncak"
                        });
                });

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductSummary")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Üçgen gri toka",
                            ProductPrice = 250m,
                            ProductSummary = "Üçgen gri toka"
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Üçgen pembe toka",
                            ProductPrice = 1300m,
                            ProductSummary = "Üçgen pembe toka"
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Üçgen turuncu toka",
                            ProductPrice = 250m,
                            ProductSummary = "Üçgen turuncu toka"
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Cüzdan 1",
                            ProductPrice = 37m,
                            ProductSummary = "Cüzdan 1"
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "Cüzdan 2",
                            ProductPrice = 3865m,
                            ProductSummary = "Cüzdan 2"
                        },
                        new
                        {
                            ProductId = 6,
                            ProductName = "Cüzdan 3",
                            ProductPrice = 805m,
                            ProductSummary = "Ayakkabı kokulu"
                        },
                        new
                        {
                            ProductId = 7,
                            ProductName = "Pembe baykuş anahtarlık",
                            ProductPrice = 120m,
                            ProductSummary = "Pembe baykuş anahtarlık"
                        },
                        new
                        {
                            ProductId = 8,
                            ProductName = "Sarı baykuş anahtarlık",
                            ProductPrice = 11280m,
                            ProductSummary = "Sarı baykuş anahtarlık"
                        },
                        new
                        {
                            ProductId = 9,
                            ProductName = "Yeşil baykuş anahtarlık",
                            ProductPrice = 85m,
                            ProductSummary = "Yeşil baykuş anahtarlık"
                        },
                        new
                        {
                            ProductId = 10,
                            ProductName = "Kahverengi çiçek çanta",
                            ProductPrice = 420m,
                            ProductSummary = "Kahverengi çiçek çanta"
                        },
                        new
                        {
                            ProductId = 11,
                            ProductName = "Pembe çiçek çanta",
                            ProductPrice = 120m,
                            ProductSummary = "Pembe çiçek çanta"
                        },
                        new
                        {
                            ProductId = 12,
                            ProductName = "Mor çiçek çanta",
                            ProductPrice = 375m,
                            ProductSummary = "Mor çiçek çanta"
                        },
                        new
                        {
                            ProductId = 13,
                            ProductName = "Marteniçka dilek bilekliği",
                            ProductPrice = 12m,
                            ProductSummary = "Marteniçka dilek bilekliği"
                        },
                        new
                        {
                            ProductId = 14,
                            ProductName = "Kuzucuk",
                            ProductPrice = 12m,
                            ProductSummary = "Kuzucuk"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
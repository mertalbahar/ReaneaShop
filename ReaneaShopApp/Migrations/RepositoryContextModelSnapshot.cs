﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReaneaShopApp.Models;

#nullable disable

namespace ReaneaShopApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("ReaneaShopApp.Models.Product", b =>
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
                            ProductName = "Çiçek",
                            ProductPrice = 250m,
                            ProductSummary = "Çiçek kokulu"
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Arı",
                            ProductPrice = 1300m,
                            ProductSummary = "Arı kokulu"
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Kelebek",
                            ProductPrice = 250m,
                            ProductSummary = "Kelebek kokulu"
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Şapka",
                            ProductPrice = 37m,
                            ProductSummary = "Şapka kokulu"
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "Çanta",
                            ProductPrice = 3865m,
                            ProductSummary = "Çanta kokulu"
                        },
                        new
                        {
                            ProductId = 6,
                            ProductName = "Ayakkabı",
                            ProductPrice = 805m,
                            ProductSummary = "Ayakkabı kokulu"
                        },
                        new
                        {
                            ProductId = 7,
                            ProductName = "Papatya",
                            ProductPrice = 120m,
                            ProductSummary = "Papatya kokulu"
                        },
                        new
                        {
                            ProductId = 8,
                            ProductName = "Bal kabağı",
                            ProductPrice = 11280m,
                            ProductSummary = "Bal kokulu"
                        },
                        new
                        {
                            ProductId = 9,
                            ProductName = "Çakmak",
                            ProductPrice = 85m,
                            ProductSummary = "Çakmak kokulu"
                        },
                        new
                        {
                            ProductId = 10,
                            ProductName = "Cüzdan",
                            ProductPrice = 420m,
                            ProductSummary = "Cüzdan kokulu"
                        },
                        new
                        {
                            ProductId = 11,
                            ProductName = "Zambak",
                            ProductPrice = 120m,
                            ProductSummary = "Zambak kokulu"
                        },
                        new
                        {
                            ProductId = 12,
                            ProductName = "Matruşka",
                            ProductPrice = 375m,
                            ProductSummary = "Matruşka kokulu"
                        },
                        new
                        {
                            ProductId = 13,
                            ProductName = "Tespih",
                            ProductPrice = 12m,
                            ProductSummary = "Tespih kokulu"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

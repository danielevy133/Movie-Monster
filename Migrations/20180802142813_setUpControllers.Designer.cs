﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieMonste.Models;

namespace MovieMonste.Migrations
{
    [DbContext(typeof(MovieMonsteContext))]
    [Migration("20180802142813_setUpControllers")]
    partial class setUpControllers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieMansterWebApp.Models.Customer", b =>
                {
                    b.Property<string>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName");

                    b.Property<string>("MailAddress");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Movie", b =>
                {
                    b.Property<string>("MovieID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Actors");

                    b.Property<string>("Genere");

                    b.Property<string>("Language");

                    b.Property<int>("MinAge");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("SaleID");

                    b.Property<string>("StockOrderID");

                    b.Property<string>("Title");

                    b.Property<int>("UnitsInStock");

                    b.HasKey("MovieID");

                    b.HasIndex("SaleID");

                    b.HasIndex("StockOrderID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Sale", b =>
                {
                    b.Property<string>("SaleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerID");

                    b.Property<bool>("Purchased");

                    b.Property<int>("TotalPrice");

                    b.HasKey("SaleID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.StockOrder", b =>
                {
                    b.Property<string>("StockOrderID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("SupplierID");

                    b.Property<int>("TotalPrice");

                    b.HasKey("StockOrderID");

                    b.HasIndex("SupplierID");

                    b.ToTable("StockOrder");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Supplier", b =>
                {
                    b.Property<string>("SupplierID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MailAddress");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Customer", b =>
                {
                    b.OwnsOne("MovieMansterWebApp.ModelComponent.Address", "CustomerAddress", b1 =>
                        {
                            b1.Property<string>("CustomerID");

                            b1.Property<int>("ApartmentNumber");

                            b1.Property<string>("City");

                            b1.Property<string>("State");

                            b1.Property<string>("StreetName");

                            b1.Property<int>("ZipCode");

                            b1.ToTable("Customer");

                            b1.HasOne("MovieMansterWebApp.Models.Customer")
                                .WithOne("CustomerAddress")
                                .HasForeignKey("MovieMansterWebApp.ModelComponent.Address", "CustomerID")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Movie", b =>
                {
                    b.HasOne("MovieMansterWebApp.Models.Sale")
                        .WithMany("Movies")
                        .HasForeignKey("SaleID");

                    b.HasOne("MovieMansterWebApp.Models.StockOrder")
                        .WithMany("Movies")
                        .HasForeignKey("StockOrderID");

                    b.OwnsOne("MovieMansterWebApp.ModelComponent.Price", "UnitPrice", b1 =>
                        {
                            b1.Property<string>("MovieID");

                            b1.Property<float>("Retail");

                            b1.Property<float>("Wholesale");

                            b1.ToTable("Movie");

                            b1.HasOne("MovieMansterWebApp.Models.Movie")
                                .WithOne("UnitPrice")
                                .HasForeignKey("MovieMansterWebApp.ModelComponent.Price", "MovieID")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Sale", b =>
                {
                    b.HasOne("MovieMansterWebApp.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.StockOrder", b =>
                {
                    b.HasOne("MovieMansterWebApp.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID");
                });

            modelBuilder.Entity("MovieMansterWebApp.Models.Supplier", b =>
                {
                    b.OwnsOne("MovieMansterWebApp.ModelComponent.Address", "SupplierAddress", b1 =>
                        {
                            b1.Property<string>("SupplierID");

                            b1.Property<int>("ApartmentNumber");

                            b1.Property<string>("City");

                            b1.Property<string>("State");

                            b1.Property<string>("StreetName");

                            b1.Property<int>("ZipCode");

                            b1.ToTable("Supplier");

                            b1.HasOne("MovieMansterWebApp.Models.Supplier")
                                .WithOne("SupplierAddress")
                                .HasForeignKey("MovieMansterWebApp.ModelComponent.Address", "SupplierID")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

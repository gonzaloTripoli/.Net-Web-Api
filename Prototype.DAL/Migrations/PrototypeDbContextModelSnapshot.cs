﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prototype.DAL;

#nullable disable

namespace PrototypeApp.DAL.Migrations
{
    [DbContext(typeof(PrototypeDbContext))]
    partial class PrototypeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PrototypeApp.DAL.Model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Item", (string)null);
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("QuantityAvailable")
                        .HasColumnType("int");

                    b.Property<int>("itemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("itemId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Order", b =>
                {
                    b.HasOne("PrototypeApp.DAL.Model.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Product", b =>
                {
                    b.HasOne("PrototypeApp.DAL.Model.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId");

                    b.HasOne("PrototypeApp.DAL.Model.Item", "item")
                        .WithMany("Products")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("item");
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Item", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PrototypeApp.DAL.Model.Order", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

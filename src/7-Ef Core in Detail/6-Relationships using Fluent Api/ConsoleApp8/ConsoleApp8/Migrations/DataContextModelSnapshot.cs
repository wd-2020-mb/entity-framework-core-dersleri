﻿// <auto-generated />
using ConsoleApp8.Models.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp8.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CatId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<int>("PrId");

                    b.HasKey("Id");

                    b.HasIndex("PrId")
                        .IsUnique();

                    b.ToTable("ProductDetail");
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.SupplierProduct", b =>
                {
                    b.Property<int>("PId");

                    b.Property<int>("SId");

                    b.HasKey("PId", "SId");

                    b.HasIndex("SId");

                    b.ToTable("SupplierProduct");
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.Product", b =>
                {
                    b.HasOne("ConsoleApp8.Models.Relationships.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.ProductDetail", b =>
                {
                    b.HasOne("ConsoleApp8.Models.Relationships.Product", "Product")
                        .WithOne("ProductDetail")
                        .HasForeignKey("ConsoleApp8.Models.Relationships.ProductDetail", "PrId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ConsoleApp8.Models.Relationships.SupplierProduct", b =>
                {
                    b.HasOne("ConsoleApp8.Models.Relationships.Product", "Product")
                        .WithMany("SupplierProducts")
                        .HasForeignKey("PId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ConsoleApp8.Models.Relationships.Supplier", "Supplier")
                        .WithMany("SupplierProducts")
                        .HasForeignKey("SId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

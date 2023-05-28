﻿// <auto-generated />
using System;
using Diploma.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diploma.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230523153034_ffffff")]
    partial class ffffff
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diploma.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Guitars",
                            Url = "guitars"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Percussion",
                            Url = "percussion"
                        });
                });

            modelBuilder.Entity("Diploma.Domain.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "TestTestTestTest1",
                            Featured = true,
                            Image = "https://images.unsplash.com/photo-1638718619061-54b56803f459?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGpwZ3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=1000&q=60",
                            Name = "Guitar1"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "TestTestTestTest2",
                            Featured = false,
                            Image = "https://images.unsplash.com/photo-1638718619061-54b56803f459?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGpwZ3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=1000&q=60",
                            Name = "Guitar2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Description = "TestTestTestTest3",
                            Featured = true,
                            Image = "https://images.unsplash.com/photo-1638718619061-54b56803f459?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGpwZ3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=1000&q=60",
                            Name = "Drums1"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "TestTestTestTest4",
                            Featured = false,
                            Image = "https://images.unsplash.com/photo-1638718619061-54b56803f459?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8MTJ8fGpwZ3xlbnwwfHwwfHw%3D&auto=format&fit=crop&w=1000&q=60",
                            Name = "Drums2"
                        });
                });

            modelBuilder.Entity("Diploma.Domain.Entities.ItemType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ItemTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Black"
                        },
                        new
                        {
                            Id = 2,
                            Name = "White"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Red"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gray"
                        });
                });

            modelBuilder.Entity("Diploma.Domain.Entities.ItemVariant", b =>
                {
                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ItemTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("InitialPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId", "ItemTypeId");

                    b.HasIndex("ItemTypeId");

                    b.ToTable("ItemVariants");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ItemTypeId = 1,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 1,
                            ItemTypeId = 2,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 1,
                            ItemTypeId = 3,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 1,
                            ItemTypeId = 4,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 2,
                            ItemTypeId = 1,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 2,
                            ItemTypeId = 2,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 2,
                            ItemTypeId = 3,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 2,
                            ItemTypeId = 4,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 3,
                            ItemTypeId = 1,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 3,
                            ItemTypeId = 2,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 3,
                            ItemTypeId = 3,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 3,
                            ItemTypeId = 4,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 4,
                            ItemTypeId = 1,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 4,
                            ItemTypeId = 2,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 4,
                            ItemTypeId = 3,
                            InitialPrice = 170m,
                            Price = 100m
                        },
                        new
                        {
                            ItemId = 4,
                            ItemTypeId = 4,
                            InitialPrice = 170m,
                            Price = 100m
                        });
                });

            modelBuilder.Entity("Diploma.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Hash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Salt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Diploma.Domain.Entities.Item", b =>
                {
                    b.HasOne("Diploma.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Diploma.Domain.Entities.ItemVariant", b =>
                {
                    b.HasOne("Diploma.Domain.Entities.Item", "Item")
                        .WithMany("Variants")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diploma.Domain.Entities.ItemType", "ItemType")
                        .WithMany()
                        .HasForeignKey("ItemTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Item");

                    b.Navigation("ItemType");
                });

            modelBuilder.Entity("Diploma.Domain.Entities.Item", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}

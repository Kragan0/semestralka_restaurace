﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UTB.Restauracia.Infrastructure.Database;

#nullable disable

namespace UTB.Restauracia.Infrastructure.Migrations
{
    [DbContext(typeof(RestauraciaDbContext))]
    [Migration("20241216152151_FoodMenuMigracia")]
    partial class FoodMenuMigracia
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Favorites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Food");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Rezance s kečupom",
                            Icon = "...",
                            MenuId = 1,
                            Name = "Bolongske Spagheti",
                            Price = 120.0
                        },
                        new
                        {
                            Id = 2,
                            Description = "Syrová pizza",
                            Icon = "...",
                            MenuId = 1,
                            Name = "Pizza Margharita",
                            Price = 180.0
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pravda, chvíľu treba žut, ale chutia príjemne",
                            Icon = "...",
                            MenuId = 1,
                            Name = "Bryndzové Halušky",
                            Price = 240.0
                        });
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Menu");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Zakladne jedla"
                        });
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("OrderType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UsertId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsertId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.OrderItems", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuItemID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("foodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("foodId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("NumberOfGuests")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("SpecialRequest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.RestaurantTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte>("SeatCapacity")
                        .HasColumnType("tinyint unsigned");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RestaurantTable");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsAvailable = true,
                            SeatCapacity = (byte)4,
                            TableNumber = 1
                        },
                        new
                        {
                            Id = 2,
                            IsAvailable = true,
                            SeatCapacity = (byte)2,
                            TableNumber = 2
                        },
                        new
                        {
                            Id = 3,
                            IsAvailable = true,
                            SeatCapacity = (byte)4,
                            TableNumber = 3
                        });
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Favorites", b =>
                {
                    b.HasOne("UTB.Restauracia.Domain.Entities.Food", "Food")
                        .WithOne("Favorites")
                        .HasForeignKey("UTB.Restauracia.Domain.Entities.Favorites", "FoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTB.Restauracia.Domain.Entities.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Food", b =>
                {
                    b.HasOne("UTB.Restauracia.Domain.Entities.Menu", "Menu")
                        .WithMany("Foods")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Order", b =>
                {
                    b.HasOne("UTB.Restauracia.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UsertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.OrderItems", b =>
                {
                    b.HasOne("UTB.Restauracia.Domain.Entities.Order", "order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTB.Restauracia.Domain.Entities.Food", "food")
                        .WithMany("OrderItems")
                        .HasForeignKey("foodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("food");

                    b.Navigation("order");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Reservation", b =>
                {
                    b.HasOne("UTB.Restauracia.Domain.Entities.RestaurantTable", "RestaurantTable")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UTB.Restauracia.Domain.Entities.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RestaurantTable");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Food", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Menu", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.RestaurantTable", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("UTB.Restauracia.Domain.Entities.User", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Orders");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PresentationCreatorAPI.Data;

#nullable disable

namespace PresentationCreatorAPI.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240621095727_Initv2")]
    partial class Initv2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipientIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagesPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageType")
                        .HasColumnType("int");

                    b.Property<int>("PresentationId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PresentationId");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminCaption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Caption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Summa")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Presentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("PageCount")
                        .HasColumnType("tinyint");

                    b.Property<int>("Template")
                        .HasColumnType("int");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Presentation");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PresentationCount")
                        .HasColumnType("int");

                    b.Property<bool>("ReferalBonus")
                        .HasColumnType("bit");

                    b.Property<int>("ReferalId")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("TelegramId")
                        .HasColumnType("int");

                    b.Property<int>("TotalPayments")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 20000,
                            CreatedAt = new DateTime(2024, 6, 21, 9, 57, 26, 475, DateTimeKind.Unspecified).AddTicks(2749),
                            Email = "isroilov0905@gmail.com",
                            FullName = "Isroilov Ismoiljon",
                            IsVerified = true,
                            Password = "6724ce39c81234bc9a25eca98b634a94a913e514a2191371b63b30dd3869c754",
                            PhoneNumber = "+998997979898",
                            PresentationCount = 0,
                            ReferalBonus = false,
                            ReferalId = 0,
                            Role = 1,
                            TelegramId = 0,
                            TotalPayments = 0
                        });
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Notification", b =>
                {
                    b.HasOne("PresentationCreatorAPI.Entites.User", null)
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Page", b =>
                {
                    b.HasOne("PresentationCreatorAPI.Entites.Presentation", "Presentation")
                        .WithMany("Pages")
                        .HasForeignKey("PresentationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presentation");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Payment", b =>
                {
                    b.HasOne("PresentationCreatorAPI.Entites.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Presentation", b =>
                {
                    b.HasOne("PresentationCreatorAPI.Entites.User", "User")
                        .WithMany("Presentations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.Presentation", b =>
                {
                    b.Navigation("Pages");
                });

            modelBuilder.Entity("PresentationCreatorAPI.Entites.User", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Payments");

                    b.Navigation("Presentations");
                });
#pragma warning restore 612, 618
        }
    }
}

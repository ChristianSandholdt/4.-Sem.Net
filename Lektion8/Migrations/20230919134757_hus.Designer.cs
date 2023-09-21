﻿// <auto-generated />
using Lektion8.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Opgave8_1.Migrations
{
    [DbContext(typeof(BilContext))]
    [Migration("20230919134757_hus")]
    partial class hus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EjerHus", b =>
                {
                    b.Property<int>("HuseHusID")
                        .HasColumnType("int");

                    b.Property<int>("ejereEjerID")
                        .HasColumnType("int");

                    b.HasKey("HuseHusID", "ejereEjerID");

                    b.HasIndex("ejereEjerID");

                    b.ToTable("EjerHus");
                });

            modelBuilder.Entity("Lektion8.Bil", b =>
                {
                    b.Property<int>("BilID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BilID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EjerID")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BilID");

                    b.HasIndex("EjerID");

                    b.ToTable("biler");

                    b.HasData(
                        new
                        {
                            BilID = -1,
                            Age = 0,
                            Color = "Red",
                            EjerID = -1,
                            Manufacturer = "Volvo",
                            Plate = "BZ42056"
                        },
                        new
                        {
                            BilID = -2,
                            Age = 0,
                            Color = "Green",
                            EjerID = -2,
                            Manufacturer = "Audi",
                            Plate = "FG64254"
                        });
                });

            modelBuilder.Entity("Opgave8_1.Model.Ejer", b =>
                {
                    b.Property<int>("EjerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EjerID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EjerID");

                    b.ToTable("ejere");

                    b.HasData(
                        new
                        {
                            EjerID = -1,
                            Name = "Martin"
                        },
                        new
                        {
                            EjerID = -2,
                            Name = "Nehtin"
                        });
                });

            modelBuilder.Entity("Opgave8_1.Model.Hus", b =>
                {
                    b.Property<int>("HusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HusID"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EjerID")
                        .HasColumnType("int");

                    b.HasKey("HusID");

                    b.ToTable("huse");
                });

            modelBuilder.Entity("EjerHus", b =>
                {
                    b.HasOne("Opgave8_1.Model.Hus", null)
                        .WithMany()
                        .HasForeignKey("HuseHusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Opgave8_1.Model.Ejer", null)
                        .WithMany()
                        .HasForeignKey("ejereEjerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Lektion8.Bil", b =>
                {
                    b.HasOne("Opgave8_1.Model.Ejer", "Ejer")
                        .WithMany("biler")
                        .HasForeignKey("EjerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ejer");
                });

            modelBuilder.Entity("Opgave8_1.Model.Ejer", b =>
                {
                    b.Navigation("biler");
                });
#pragma warning restore 612, 618
        }
    }
}

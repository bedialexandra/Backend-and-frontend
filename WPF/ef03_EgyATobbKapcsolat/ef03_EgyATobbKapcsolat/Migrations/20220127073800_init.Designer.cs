﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ef03_EgyATobbKapcsolat;

namespace ef03_EgyATobbKapcsolat.Migrations
{
    [DbContext(typeof(IskolaContext))]
    [Migration("20220127073800_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("ef03_EgyATobbKapcsolat.Osztaly", b =>
                {
                    b.Property<int>("osztalyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("osztalyFonok")
                        .HasColumnType("longtext");

                    b.Property<string>("osztalyNev")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasKey("osztalyId");

                    b.ToTable("Osztalyok");
                });

            modelBuilder.Entity("ef03_EgyATobbKapcsolat.Tanulo", b =>
                {
                    b.Property<int>("tanuloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("osztalyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("szuletesiDatum")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("tanuloNev")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("tanuloId");

                    b.HasIndex("osztalyId");

                    b.ToTable("Tanulok");
                });

            modelBuilder.Entity("ef03_EgyATobbKapcsolat.Tanulo", b =>
                {
                    b.HasOne("ef03_EgyATobbKapcsolat.Osztaly", "Osztaly")
                        .WithMany("Tanulo")
                        .HasForeignKey("osztalyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Osztaly");
                });

            modelBuilder.Entity("ef03_EgyATobbKapcsolat.Osztaly", b =>
                {
                    b.Navigation("Tanulo");
                });
#pragma warning restore 612, 618
        }
    }
}

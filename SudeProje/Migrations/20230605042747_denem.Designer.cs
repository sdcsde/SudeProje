﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SudeProje.Models;

#nullable disable

namespace SudeProje.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230605042747_denem")]
    partial class denem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SudeProje.Models.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersID"));

                    b.Property<string>("DersAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DersOgretmen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DersID");

                    b.ToTable("Derss");
                });

            modelBuilder.Entity("SudeProje.Models.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"));

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("KullaniciAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KullaniciID");

                    b.HasIndex("DersID");

                    b.ToTable("Kullanicis");
                });

            modelBuilder.Entity("SudeProje.Models.Sertfika", b =>
                {
                    b.Property<int>("SertfikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SertfikaID"));

                    b.Property<int?>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("SertfikaAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VerilisTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("SertfikaID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Sertfikas");
                });

            modelBuilder.Entity("SudeProje.Models.Uygulamali", b =>
                {
                    b.Property<int>("UygulamaliID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UygulamaliID"));

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<string>("UygulamaliAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UygulamaliDetay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UygulamaliOgretmen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UygulamaliID");

                    b.HasIndex("DersID");

                    b.ToTable("Uygulamalis");
                });

            modelBuilder.Entity("SudeProje.Models.Kullanici", b =>
                {
                    b.HasOne("SudeProje.Models.Ders", "Ders")
                        .WithMany("Kullanicis")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");
                });

            modelBuilder.Entity("SudeProje.Models.Sertfika", b =>
                {
                    b.HasOne("SudeProje.Models.Kullanici", null)
                        .WithMany("Sertfikas")
                        .HasForeignKey("KullaniciID");
                });

            modelBuilder.Entity("SudeProje.Models.Uygulamali", b =>
                {
                    b.HasOne("SudeProje.Models.Ders", "Ders")
                        .WithMany("Uygulamalis")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");
                });

            modelBuilder.Entity("SudeProje.Models.Ders", b =>
                {
                    b.Navigation("Kullanicis");

                    b.Navigation("Uygulamalis");
                });

            modelBuilder.Entity("SudeProje.Models.Kullanici", b =>
                {
                    b.Navigation("Sertfikas");
                });
#pragma warning restore 612, 618
        }
    }
}

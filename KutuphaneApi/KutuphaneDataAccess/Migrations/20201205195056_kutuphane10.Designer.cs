﻿// <auto-generated />
using KutuphaneDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KutuphaneDataAccess.Migrations
{
    [DbContext(typeof(KutuphaneContext))]
    [Migration("20201205195056_kutuphane10")]
    partial class kutuphane10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("KutuphaneDataAccess.Model.Kitap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("kitap_adi")
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4")
                        .HasMaxLength(60);

                    b.Property<int>("sayfaSayisi")
                        .HasColumnType("int");

                    b.Property<int>("yazar_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("kitaps");
                });

            modelBuilder.Entity("KutuphaneDataAccess.Model.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("okunan_KitapSayi")
                        .HasColumnType("int");

                    b.Property<string>("uye_Adi")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("uye_Soy_Adi")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Uyes");
                });

            modelBuilder.Entity("KutuphaneDataAccess.Model.Yazar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("yazar_Ad_Soyad")
                        .HasColumnType("varchar(65) CHARACTER SET utf8mb4")
                        .HasMaxLength(65);

                    b.Property<int>("yazar_Kitap_Sayisi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Yazars");
                });
#pragma warning restore 612, 618
        }
    }
}

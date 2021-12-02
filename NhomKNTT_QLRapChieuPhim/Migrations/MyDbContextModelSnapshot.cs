﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyRapChieuPhim.Entitites;

namespace NhomKNTT_QLRapChieuPhim.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NhomKNTT_QLRapChieuPhim.Entitity.DatVeXemPhim", b =>
                {
                    b.Property<int>("MaDatVe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LichChieuPhim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SoDienThoai")
                        .HasColumnType("float")
                        .HasMaxLength(50);

                    b.Property<string>("SoLuongChoTrong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDatVe");

                    b.ToTable("DatVe");
                });

            modelBuilder.Entity("QuanLyRapChieuPhim.Entitiies.Rap", b =>
                {
                    b.Property<int>("MaRap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("SoChoTrong")
                        .HasColumnType("float");

                    b.Property<string>("TenRap")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MaRap");

                    b.ToTable("Rap");
                });

            modelBuilder.Entity("QuanLyRapChieuPhim.Entitites.DanhSachPhim", b =>
                {
                    b.Property<int>("MaPhim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RapMaRap")
                        .HasColumnType("int");

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<double>("ThoiLuong")
                        .HasColumnType("float");

                    b.HasKey("MaPhim");

                    b.HasIndex("RapMaRap");

                    b.ToTable("DanhSachPhim");
                });

            modelBuilder.Entity("QuanLyRapChieuPhim.Entitites.LichChieuPhim", b =>
                {
                    b.Property<int>("MaLichChieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("GioCongChieu")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RapMaRap")
                        .HasColumnType("int");

                    b.Property<string>("TenPhim")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TenRap")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLichChieu");

                    b.HasIndex("RapMaRap");

                    b.ToTable("LichChieuPhim");
                });

            modelBuilder.Entity("QuanLyRapChieuPhim.Entitites.DanhSachPhim", b =>
                {
                    b.HasOne("QuanLyRapChieuPhim.Entitiies.Rap", null)
                        .WithMany("danhSachPhims")
                        .HasForeignKey("RapMaRap");
                });

            modelBuilder.Entity("QuanLyRapChieuPhim.Entitites.LichChieuPhim", b =>
                {
                    b.HasOne("QuanLyRapChieuPhim.Entitiies.Rap", null)
                        .WithMany("lichChieuPhims")
                        .HasForeignKey("RapMaRap");
                });
#pragma warning restore 612, 618
        }
    }
}
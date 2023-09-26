﻿// <auto-generated />
using System;
using BrunsonHome.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BrunsonHome.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230926132907_isDeletedTest")]
    partial class isDeletedTest
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BrunsonHome.Shared.Entities.FootTrim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HorseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TrimDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HorseId");

                    b.ToTable("FootTrims");
                });

            modelBuilder.Entity("BrunsonHome.Shared.Entities.Horse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("BarnName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RecentTrimId")
                        .HasColumnType("int");

                    b.Property<int?>("RecentWormingId")
                        .HasColumnType("int");

                    b.Property<string>("RegisteredName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RecentTrimId");

                    b.HasIndex("RecentWormingId");

                    b.ToTable("Horses");
                });

            modelBuilder.Entity("BrunsonHome.Shared.Entities.Worming", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HorseId")
                        .HasColumnType("int");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("WormingDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("HorseId");

                    b.ToTable("Wormings");
                });

            modelBuilder.Entity("BrunsonHome.Shared.Entities.FootTrim", b =>
                {
                    b.HasOne("BrunsonHome.Shared.Entities.Horse", null)
                        .WithMany("FootTrims")
                        .HasForeignKey("HorseId");
                });

            modelBuilder.Entity("BrunsonHome.Shared.Entities.Horse", b =>
                {
                    b.HasOne("BrunsonHome.Shared.Entities.FootTrim", "RecentTrim")
                        .WithMany()
                        .HasForeignKey("RecentTrimId");

                    b.HasOne("BrunsonHome.Shared.Entities.Worming", "RecentWorming")
                        .WithMany()
                        .HasForeignKey("RecentWormingId");

                    b.Navigation("RecentTrim");

                    b.Navigation("RecentWorming");
                });

            modelBuilder.Entity("BrunsonHome.Shared.Entities.Worming", b =>
                {
                    b.HasOne("BrunsonHome.Shared.Entities.Horse", null)
                        .WithMany("Wormings")
                        .HasForeignKey("HorseId");
                });

            modelBuilder.Entity("BrunsonHome.Shared.Entities.Horse", b =>
                {
                    b.Navigation("FootTrims");

                    b.Navigation("Wormings");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using FlFoxShop.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FlFoxShop.DataBase.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20231122122054_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FlFoxShop.Common.DBModels.Brand", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Country")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("shop_Brands", (string)null);
                });

            modelBuilder.Entity("FlFoxShop.Common.DBModels.ProductPurpose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("shop_Product_Purposes", (string)null);
                });

            modelBuilder.Entity("FlFoxShop.Common.DBModels.TextileModels.Textile", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("BrandId")
                        .HasColumnType("bigint");

                    b.Property<long?>("BrendId")
                        .HasColumnType("bigint");

                    b.Property<string>("Color")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CreateddById")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)");

                    b.Property<string>("DrawingTextDescription")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<long?>("ProductPurposeId")
                        .HasColumnType("bigint");

                    b.Property<int?>("ProductPurposeId1")
                        .HasColumnType("integer");

                    b.Property<string>("SmallDescription")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("TextileBase")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTimeOffset>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UpdatedById")
                        .HasColumnType("uuid");

                    b.Property<string>("VendorCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CreateddById");

                    b.HasIndex("ProductPurposeId1");

                    b.HasIndex("UpdatedById");

                    b.ToTable("shop_Textiles", (string)null);
                });

            modelBuilder.Entity("FlFoxShop.Common.DBModels.TextileModels.TextileType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.ToTable("shop_Textile_Types", (string)null);
                });

            modelBuilder.Entity("FlFoxShop.Common.DBModels.UsersModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("shop_Users", (string)null);
                });

            modelBuilder.Entity("FlFoxShop.Common.DBModels.TextileModels.Textile", b =>
                {
                    b.HasOne("FlFoxShop.Common.DBModels.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.HasOne("FlFoxShop.Common.DBModels.UsersModels.User", "CreateddBy")
                        .WithMany()
                        .HasForeignKey("CreateddById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlFoxShop.Common.DBModels.ProductPurpose", "ProductPurpose")
                        .WithMany()
                        .HasForeignKey("ProductPurposeId1");

                    b.HasOne("FlFoxShop.Common.DBModels.UsersModels.User", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("CreateddBy");

                    b.Navigation("ProductPurpose");

                    b.Navigation("UpdatedBy");
                });
#pragma warning restore 612, 618
        }
    }
}

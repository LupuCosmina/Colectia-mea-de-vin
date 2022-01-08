﻿// <auto-generated />
using System;
using Colectia_mea_de_vin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Colectia_mea_de_vin.Migrations
{
    [DbContext(typeof(Colectia_mea_de_vinContext))]
    [Migration("20220108114603_DataCumpararii")]
    partial class DataCumpararii
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Colectia_mea_de_vin.Models.Vin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("An")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCumpararii")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(6, 2)");

                    b.Property<string>("Producator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regiune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Vin");
                });
#pragma warning restore 612, 618
        }
    }
}

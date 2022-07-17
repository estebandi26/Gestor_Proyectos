﻿// <auto-generated />
using System;
using Gestor_Proyectos.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestor_Proyectos.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220717231903_AddTableRequerimiento")]
    partial class AddTableRequerimiento
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gestor_Proyectos.API.Data.Entities.Requerimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Aplicativo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle_Req")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eviden_Mejora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Entrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Reg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Indicador1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indicador2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Indicador3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre_Iniciativa")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Objetivo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objetivo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Objetivo3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Periodo_Ent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Ppto_Aprox")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Ppto_Area")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sustentac_Req")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Nombre_Iniciativa")
                        .IsUnique();

                    b.ToTable("Requerimientos");
                });
#pragma warning restore 612, 618
        }
    }
}
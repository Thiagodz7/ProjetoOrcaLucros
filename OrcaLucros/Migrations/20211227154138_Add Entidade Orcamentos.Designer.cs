﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrcaLucros.Data;

namespace OrcaLucros.Migrations
{
    [DbContext(typeof(orcamentoContext))]
    [Migration("20211227154138_Add Entidade Orcamentos")]
    partial class AddEntidadeOrcamentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrcaLucros.Models.Orcamentos", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Dt_Entrada")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Dt_Saida")
                        .HasColumnType("datetime2");

                    b.Property<float>("Entrada")
                        .HasColumnType("real");

                    b.Property<float>("Saida")
                        .HasColumnType("real");

                    b.Property<float>("SaldoInicial")
                        .HasColumnType("real");

                    b.Property<float>("ValorFinal")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Orcamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
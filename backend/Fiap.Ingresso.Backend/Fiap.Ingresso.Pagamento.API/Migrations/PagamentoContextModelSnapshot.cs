﻿// <auto-generated />
using System;
using Fiap.Ingresso.Pagamento.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Ingresso.Pagamento.API.Migrations
{
    [DbContext(typeof(PagamentoContext))]
    partial class PagamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Ingresso.Pagamento.API.Domain.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoVerificador")
                        .HasColumnType("varchar(3)");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("Date");

                    b.Property<string>("IngressoId")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LinhaDigitavel")
                        .HasColumnType("varchar(150)");

                    b.Property<string>("NomeCartao")
                        .HasColumnType("varchar(60)");

                    b.Property<string>("NumeroCartao")
                        .HasColumnType("varchar(40)");

                    b.Property<int>("PagamentoValido")
                        .HasColumnType("int");

                    b.Property<int>("TipoPagamento")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorPagamento")
                        .HasColumnType("numeric");

                    b.Property<string>("VencimentoCartao")
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });
#pragma warning restore 612, 618
        }
    }
}

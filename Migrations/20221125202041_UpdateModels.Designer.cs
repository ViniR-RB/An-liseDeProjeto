﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using prova_AnaliseProjeto.Models;

#nullable disable

namespace prova_AnaliseProjeto.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221125202041_UpdateModels")]
    partial class UpdateModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Consumidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Consumidor");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("integer");

                    b.Property<double?>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Pagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pagamento");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConsumidorId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConsumidorId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("PedidoId")
                        .HasColumnType("integer");

                    b.Property<string>("descricao")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Boleto", b =>
                {
                    b.HasBaseType("prova_AnaliseProjeto.Models.Pagamento");

                    b.HasDiscriminator().HasValue("Boleto");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.CartaoDeCredito", b =>
                {
                    b.HasBaseType("prova_AnaliseProjeto.Models.Pagamento");

                    b.Property<string>("numero")
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("CartaoDeCredito");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Pagamento", b =>
                {
                    b.HasOne("prova_AnaliseProjeto.Models.Pedido", "Pedido")
                        .WithOne("Pagamento")
                        .HasForeignKey("prova_AnaliseProjeto.Models.Pagamento", "PedidoId");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Pedido", b =>
                {
                    b.HasOne("prova_AnaliseProjeto.Models.Consumidor", "Consumidor")
                        .WithMany("Pedido")
                        .HasForeignKey("ConsumidorId");

                    b.Navigation("Consumidor");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Produto", b =>
                {
                    b.HasOne("prova_AnaliseProjeto.Models.Pedido", "Pedido")
                        .WithMany("Produto")
                        .HasForeignKey("PedidoId");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Consumidor", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("prova_AnaliseProjeto.Models.Pedido", b =>
                {
                    b.Navigation("Pagamento");

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}

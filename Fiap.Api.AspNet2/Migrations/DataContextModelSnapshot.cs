﻿// <auto-generated />
using System;
using Fiap.Api.AspNet2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Api.AspNet2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Api.AspNet2.Models.CategoriaModel", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaId = 1,
                            NomeCategoria = "Smartphone"
                        },
                        new
                        {
                            CategoriaId = 2,
                            NomeCategoria = "Televisor"
                        },
                        new
                        {
                            CategoriaId = 3,
                            NomeCategoria = "Notebook"
                        },
                        new
                        {
                            CategoriaId = 4,
                            NomeCategoria = "Tablet"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet2.Models.MarcaModel", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeMarca")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");

                    b.HasData(
                        new
                        {
                            MarcaId = 1,
                            NomeMarca = "Marca 1"
                        },
                        new
                        {
                            MarcaId = 2,
                            NomeMarca = "Marca 2"
                        },
                        new
                        {
                            MarcaId = 3,
                            NomeMarca = "Marca 3"
                        },
                        new
                        {
                            MarcaId = 4,
                            NomeMarca = "Marca 4"
                        },
                        new
                        {
                            MarcaId = 5,
                            NomeMarca = "Marca 5"
                        },
                        new
                        {
                            MarcaId = 6,
                            NomeMarca = "Marca 6"
                        },
                        new
                        {
                            MarcaId = 7,
                            NomeMarca = "Marca 7"
                        },
                        new
                        {
                            MarcaId = 8,
                            NomeMarca = "Marca 8"
                        },
                        new
                        {
                            MarcaId = 9,
                            NomeMarca = "Marca 9"
                        },
                        new
                        {
                            MarcaId = 10,
                            NomeMarca = "Marca 10"
                        },
                        new
                        {
                            MarcaId = 11,
                            NomeMarca = "Marca 11"
                        },
                        new
                        {
                            MarcaId = 12,
                            NomeMarca = "Marca 12"
                        },
                        new
                        {
                            MarcaId = 13,
                            NomeMarca = "Marca 13"
                        },
                        new
                        {
                            MarcaId = 14,
                            NomeMarca = "Marca 14"
                        },
                        new
                        {
                            MarcaId = 15,
                            NomeMarca = "Marca 15"
                        },
                        new
                        {
                            MarcaId = 16,
                            NomeMarca = "Marca 16"
                        },
                        new
                        {
                            MarcaId = 17,
                            NomeMarca = "Marca 17"
                        },
                        new
                        {
                            MarcaId = 18,
                            NomeMarca = "Marca 18"
                        },
                        new
                        {
                            MarcaId = 19,
                            NomeMarca = "Marca 19"
                        },
                        new
                        {
                            MarcaId = 20,
                            NomeMarca = "Marca 20"
                        },
                        new
                        {
                            MarcaId = 21,
                            NomeMarca = "Marca 21"
                        },
                        new
                        {
                            MarcaId = 22,
                            NomeMarca = "Marca 22"
                        },
                        new
                        {
                            MarcaId = 23,
                            NomeMarca = "Marca 23"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet2.Models.ProdutoModel", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caracteristicas")
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sku")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 2,
                            Caracteristicas = "",
                            CategoriaId = 1,
                            DataLancamento = new DateTime(2022, 3, 10, 23, 27, 38, 428, DateTimeKind.Local).AddTicks(910),
                            Descricao = "Apple iPhone 11",
                            MarcaId = 1,
                            Nome = "iPhone 11",
                            Preco = 11000m,
                            Sku = "SKUIPH11"
                        },
                        new
                        {
                            ProdutoId = 3,
                            Caracteristicas = "",
                            CategoriaId = 1,
                            DataLancamento = new DateTime(2022, 3, 10, 23, 27, 38, 453, DateTimeKind.Local).AddTicks(8950),
                            Descricao = "Apple iPhone 12",
                            MarcaId = 2,
                            Nome = "iPhone 12",
                            Preco = 12000m,
                            Sku = "SKUIPH12"
                        },
                        new
                        {
                            ProdutoId = 4,
                            Caracteristicas = "",
                            CategoriaId = 1,
                            DataLancamento = new DateTime(2022, 3, 10, 23, 27, 38, 453, DateTimeKind.Local).AddTicks(9400),
                            Descricao = "Apple iPhone 13",
                            MarcaId = 3,
                            Nome = "iPhone 13",
                            Preco = 12000m,
                            Sku = "SKUIPH13"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet2.Models.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Regra")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            NomeUsuario = "Admin Senior",
                            Regra = "Senior",
                            Senha = "123456"
                        },
                        new
                        {
                            UsuarioId = 2,
                            NomeUsuario = "Admin Pleno",
                            Regra = "Pleno",
                            Senha = "123456"
                        },
                        new
                        {
                            UsuarioId = 3,
                            NomeUsuario = "Admin Junior",
                            Regra = "Junior",
                            Senha = "123456"
                        });
                });

            modelBuilder.Entity("Fiap.Api.AspNet2.Models.ProdutoModel", b =>
                {
                    b.HasOne("Fiap.Api.AspNet2.Models.CategoriaModel", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Api.AspNet2.Models.MarcaModel", "Marca")
                        .WithMany()
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });
#pragma warning restore 612, 618
        }
    }
}

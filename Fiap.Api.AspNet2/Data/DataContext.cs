using System;
using Fiap.Api.AspNet2.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet2.Data
{
    public class DataContext : DbContext
    {

        public DbSet<CategoriaModel> Categorias { get; set; }

        public DbSet<MarcaModel> Marcas { get; set; }

        public DbSet<ProdutoModel> Produtos { get; set; }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DataContext()
        {
        }

        public DataContext( DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarcaModel>().HasData(
                new MarcaModel(8, "Marca 8"),
                new MarcaModel(9, "Marca 9"),
                new MarcaModel(10, "Marca 10"),
                new MarcaModel(11, "Marca 11"),
                new MarcaModel(12, "Marca 12"),
                new MarcaModel(13, "Marca 13"),
                new MarcaModel(14, "Marca 14"),
                new MarcaModel(15, "Marca 15"),
                new MarcaModel(16, "Marca 16"),
                new MarcaModel(17, "Marca 17"),
                new MarcaModel(18, "Marca 18"),
                new MarcaModel(19, "Marca 19"),
                new MarcaModel(20, "Marca 20"),
                new MarcaModel(21, "Marca 21"),
                new MarcaModel(22, "Marca 22"),
                new MarcaModel(23, "Marca 23")
            );

            modelBuilder.Entity<CategoriaModel>().HasData(
                new CategoriaModel(1, "Smartphone"),
                new CategoriaModel(2, "Televisor"),
                new CategoriaModel(3, "Notebook"),
                new CategoriaModel(4, "Tablet")
            );

            modelBuilder.Entity<ProdutoModel>().HasData(
                new ProdutoModel(1, "iPhone 12", "SKUIPH12", "Apple iPhone 12", 5000, "", DateTime.Now, 1, 1)
            );

            modelBuilder.Entity<UsuarioModel>().HasData(
                new UsuarioModel(1, "Admin Senior", "123456", "Senior"),
                new UsuarioModel(2, "Admin Pleno", "123456", "Pleno"),
                new UsuarioModel(3, "Admin Junior", "123456", "Junior")
            );


            base.OnModelCreating(modelBuilder);
        }
    }
}

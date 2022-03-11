using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Api.AspNet2.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.CategoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeMarca = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Regra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Caracteristicas = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: true),
                    DataLancamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "CategoriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaId", "NomeCategoria" },
                values: new object[,]
                {
                    { 1, "Smartphone" },
                    { 2, "Televisor" },
                    { 3, "Notebook" },
                    { 4, "Tablet" }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "MarcaId", "NomeMarca" },
                values: new object[,]
                {
                    { 23, "Marca 23" },
                    { 22, "Marca 22" },
                    { 21, "Marca 21" },
                    { 20, "Marca 20" },
                    { 19, "Marca 19" },
                    { 18, "Marca 18" },
                    { 17, "Marca 17" },
                    { 16, "Marca 16" },
                    { 15, "Marca 15" },
                    { 14, "Marca 14" },
                    { 13, "Marca 13" },
                    { 11, "Marca 11" },
                    { 10, "Marca 10" },
                    { 9, "Marca 9" },
                    { 8, "Marca 8" },
                    { 7, "Marca 7" },
                    { 6, "Marca 6" },
                    { 5, "Marca 5" },
                    { 4, "Marca 4" },
                    { 3, "Marca 3" },
                    { 2, "Marca 2" },
                    { 1, "Marca 1" },
                    { 12, "Marca 12" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "NomeUsuario", "Regra", "Senha" },
                values: new object[,]
                {
                    { 2, "Admin Pleno", "Pleno", "123456" },
                    { 1, "Admin Senior", "Senior", "123456" },
                    { 3, "Admin Junior", "Junior", "123456" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Caracteristicas", "CategoriaId", "DataLancamento", "Descricao", "MarcaId", "Nome", "Preco", "Sku" },
                values: new object[] { 2, "", 1, new DateTime(2022, 3, 10, 23, 27, 38, 428, DateTimeKind.Local).AddTicks(910), "Apple iPhone 11", 1, "iPhone 11", 11000m, "SKUIPH11" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Caracteristicas", "CategoriaId", "DataLancamento", "Descricao", "MarcaId", "Nome", "Preco", "Sku" },
                values: new object[] { 3, "", 1, new DateTime(2022, 3, 10, 23, 27, 38, 453, DateTimeKind.Local).AddTicks(8950), "Apple iPhone 12", 2, "iPhone 12", 12000m, "SKUIPH12" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Caracteristicas", "CategoriaId", "DataLancamento", "Descricao", "MarcaId", "Nome", "Preco", "Sku" },
                values: new object[] { 4, "", 1, new DateTime(2022, 3, 10, 23, 27, 38, 453, DateTimeKind.Local).AddTicks(9400), "Apple iPhone 13", 3, "iPhone 13", 12000m, "SKUIPH13" });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_MarcaId",
                table: "Produtos",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}

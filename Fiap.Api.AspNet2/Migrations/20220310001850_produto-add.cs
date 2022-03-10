using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Api.AspNet2.Migrations
{
    public partial class produtoadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataLancamento",
                value: new DateTime(2022, 3, 9, 21, 18, 49, 170, DateTimeKind.Local).AddTicks(330));

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "Caracteristicas", "CategoriaId", "DataLancamento", "Descricao", "MarcaId", "Nome", "Preco", "Sku" },
                values: new object[,]
                {
                    { 2, "", 1, new DateTime(2022, 3, 9, 21, 18, 49, 196, DateTimeKind.Local).AddTicks(3120), "Apple iPhone 11", 8, "iPhone 11", 11000m, "SKUIPH11" },
                    { 3, "", 1, new DateTime(2022, 3, 9, 21, 18, 49, 196, DateTimeKind.Local).AddTicks(3500), "Apple iPhone 12", 9, "iPhone 12", 12000m, "SKUIPH12" },
                    { 4, "", 1, new DateTime(2022, 3, 9, 21, 18, 49, 196, DateTimeKind.Local).AddTicks(3510), "Apple iPhone 13", 10, "iPhone 13", 12000m, "SKUIPH13" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataLancamento",
                value: new DateTime(2022, 3, 5, 15, 4, 40, 300, DateTimeKind.Local).AddTicks(9190));
        }
    }
}

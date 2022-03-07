using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Api.AspNet2.Migrations
{
    public partial class marcainicitialload2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 4);

            migrationBuilder.AlterColumn<string>(
                name: "NomeMarca",
                table: "Marcas",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "MarcaId", "NomeMarca" },
                values: new object[,]
                {
                    { 8, "Marca 8" },
                    { 22, "Marca 22" },
                    { 21, "Marca 21" },
                    { 20, "Marca 20" },
                    { 19, "Marca 19" },
                    { 18, "Marca 18" },
                    { 17, "Marca 17" },
                    { 23, "Marca 23" },
                    { 16, "Marca 16" },
                    { 14, "Marca 14" },
                    { 13, "Marca 13" },
                    { 12, "Marca 12" },
                    { 11, "Marca 11" },
                    { 10, "Marca 10" },
                    { 9, "Marca 9" },
                    { 15, "Marca 15" }
                });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataLancamento",
                value: new DateTime(2022, 3, 5, 15, 4, 40, 300, DateTimeKind.Local).AddTicks(9190));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Marcas",
                keyColumn: "MarcaId",
                keyValue: 23);

            migrationBuilder.AlterColumn<string>(
                name: "NomeMarca",
                table: "Marcas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "MarcaId", "NomeMarca" },
                values: new object[,]
                {
                    { 1, "Apple" },
                    { 2, "Samsung" },
                    { 3, "Google" },
                    { 4, "Xiaomi" }
                });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                column: "DataLancamento",
                value: new DateTime(2022, 3, 5, 10, 53, 11, 118, DateTimeKind.Local).AddTicks(9290));
        }
    }
}

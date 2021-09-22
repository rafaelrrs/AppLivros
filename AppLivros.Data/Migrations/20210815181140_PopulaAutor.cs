using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLivros.API.Migrations
{
    public partial class PopulaAutor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Email", "Nascimento", "Nome", "UltimoNome" },
                values: new object[] { new Guid("ed9a49bf-b047-4c17-9992-29a23ff68f5b"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafael", "Silva" });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Email", "Nascimento", "Nome", "UltimoNome" },
                values: new object[] { new Guid("86126adb-2038-4502-8227-a374d81b72ce"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafaaa", "Silva" });

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Email", "Nascimento", "Nome", "UltimoNome" },
                values: new object[] { new Guid("6c441d4d-cb9b-4716-a607-ecc030c8456e"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Leafar", "Silva" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("6c441d4d-cb9b-4716-a607-ecc030c8456e"));

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("86126adb-2038-4502-8227-a374d81b72ce"));

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("ed9a49bf-b047-4c17-9992-29a23ff68f5b"));
        }
    }
}

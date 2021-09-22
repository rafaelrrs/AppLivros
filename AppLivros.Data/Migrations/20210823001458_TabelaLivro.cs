using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLivros.API.Migrations
{
    public partial class TabelaLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Autores_AutorsId",
                table: "AutorLivro");

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("1f179997-38a7-4552-b194-329fcec43882"));

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("c8d9f4f3-a74e-44f7-b479-ce86ae278333"));

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("ee55c791-f53e-441e-bea5-7633cc6fbb3f"));

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: new Guid("13750380-3d1d-4118-914d-702bb3571b5e"));

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: new Guid("e0f9f132-ad8a-412c-89ae-f7a06d97fd54"));

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: new Guid("f8aa97a9-a772-4d00-bd8c-758b8666b515"));

            migrationBuilder.RenameColumn(
                name: "AutorsId",
                table: "AutorLivro",
                newName: "AutoresId");

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Email", "Nascimento", "Nome", "UltimoNome" },
                values: new object[,]
                {
                    { new Guid("ab1bae25-c081-493e-b7f6-99cd738b057d"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafael", "Silva" },
                    { new Guid("95b4ccc7-0257-4773-a0d1-caa006c53779"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafaaa", "Silva" },
                    { new Guid("b586dcf4-f7ae-4d03-9bc6-2b6e4b91e9d1"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Leafar", "Silva" }
                });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "Id", "Ano", "ISBN", "Titulo" },
                values: new object[,]
                {
                    { new Guid("6514a73e-7202-43c8-a72d-da356c1f52df"), 2000, "8535902775", "C# é legal" },
                    { new Guid("ee06cd80-469c-4a5f-9278-c00b6fdac362"), 1997, "8535902775", ".NET é legal" },
                    { new Guid("200fdbf5-3343-4325-b19d-a727645062a2"), 1998, "8535902775", "SQL Server é legal" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Autores_AutoresId",
                table: "AutorLivro",
                column: "AutoresId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorLivro_Autores_AutoresId",
                table: "AutorLivro");

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("95b4ccc7-0257-4773-a0d1-caa006c53779"));

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("ab1bae25-c081-493e-b7f6-99cd738b057d"));

            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: new Guid("b586dcf4-f7ae-4d03-9bc6-2b6e4b91e9d1"));

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: new Guid("200fdbf5-3343-4325-b19d-a727645062a2"));

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: new Guid("6514a73e-7202-43c8-a72d-da356c1f52df"));

            migrationBuilder.DeleteData(
                table: "Livros",
                keyColumn: "Id",
                keyValue: new Guid("ee06cd80-469c-4a5f-9278-c00b6fdac362"));

            migrationBuilder.RenameColumn(
                name: "AutoresId",
                table: "AutorLivro",
                newName: "AutorsId");

            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "Email", "Nascimento", "Nome", "UltimoNome" },
                values: new object[,]
                {
                    { new Guid("1f179997-38a7-4552-b194-329fcec43882"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafael", "Silva" },
                    { new Guid("ee55c791-f53e-441e-bea5-7633cc6fbb3f"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafaaa", "Silva" },
                    { new Guid("c8d9f4f3-a74e-44f7-b479-ce86ae278333"), "rafa@gmail.com", new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Leafar", "Silva" }
                });

            migrationBuilder.InsertData(
                table: "Livros",
                columns: new[] { "Id", "Ano", "ISBN", "Titulo" },
                values: new object[,]
                {
                    { new Guid("e0f9f132-ad8a-412c-89ae-f7a06d97fd54"), 2000, "8535902775", "C# é legal" },
                    { new Guid("f8aa97a9-a772-4d00-bd8c-758b8666b515"), 1997, "8535902775", ".NET é legal" },
                    { new Guid("13750380-3d1d-4118-914d-702bb3571b5e"), 1998, "8535902775", "SQL Server é legal" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AutorLivro_Autores_AutorsId",
                table: "AutorLivro",
                column: "AutorsId",
                principalTable: "Autores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

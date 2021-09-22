using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppLivros.API.Migrations
{
    public partial class PopulaLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AutorLivro",
                columns: table => new
                {
                    AutorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LivrosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLivro", x => new { x.AutorsId, x.LivrosId });
                    table.ForeignKey(
                        name: "FK_AutorLivro_Autores_AutorsId",
                        column: x => x.AutorsId,
                        principalTable: "Autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLivro_Livros_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivro_LivrosId",
                table: "AutorLivro",
                column: "LivrosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLivro");

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
    }
}

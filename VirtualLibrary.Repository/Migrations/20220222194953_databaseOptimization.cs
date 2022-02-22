using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualLibrary.Repository.Migrations
{
    public partial class databaseOptimization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorBook");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("2e48902b-dda6-4b74-85f6-3025089eb0d9"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("ea61dabb-8237-4675-9b0a-925e2f95e2cb"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("f7c93d0c-ea2e-489b-870f-089b333ef5ed"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("8224dcf3-3379-4a01-aee2-6444841bfa45"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("9a3983e7-2976-4823-835d-6eba40f2e44f"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("b97b67a7-85a8-4b26-990d-65ca398ccbab"));

            migrationBuilder.AddColumn<Guid>(
                name: "BookId",
                table: "Authors",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "BookId", "Email", "Gender", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("e5774dd4-5f30-44ac-b7e8-9ab1ed49f995"), new DateTime(2008, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "caio@gmail.com", "Male", "Caio", "2625929829825" },
                    { new Guid("0f2a0a22-f7b6-4c71-a1bb-d20c5caf81a2"), new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fernanda@gmail.com", "Female", "Fernanda", "498749841984" },
                    { new Guid("1e2bd0a0-1cea-445c-bd67-d69e3878eac6"), new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gabriel@gmail.com", "Male", "Gabriel", "198493232312" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("c8dcaf61-9400-4907-866b-3f83f05361c4"), "Nice Books" },
                    { new Guid("3eef9a14-d738-49c0-91d1-3cab845db8c3"), "Grenn Books" },
                    { new Guid("2ef886b9-f41e-460b-9cf8-6181f4bd6415"), "Amazing Books" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_BookId",
                table: "Authors",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Books_BookId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_BookId",
                table: "Authors");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("0f2a0a22-f7b6-4c71-a1bb-d20c5caf81a2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("1e2bd0a0-1cea-445c-bd67-d69e3878eac6"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: new Guid("e5774dd4-5f30-44ac-b7e8-9ab1ed49f995"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("2ef886b9-f41e-460b-9cf8-6181f4bd6415"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("3eef9a14-d738-49c0-91d1-3cab845db8c3"));

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: new Guid("c8dcaf61-9400-4907-866b-3f83f05361c4"));

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Authors");

            migrationBuilder.CreateTable(
                name: "AuthorBook",
                columns: table => new
                {
                    AuthorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BooksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorBook", x => new { x.AuthorsId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_AuthorBook_Authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorBook_Books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "Email", "Gender", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("2e48902b-dda6-4b74-85f6-3025089eb0d9"), new DateTime(2008, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caio@gmail.com", "Male", "Caio", "2625929829825" },
                    { new Guid("f7c93d0c-ea2e-489b-870f-089b333ef5ed"), new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda@gmail.com", "Female", "Fernanda", "498749841984" },
                    { new Guid("ea61dabb-8237-4675-9b0a-925e2f95e2cb"), new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel@gmail.com", "Male", "Gabriel", "198493232312" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b97b67a7-85a8-4b26-990d-65ca398ccbab"), "Nice Books" },
                    { new Guid("8224dcf3-3379-4a01-aee2-6444841bfa45"), "Grenn Books" },
                    { new Guid("9a3983e7-2976-4823-835d-6eba40f2e44f"), "Amazing Books" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorBook_BooksId",
                table: "AuthorBook",
                column: "BooksId");
        }
    }
}

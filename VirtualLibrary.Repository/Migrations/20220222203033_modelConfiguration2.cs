using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VirtualLibrary.Repository.Migrations
{
    public partial class modelConfiguration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.AlterColumn<Guid>(
                name: "AuthorId",
                table: "Books",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "BirthDate", "Email", "Gender", "Name", "Number" },
                values: new object[,]
                {
                    { new Guid("e5774dd4-5f30-44ac-b7e8-9ab1ed49f995"), new DateTime(2008, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caio@gmail.com", "Male", "Caio", "2625929829825" },
                    { new Guid("0f2a0a22-f7b6-4c71-a1bb-d20c5caf81a2"), new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fernanda@gmail.com", "Female", "Fernanda", "498749841984" },
                    { new Guid("1e2bd0a0-1cea-445c-bd67-d69e3878eac6"), new DateTime(2002, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel@gmail.com", "Male", "Gabriel", "198493232312" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3eef9a14-d738-49c0-91d1-3cab845db8c3"), "Nice Books" },
                    { new Guid("c8dcaf61-9400-4907-866b-3f83f05361c4"), "Grenn Books" },
                    { new Guid("2ef886b9-f41e-460b-9cf8-6181f4bd6415"), "Amazing Books" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

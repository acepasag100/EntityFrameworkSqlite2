using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameworkSqlite2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatev4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddress",
                table: "StudentAddress");

            migrationBuilder.RenameTable(
                name: "StudentAddress",
                newName: "StudentAddresses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAddress_StudentId",
                table: "StudentAddresses",
                newName: "IX_StudentAddresses_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses",
                column: "StudentAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddresses_Students_StudentId",
                table: "StudentAddresses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddresses_Students_StudentId",
                table: "StudentAddresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentAddresses",
                table: "StudentAddresses");

            migrationBuilder.RenameTable(
                name: "StudentAddresses",
                newName: "StudentAddress");

            migrationBuilder.RenameIndex(
                name: "IX_StudentAddresses_StudentId",
                table: "StudentAddress",
                newName: "IX_StudentAddress_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentAddress",
                table: "StudentAddress",
                column: "StudentAddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

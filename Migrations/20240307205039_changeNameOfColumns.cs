using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class changeNameOfColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "personID",
                table: "Person",
                newName: "PersonID");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Person",
                newName: "BirthDay");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Person",
                newName: "personID");

            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "Person",
                newName: "age");
        }
    }
}

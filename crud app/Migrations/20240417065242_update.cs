using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace crud_app.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_fruit",
                table: "fruit");

            migrationBuilder.RenameTable(
                name: "fruit",
                newName: "Fruits");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Fruits",
                newName: "Price");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fruits",
                table: "Fruits",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Fruits",
                table: "Fruits");

            migrationBuilder.RenameTable(
                name: "Fruits",
                newName: "fruit");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "fruit",
                newName: "price");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fruit",
                table: "fruit",
                column: "Id");
        }
    }
}

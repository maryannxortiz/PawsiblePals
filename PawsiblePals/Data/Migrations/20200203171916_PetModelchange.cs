using Microsoft.EntityFrameworkCore.Migrations;

namespace PawsiblePals.Data.Migrations
{
    public partial class PetModelchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Species",
                table: "Pets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Species",
                table: "Pets");
        }
    }
}

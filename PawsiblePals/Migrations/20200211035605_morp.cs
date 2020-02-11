using Microsoft.EntityFrameworkCore.Migrations;

namespace PawsiblePals.Migrations
{
    public partial class morp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_AspNetUsers_AccountId",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "accountID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "password",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Pets",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_AccountId",
                table: "Pets",
                newName: "IX_Pets_AccountID");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "AspNetUsers",
                newName: "Username");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_AspNetUsers_AccountID",
                table: "Pets",
                column: "AccountID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_AspNetUsers_AccountID",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Pets",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_AccountID",
                table: "Pets",
                newName: "IX_Pets_AccountId");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AspNetUsers",
                newName: "UserName");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "accountID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_AspNetUsers_AccountId",
                table: "Pets",
                column: "AccountId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

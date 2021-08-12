using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaVirtual.Migrations
{
    public partial class emailfieldtoEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nameidentifier",
                table: "GoogleAccounts",
                newName: "Nameidentifier");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "GoogleAccounts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "GoogleAccounts",
                newName: "Email");

            migrationBuilder.AddColumn<int>(
                name: "MicrosoftId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_MicrosoftId",
                table: "Users",
                column: "MicrosoftId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_MicrosoftAccounts_MicrosoftId",
                table: "Users",
                column: "MicrosoftId",
                principalTable: "MicrosoftAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_MicrosoftAccounts_MicrosoftId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_MicrosoftId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MicrosoftId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Nameidentifier",
                table: "GoogleAccounts",
                newName: "nameidentifier");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "GoogleAccounts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "GoogleAccounts",
                newName: "email");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterProject.Migrations
{
    /// <inheritdoc />
    public partial class nomorecascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Persons_PersonId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Animals",
                newName: "ApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_PersonId",
                table: "Animals",
                newName: "IX_Animals_ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Applications_ApplicationId",
                table: "Animals",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Applications_ApplicationId",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "ApplicationId",
                table: "Animals",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_ApplicationId",
                table: "Animals",
                newName: "IX_Animals_PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Persons_PersonId",
                table: "Animals",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

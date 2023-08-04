using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterProject.Migrations
{
    /// <inheritdoc />
    public partial class apppertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Applications_PersonId",
                table: "Applications",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Persons_PersonId",
                table: "Applications",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Persons_PersonId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_PersonId",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Applications");
        }
    }
}

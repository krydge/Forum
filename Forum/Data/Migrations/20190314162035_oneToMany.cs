using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Data.Migrations
{
    public partial class oneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubClassModel_PostModel_PostModelId",
                table: "SubClassModel");

            migrationBuilder.RenameColumn(
                name: "PostModelId",
                table: "SubClassModel",
                newName: "PostId");

            migrationBuilder.RenameIndex(
                name: "IX_SubClassModel_PostModelId",
                table: "SubClassModel",
                newName: "IX_SubClassModel_PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubClassModel_PostModel_PostId",
                table: "SubClassModel",
                column: "PostId",
                principalTable: "PostModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubClassModel_PostModel_PostId",
                table: "SubClassModel");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "SubClassModel",
                newName: "PostModelId");

            migrationBuilder.RenameIndex(
                name: "IX_SubClassModel_PostId",
                table: "SubClassModel",
                newName: "IX_SubClassModel_PostModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubClassModel_PostModel_PostModelId",
                table: "SubClassModel",
                column: "PostModelId",
                principalTable: "PostModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

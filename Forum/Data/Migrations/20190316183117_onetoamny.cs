using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Data.Migrations
{
    public partial class onetoamny : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentModel_CommentModel_CommentModelId",
                table: "CommentModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentModel_SubClassModel_SubClassModelId",
                table: "CommentModel");

            migrationBuilder.DropIndex(
                name: "IX_CommentModel_CommentModelId",
                table: "CommentModel");

            migrationBuilder.DropColumn(
                name: "CommentModelId",
                table: "CommentModel");

            migrationBuilder.RenameColumn(
                name: "SubClassModelId",
                table: "CommentModel",
                newName: "SubClassId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentModel_SubClassModelId",
                table: "CommentModel",
                newName: "IX_CommentModel_SubClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentModel_SubClassModel_SubClassId",
                table: "CommentModel",
                column: "SubClassId",
                principalTable: "SubClassModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentModel_SubClassModel_SubClassId",
                table: "CommentModel");

            migrationBuilder.RenameColumn(
                name: "SubClassId",
                table: "CommentModel",
                newName: "SubClassModelId");

            migrationBuilder.RenameIndex(
                name: "IX_CommentModel_SubClassId",
                table: "CommentModel",
                newName: "IX_CommentModel_SubClassModelId");

            migrationBuilder.AddColumn<string>(
                name: "CommentModelId",
                table: "CommentModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CommentModel_CommentModelId",
                table: "CommentModel",
                column: "CommentModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentModel_CommentModel_CommentModelId",
                table: "CommentModel",
                column: "CommentModelId",
                principalTable: "CommentModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentModel_SubClassModel_SubClassModelId",
                table: "CommentModel",
                column: "SubClassModelId",
                principalTable: "SubClassModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

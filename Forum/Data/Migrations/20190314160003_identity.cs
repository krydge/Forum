using Microsoft.EntityFrameworkCore.Migrations;

namespace Forum.Data.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostModelId",
                table: "SubClassModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CommentModelId",
                table: "CommentModel",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubClassModelId",
                table: "CommentModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubClassModel_PostModelId",
                table: "SubClassModel",
                column: "PostModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentModel_CommentModelId",
                table: "CommentModel",
                column: "CommentModelId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentModel_SubClassModelId",
                table: "CommentModel",
                column: "SubClassModelId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubClassModel_PostModel_PostModelId",
                table: "SubClassModel",
                column: "PostModelId",
                principalTable: "PostModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentModel_CommentModel_CommentModelId",
                table: "CommentModel");

            migrationBuilder.DropForeignKey(
                name: "FK_CommentModel_SubClassModel_SubClassModelId",
                table: "CommentModel");

            migrationBuilder.DropForeignKey(
                name: "FK_SubClassModel_PostModel_PostModelId",
                table: "SubClassModel");

            migrationBuilder.DropIndex(
                name: "IX_SubClassModel_PostModelId",
                table: "SubClassModel");

            migrationBuilder.DropIndex(
                name: "IX_CommentModel_CommentModelId",
                table: "CommentModel");

            migrationBuilder.DropIndex(
                name: "IX_CommentModel_SubClassModelId",
                table: "CommentModel");

            migrationBuilder.DropColumn(
                name: "PostModelId",
                table: "SubClassModel");

            migrationBuilder.DropColumn(
                name: "CommentModelId",
                table: "CommentModel");

            migrationBuilder.DropColumn(
                name: "SubClassModelId",
                table: "CommentModel");
        }
    }
}

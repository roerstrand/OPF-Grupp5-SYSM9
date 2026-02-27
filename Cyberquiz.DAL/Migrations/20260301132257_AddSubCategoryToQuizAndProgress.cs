using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyberquiz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSubCategoryToQuizAndProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserProgress_Quizzes_QuizId",
                table: "UserProgress");

            migrationBuilder.RenameColumn(
                name: "QuizId",
                table: "UserProgress",
                newName: "SubCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProgress_QuizId",
                table: "UserProgress",
                newName: "IX_UserProgress_SubCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_SubCategoryId",
                table: "Quizzes",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_SubCategories_SubCategoryId",
                table: "Quizzes",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgress_SubCategories_SubCategoryId",
                table: "UserProgress",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_SubCategories_SubCategoryId",
                table: "Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserProgress_SubCategories_SubCategoryId",
                table: "UserProgress");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_SubCategoryId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Quizzes");

            migrationBuilder.RenameColumn(
                name: "SubCategoryId",
                table: "UserProgress",
                newName: "QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_UserProgress_SubCategoryId",
                table: "UserProgress",
                newName: "IX_UserProgress_QuizId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserProgress_Quizzes_QuizId",
                table: "UserProgress",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

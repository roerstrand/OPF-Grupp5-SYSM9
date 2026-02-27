using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyberquiz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FixQuestionModelRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryModelQuestionModel");

            migrationBuilder.DropTable(
                name: "QuestionModelSubCategoryModel");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SubCategoryId",
                table: "Questions",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_SubCategories_SubCategoryId",
                table: "Questions",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_SubCategories_SubCategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_SubCategoryId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "CategoryModelQuestionModel",
                columns: table => new
                {
                    CategoryIdId = table.Column<int>(type: "int", nullable: false),
                    QuestionIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModelQuestionModel", x => new { x.CategoryIdId, x.QuestionIdId });
                    table.ForeignKey(
                        name: "FK_CategoryModelQuestionModel_Categories_CategoryIdId",
                        column: x => x.CategoryIdId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryModelQuestionModel_Questions_QuestionIdId",
                        column: x => x.QuestionIdId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModelSubCategoryModel",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModelSubCategoryModel", x => new { x.QuestionsId, x.SubCategoryIdId });
                    table.ForeignKey(
                        name: "FK_QuestionModelSubCategoryModel_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionModelSubCategoryModel_SubCategories_SubCategoryIdId",
                        column: x => x.SubCategoryIdId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryModelQuestionModel_QuestionIdId",
                table: "CategoryModelQuestionModel",
                column: "QuestionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModelSubCategoryModel_SubCategoryIdId",
                table: "QuestionModelSubCategoryModel",
                column: "SubCategoryIdId");
        }
    }
}

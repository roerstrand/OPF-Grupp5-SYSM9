using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cyberquiz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserResults", x => x.Id);
                });

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
                name: "QuestionAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAnswers_Questions_QuestionIdId",
                        column: x => x.QuestionIdId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryModelSubCategoryModel",
                columns: table => new
                {
                    CategoryModelIdId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryModelSubCategoryModel", x => new { x.CategoryModelIdId, x.SubCategoryIdId });
                    table.ForeignKey(
                        name: "FK_CategoryModelSubCategoryModel_Categories_CategoryModelIdId",
                        column: x => x.CategoryModelIdId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryModelSubCategoryModel_SubCategories_SubCategoryIdId",
                        column: x => x.SubCategoryIdId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuestionModelSubCategoryModel",
                columns: table => new
                {
                    QuestionModelIdId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryIdId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionModelSubCategoryModel", x => new { x.QuestionModelIdId, x.SubCategoryIdId });
                    table.ForeignKey(
                        name: "FK_QuestionModelSubCategoryModel_Questions_QuestionModelIdId",
                        column: x => x.QuestionModelIdId,
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
                name: "IX_CategoryModelSubCategoryModel_SubCategoryIdId",
                table: "CategoryModelSubCategoryModel",
                column: "SubCategoryIdId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAnswers_QuestionIdId",
                table: "QuestionAnswers",
                column: "QuestionIdId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionModelSubCategoryModel_SubCategoryIdId",
                table: "QuestionModelSubCategoryModel",
                column: "SubCategoryIdId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryModelQuestionModel");

            migrationBuilder.DropTable(
                name: "CategoryModelSubCategoryModel");

            migrationBuilder.DropTable(
                name: "QuestionAnswers");

            migrationBuilder.DropTable(
                name: "QuestionModelSubCategoryModel");

            migrationBuilder.DropTable(
                name: "UserResults");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodRecipes.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_AspNetUsers_RecipeUserId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_RecipeAuthor",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_RecipeAuthor",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_RecipeUserId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "RecipeUserId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "EndOfSuspension",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Suspended",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "ThumbnailUrl",
                table: "Recipes",
                newName: "TimeCreated");

            migrationBuilder.RenameColumn(
                name: "Story",
                table: "Recipes",
                newName: "StoryPath");

            migrationBuilder.RenameColumn(
                name: "RecipeAuthor",
                table: "Recipes",
                newName: "ThumbnailPath");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "DisplayName");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Recipes",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstructionsPath",
                table: "Recipes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RecipeUserId",
                table: "Recipes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeAdded",
                table: "Ingredient",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserWhoAddedId",
                table: "Ingredient",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Hashtag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TimeCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IngredientSection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    RecipeId = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientSection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientSection_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HashtagRecipe",
                columns: table => new
                {
                    HashtagsId = table.Column<int>(type: "INTEGER", nullable: false),
                    RecipesId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HashtagRecipe", x => new { x.HashtagsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_HashtagRecipe_Hashtag_HashtagsId",
                        column: x => x.HashtagsId,
                        principalTable: "Hashtag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HashtagRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientSectionIngredient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    IngredientId = table.Column<int>(type: "INTEGER", nullable: false),
                    Order = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientSectionIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientSectionIngredient_IngredientSection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "IngredientSection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientSectionIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RecipeUserId",
                table: "Recipes",
                column: "RecipeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_UserWhoAddedId",
                table: "Ingredient",
                column: "UserWhoAddedId");

            migrationBuilder.CreateIndex(
                name: "IX_HashtagRecipe_RecipesId",
                table: "HashtagRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSection_RecipeId",
                table: "IngredientSection",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSectionIngredient_IngredientId",
                table: "IngredientSectionIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSectionIngredient_SectionId",
                table: "IngredientSectionIngredient",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_AspNetUsers_UserWhoAddedId",
                table: "Ingredient",
                column: "UserWhoAddedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_Id",
                table: "Recipes",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_RecipeUserId",
                table: "Recipes",
                column: "RecipeUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_AspNetUsers_UserWhoAddedId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_Id",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_RecipeUserId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "HashtagRecipe");

            migrationBuilder.DropTable(
                name: "IngredientSectionIngredient");

            migrationBuilder.DropTable(
                name: "Hashtag");

            migrationBuilder.DropTable(
                name: "IngredientSection");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_RecipeUserId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_UserWhoAddedId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "InstructionsPath",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "RecipeUserId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "TimeAdded",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "UserWhoAddedId",
                table: "Ingredient");

            migrationBuilder.RenameColumn(
                name: "TimeCreated",
                table: "Recipes",
                newName: "ThumbnailUrl");

            migrationBuilder.RenameColumn(
                name: "ThumbnailPath",
                table: "Recipes",
                newName: "RecipeAuthor");

            migrationBuilder.RenameColumn(
                name: "StoryPath",
                table: "Recipes",
                newName: "Story");

            migrationBuilder.RenameColumn(
                name: "DisplayName",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Recipes",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "RecipeUserId",
                table: "Ingredient",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndOfSuspension",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Suspended",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Instruciton = table.Column<string>(type: "TEXT", nullable: false),
                    InstructionOrder = table.Column<int>(type: "INTEGER", nullable: false),
                    RecipeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructions_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_RecipeAuthor",
                table: "Recipes",
                column: "RecipeAuthor");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_RecipeUserId",
                table: "Ingredient",
                column: "RecipeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_RecipeId",
                table: "Instructions",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_AspNetUsers_RecipeUserId",
                table: "Ingredient",
                column: "RecipeUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_RecipeAuthor",
                table: "Recipes",
                column: "RecipeAuthor",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

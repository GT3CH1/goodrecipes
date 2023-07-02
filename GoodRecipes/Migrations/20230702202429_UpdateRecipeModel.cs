using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoodRecipes.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRecipeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HashtagRecipe_Hashtag_HashtagsId",
                table: "HashtagRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_AspNetUsers_UserWhoAddedId",
                table: "Ingredient");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSection_Recipes_RecipeId",
                table: "IngredientSection");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSectionIngredient_IngredientSection_SectionId",
                table: "IngredientSectionIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSectionIngredient_Ingredient_IngredientId",
                table: "IngredientSectionIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_Id",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientSectionIngredient",
                table: "IngredientSectionIngredient");

            migrationBuilder.DropIndex(
                name: "IX_IngredientSectionIngredient_SectionId",
                table: "IngredientSectionIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientSection",
                table: "IngredientSection");

            migrationBuilder.DropIndex(
                name: "IX_IngredientSection_RecipeId",
                table: "IngredientSection");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hashtag",
                table: "Hashtag");

            migrationBuilder.RenameTable(
                name: "IngredientSectionIngredient",
                newName: "IngredientSectionIngredients");

            migrationBuilder.RenameTable(
                name: "IngredientSection",
                newName: "IngredientSections");

            migrationBuilder.RenameTable(
                name: "Ingredient",
                newName: "Ingredients");

            migrationBuilder.RenameTable(
                name: "Hashtag",
                newName: "Hashtags");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientSectionIngredient_IngredientId",
                table: "IngredientSectionIngredients",
                newName: "IX_IngredientSectionIngredients_IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredient_UserWhoAddedId",
                table: "Ingredients",
                newName: "IX_Ingredients_UserWhoAddedId");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailPath",
                table: "Recipes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Recipes",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "HashtagsId",
                table: "HashtagRecipe",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "SectionId",
                table: "IngredientSectionIngredients",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "IngredientId",
                table: "IngredientSectionIngredients",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "IngredientSectionIngredients",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "IngredientSections",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Ingredients",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Hashtags",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientSectionIngredients",
                table: "IngredientSectionIngredients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientSections",
                table: "IngredientSections",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hashtags",
                table: "Hashtags",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_AuthorId",
                table: "Recipes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSectionIngredients_SectionId_IngredientId",
                table: "IngredientSectionIngredients",
                columns: new[] { "SectionId", "IngredientId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSectionIngredients_SectionId_Order",
                table: "IngredientSectionIngredients",
                columns: new[] { "SectionId", "Order" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSections_RecipeId_Order",
                table: "IngredientSections",
                columns: new[] { "RecipeId", "Order" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_Name",
                table: "Ingredients",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hashtags_Name",
                table: "Hashtags",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HashtagRecipe_Hashtags_HashtagsId",
                table: "HashtagRecipe",
                column: "HashtagsId",
                principalTable: "Hashtags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_AspNetUsers_UserWhoAddedId",
                table: "Ingredients",
                column: "UserWhoAddedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSectionIngredients_IngredientSections_SectionId",
                table: "IngredientSectionIngredients",
                column: "SectionId",
                principalTable: "IngredientSections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSectionIngredients_Ingredients_IngredientId",
                table: "IngredientSectionIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSections_Recipes_RecipeId",
                table: "IngredientSections",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_AuthorId",
                table: "Recipes",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HashtagRecipe_Hashtags_HashtagsId",
                table: "HashtagRecipe");

            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_AspNetUsers_UserWhoAddedId",
                table: "Ingredients");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSectionIngredients_IngredientSections_SectionId",
                table: "IngredientSectionIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSectionIngredients_Ingredients_IngredientId",
                table: "IngredientSectionIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientSections_Recipes_RecipeId",
                table: "IngredientSections");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_AspNetUsers_AuthorId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_AuthorId",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientSections",
                table: "IngredientSections");

            migrationBuilder.DropIndex(
                name: "IX_IngredientSections_RecipeId_Order",
                table: "IngredientSections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IngredientSectionIngredients",
                table: "IngredientSectionIngredients");

            migrationBuilder.DropIndex(
                name: "IX_IngredientSectionIngredients_SectionId_IngredientId",
                table: "IngredientSectionIngredients");

            migrationBuilder.DropIndex(
                name: "IX_IngredientSectionIngredients_SectionId_Order",
                table: "IngredientSectionIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_Name",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hashtags",
                table: "Hashtags");

            migrationBuilder.DropIndex(
                name: "IX_Hashtags_Name",
                table: "Hashtags");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Recipes");

            migrationBuilder.RenameTable(
                name: "IngredientSections",
                newName: "IngredientSection");

            migrationBuilder.RenameTable(
                name: "IngredientSectionIngredients",
                newName: "IngredientSectionIngredient");

            migrationBuilder.RenameTable(
                name: "Ingredients",
                newName: "Ingredient");

            migrationBuilder.RenameTable(
                name: "Hashtags",
                newName: "Hashtag");

            migrationBuilder.RenameIndex(
                name: "IX_IngredientSectionIngredients_IngredientId",
                table: "IngredientSectionIngredient",
                newName: "IX_IngredientSectionIngredient_IngredientId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_UserWhoAddedId",
                table: "Ingredient",
                newName: "IX_Ingredient_UserWhoAddedId");

            migrationBuilder.AlterColumn<string>(
                name: "ThumbnailPath",
                table: "Recipes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HashtagsId",
                table: "HashtagRecipe",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IngredientSection",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "SectionId",
                table: "IngredientSectionIngredient",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "IngredientSectionIngredient",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "IngredientSectionIngredient",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Ingredient",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Hashtag",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientSection",
                table: "IngredientSection",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IngredientSectionIngredient",
                table: "IngredientSectionIngredient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredient",
                table: "Ingredient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hashtag",
                table: "Hashtag",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSection_RecipeId",
                table: "IngredientSection",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientSectionIngredient_SectionId",
                table: "IngredientSectionIngredient",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_HashtagRecipe_Hashtag_HashtagsId",
                table: "HashtagRecipe",
                column: "HashtagsId",
                principalTable: "Hashtag",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_AspNetUsers_UserWhoAddedId",
                table: "Ingredient",
                column: "UserWhoAddedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSection_Recipes_RecipeId",
                table: "IngredientSection",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSectionIngredient_IngredientSection_SectionId",
                table: "IngredientSectionIngredient",
                column: "SectionId",
                principalTable: "IngredientSection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientSectionIngredient_Ingredient_IngredientId",
                table: "IngredientSectionIngredient",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_AspNetUsers_Id",
                table: "Recipes",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

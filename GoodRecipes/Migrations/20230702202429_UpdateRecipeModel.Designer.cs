﻿// <auto-generated />
using System;
using GoodRecipes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoodRecipes.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230702202429_UpdateRecipeModel")]
    partial class UpdateRecipeModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("GoodRecipes.Models.Hashtag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Hashtags");
                });

            modelBuilder.Entity("GoodRecipes.Models.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeAdded")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserWhoAddedId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("UserWhoAddedId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("GoodRecipes.Models.IngredientSection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("RecipeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId", "Order")
                        .IsUnique();

                    b.ToTable("IngredientSections");
                });

            modelBuilder.Entity("GoodRecipes.Models.IngredientSectionIngredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Order")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("SectionId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("SectionId", "IngredientId")
                        .IsUnique();

                    b.HasIndex("SectionId", "Order")
                        .IsUnique();

                    b.ToTable("IngredientSectionIngredients");
                });

            modelBuilder.Entity("GoodRecipes.Models.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("InstructionsPath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RecipeUserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("StoryPath")
                        .HasColumnType("TEXT");

                    b.Property<string>("ThumbnailPath")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("RecipeUserId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("GoodRecipes.Models.RecipeUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("HashtagRecipe", b =>
                {
                    b.Property<Guid>("HashtagsId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RecipesId")
                        .HasColumnType("TEXT");

                    b.HasKey("HashtagsId", "RecipesId");

                    b.HasIndex("RecipesId");

                    b.ToTable("HashtagRecipe");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GoodRecipes.Models.Ingredient", b =>
                {
                    b.HasOne("GoodRecipes.Models.RecipeUser", "UserWhoAdded")
                        .WithMany("IngredientsAdded")
                        .HasForeignKey("UserWhoAddedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserWhoAdded");
                });

            modelBuilder.Entity("GoodRecipes.Models.IngredientSection", b =>
                {
                    b.HasOne("GoodRecipes.Models.Recipe", "Recipe")
                        .WithMany("IngredientSections")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("GoodRecipes.Models.IngredientSectionIngredient", b =>
                {
                    b.HasOne("GoodRecipes.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodRecipes.Models.IngredientSection", "Section")
                        .WithMany("Ingredients")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Section");
                });

            modelBuilder.Entity("GoodRecipes.Models.Recipe", b =>
                {
                    b.HasOne("GoodRecipes.Models.RecipeUser", "Author")
                        .WithMany("Recipes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodRecipes.Models.RecipeUser", null)
                        .WithMany("RecipeBox")
                        .HasForeignKey("RecipeUserId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("HashtagRecipe", b =>
                {
                    b.HasOne("GoodRecipes.Models.Hashtag", null)
                        .WithMany()
                        .HasForeignKey("HashtagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodRecipes.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GoodRecipes.Models.RecipeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GoodRecipes.Models.RecipeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoodRecipes.Models.RecipeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GoodRecipes.Models.RecipeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GoodRecipes.Models.IngredientSection", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("GoodRecipes.Models.Recipe", b =>
                {
                    b.Navigation("IngredientSections");
                });

            modelBuilder.Entity("GoodRecipes.Models.RecipeUser", b =>
                {
                    b.Navigation("IngredientsAdded");

                    b.Navigation("RecipeBox");

                    b.Navigation("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// Copyright (c) 2022. Gavin Pease and contributors.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do so, subject to the
// following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial
// portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT
// OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using GoodRecipes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoodRecipes.Data;

public class ApplicationDbContext : IdentityDbContext<RecipeUser>
{
    public DbSet<Recipe> Recipes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Recipe>()
    //        .HasOne(r => r.Author)
    //        .WithMany(u => u.Recipes)
    //        .HasForeignKey(r => r.Id)
    //        .OnDelete(DeleteBehavior.Cascade);

    //    modelBuilder.Entity<RecipeUser>()
    //        .HasMany(u => u.Recipes)
    //        .WithOne(r => r.Author)
    //        .OnDelete(DeleteBehavior.Cascade);

    //    base.OnModelCreating(modelBuilder);
    //}

    public async Task InitializeRoles(RoleManager<IdentityRole> rm)
    {
        await rm.CreateAsync(new IdentityRole("Admin"));
    }

    public async Task InitializeUsers(UserManager<RecipeUser> um)
    {
        var admin = new RecipeUser()
        {
            DisplayName = "Admin",
            UserName = "admin@admin.com",
            Email = "admin@admin.com",
            EmailConfirmed = true
        };
        await um.CreateAsync(admin, "Password1!");
        await um.AddToRoleAsync(admin, "Admin");
    }

    public async Task InitializeDatabase(UserManager<RecipeUser> um, RoleManager<IdentityRole> rm)
    {
        if ((await Database.GetPendingMigrationsAsync()).Any())
            await Database.MigrateAsync();
        if(!rm.Roles.Any())
            await InitializeRoles(rm);
        if (!um.Users.Any())
            await InitializeUsers(um);
    }
}
using System;
using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole{Id="881734e8-2a3e-43b4-964f-4e9ee3bf90d6", Name = "Member",NormalizedName="MEMBER"},
                new IdentityRole{Id="79c4d774-c2be-4310-892b-be8bbe7ed355", Name = "Admin",NormalizedName="ADMIN"}
            );
    }
}



using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Forum.Models;

namespace Forum.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Forum.Models.PostModel> PostModel { get; set; }
        public DbSet<Forum.Models.SubClassModel> SubClassModel { get; set; }
        public DbSet<Forum.Models.CommentModel> CommentModel { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PostModel>()
                .HasMany(s => s.SubClass)
                .WithOne(p => p.Post);
        }
    }
}

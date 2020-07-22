using Microsoft.EntityFrameworkCore;
using System;

namespace Blog.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tags>().HasData(
                new Tags
                {
                    TagsId = 1,
                    AllowedBarsList = "iOS,AR"
                },
                new Tags
                {
                    TagsId = 2,
                    AllowedBarsList = "iOS,AR,Gazzda"
                },
                new Tags
                {
                    TagsId = 3,
                    AllowedBarsList = "trends,innovation,2018"
                }
            );

            modelBuilder.Entity<Posts>().HasData(
                new Posts
                {
                    BlogSlug = "augmented-reality-ios-application",
                    Title = "Augmented Reality iOS Application",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    CreatedAtDate = DateTime.Now,
                    UpdatedAtDate = DateTime.Now,
                    TagsId = 1
                },
                new Posts
                {
                    BlogSlug = "trends-slug",
                    Title = "Internet Trends 2018",
                    Description = "Ever wonder how?",
                    Body = "An opinionated commentary, of the most important presentation of the year",
                    CreatedAtDate = DateTime.Now,
                    UpdatedAtDate = DateTime.Now,
                    TagsId = 3
                },
                new Posts
                {
                    BlogSlug = "augmented-reality-ios-application-2",
                    Title = "Augmented Reality iOS Application 2",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    CreatedAtDate = DateTime.Now,
                    UpdatedAtDate = DateTime.Now,
                    TagsId=2
                },
                  new Posts
                  {
                      BlogSlug = "augmented-reality-ios-application-3",
                      Title = "Augmented Reality iOS Application 3",
                      Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                      Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                      CreatedAtDate = DateTime.Now,
                      UpdatedAtDate = DateTime.Now,
                      TagsId = 1
                  }
                );
        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Tags> Tags { get; set; }

    }
}

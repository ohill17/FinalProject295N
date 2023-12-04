using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace FinalProject.Data
{
  
    public class AppDbContext : DbContext
    {
        public DbSet<GameReview> GameReviews { get; set; }
        public DbSet<GameRating> GameRatings { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
    }
}

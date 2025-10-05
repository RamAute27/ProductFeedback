using Microsoft.EntityFrameworkCore;
using ProductFeedbackApp.API.Models;
using System.Collections.Generic;

namespace ProductFeedbackApp.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Feedback> Feedbacks { get; set; }
    }
}

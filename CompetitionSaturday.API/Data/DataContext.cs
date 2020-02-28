using CompetitionSaturday.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CompetitionSaturday.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) 
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompetitionUser>()
                .HasKey(c => new { c.CompetitionId, c.UserId });

            modelBuilder.Entity<CompetitionUser>()
                .HasOne(cu => cu.User)
                .WithMany(u => u.Competitions)
                .HasForeignKey(cu => cu.UserId);

            modelBuilder.Entity<CompetitionUser>()
                .HasOne(cu => cu.Competition)
                .WithMany(c => c.Competitors)
                .HasForeignKey(cu => cu.CompetitionId);
        }
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<CompetitionUser> CompetitionUsers { get; set; }
    }
}
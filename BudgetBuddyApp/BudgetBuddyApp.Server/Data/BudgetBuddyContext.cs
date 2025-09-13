using BudgetBuddyApp.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetBuddyApp.Server.Data
{
    public class BudgetBuddyContext : DbContext
    {
        public BudgetBuddyContext(DbContextOptions<BudgetBuddyContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User entity
            modelBuilder.Entity<UserEntity>(entity =>
            {

                entity.HasIndex(u => u.Email)
                      .IsUnique();
            });

            // Category entity
            modelBuilder.Entity<CategoryEntity>(entity =>
            {
                // Each User can’t have duplicate category names
                entity.HasIndex(c => new { c.UserId, c.Name })
                      .IsUnique();

                entity.HasOne(c => c.User)
                      .WithMany(u => u.Categories)
                      .HasForeignKey(c => c.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });
        }
    }
}

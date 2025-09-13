using BudgetBuddyApp.Server.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudgetBuddyApp.Server.Data
{
    public class DatabaseSeeders
    {
        //I used ChatGpt to generate this Seeder, I updated it meet my needs
        public static void Seed(BudgetBuddyContext context)
        {
            // Apply migrations
            context.Database.Migrate();
            List<UserEntity> users = new List<UserEntity>();
            // Seed Users
            if (!context.Users.Any())
            {
                 users = new List<UserEntity>
                {
                    new UserEntity { Id = Guid.NewGuid(), Name = "Alice Student", Email = "alice@student.com" },
                    new UserEntity { Id = Guid.NewGuid(), Name = "Bob Learner", Email = "bob@student.com" }
                };

                context.Users.AddRange(users);
                context.SaveChanges();
            }

            // Seed Categories
            if (!context.Categories.Any() && users.Any())
            {
                var categories = new[]
                {
                    new CategoryEntity { Id = Guid.NewGuid(), Name = "Food", UserId = users[0].Id },
                    new CategoryEntity { Id = Guid.NewGuid(), Name = "Transport", UserId = users[0].Id },
                    new CategoryEntity { Id = Guid.NewGuid(), Name = "Entertainment", UserId = users[0].Id },
                    new CategoryEntity { Id = Guid.NewGuid(), Name = "Books", UserId = users[1].Id }
                };

                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }
    }
}


using BudgetBuddyApp.Server.Data;
using BudgetBuddyApp.Server.Interfaces.Repositories;
using BudgetBuddyApp.Server.Interfaces.Services;
using BudgetBuddyApp.Server.Repositories.CategoryRepository;
using BudgetBuddyApp.Server.Repositories.UserRepository;
using BudgetBuddyApp.Server.Services.CategoryService;
using BudgetBuddyApp.Server.Services.UserService;
using Microsoft.EntityFrameworkCore;

namespace BudgetBuddyApp.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IUserService, UserService>();

            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();


            builder.Services.AddDbContext<BudgetBuddyContext>(
            options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<BudgetBuddyContext>();
                db.Database.EnsureCreated();
                DatabaseSeeder.Seed(db);
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}

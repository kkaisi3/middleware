
using Adventure.Controllers;
using Adventure.Middleware;
using Adventure.Repository;
using Adventure.Services;
using Microsoft.EntityFrameworkCore;

namespace Adventure
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AdventureDbContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddScoped<IAdventurerRepository, AdventurerRepository>();
            builder.Services.AddScoped<IAdventurerService, AdventurerService>();
            builder.Services.AddScoped <AdventurerController>();
            builder.Services.AddTransient<LoggerMiddleware>();
          

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.UseMiddleware<LoggerMiddleware>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

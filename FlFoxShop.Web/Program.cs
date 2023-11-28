using FlFoxShop.DataBase;
using FlFoxShop.Domain.ProductRequests;

using MediatR;

using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace FlFoxShop.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMediatR(cfg => {
                cfg.RegisterServicesFromAssembly(typeof(AddTextileRequest).Assembly);
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            builder.Services.AddDbContext<ShopDbContext>(options => {
                options.UseNpgsql(builder.Configuration.GetConnectionString("LocalDbConnection"));
            });

            //builder.Services.AddCors(options =>
            //{
            //    options.AddPolicy(name: MyAllowSpecificOrigins,
            //                      policy =>
            //                      {
            //                          policy.WithOrigins("http://localhost:4200/");
            //                      });
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(x => x
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());

            app.MapControllers();

            app.Run();
        }
    }
}

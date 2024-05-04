﻿using Fiap.Ingresso.Usuario.API.Data;
using Fiap.Ingresso.WebAPI.Core.Identity;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Ingresso.Usuario.API.Configuration
{
    public static class ApiConfig
    {
        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<UsuarioContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //services.Configure<AppSettings>(options => configuration.GetSection("AppSettings").Bind(options));

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy("Total",
                    builder =>
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader());
            });

            
        }

        public static void UseApiConfiguration(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("Total");
            
            app.MapControllers();
        }
    }
}

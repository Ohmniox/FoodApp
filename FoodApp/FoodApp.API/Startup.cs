using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using FoodApp.Core.Services.Contracts;
using FoodApp.Data;
using FoodApp.Domain.Services;
using FoodApp.Models.Config;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace FoodApp.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var settings = Configuration.GetSection("FoodAppSettings").Get<ConfigSettings>();
            services.AddSingleton<ConfigSettings>(settings);

            services.AddControllers(config =>
            {
                var policy = new AuthorizationPolicyBuilder(new[] { "Bearer" })
                    .RequireAuthenticatedUser()
                    .Build();

                config.Filters.Add(new AuthorizeFilter(policy));
            }).AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.IgnoreNullValues = true;
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
            });

            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(cfg =>
           {
               var signingKeyByteArray = Encoding.Default.GetBytes(settings.SigningKey);
               var signingKey = new SymmetricSecurityKey(signingKeyByteArray);
               cfg.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
               {
                   ValidAudience = "FoodAppAPI",
                   ValidIssuer = "self",
                   IssuerSigningKey = signingKey,
                   ValidateIssuerSigningKey = true,
                   ValidateLifetime = true,
                   ClockSkew = TimeSpan.Zero
               };
               cfg.RequireHttpsMetadata = false;
               cfg.SaveToken = false;
           });

            var connectionString = Configuration.GetConnectionString("FoodAppDBConnectionString");
            services.AddDbContext<FoodAppDbContext>(item => item.UseSqlServer(connectionString));

            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IFoodService, FoodService>();
            services.AddScoped<IUserService, UserService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Food App API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Food App API");
            });
            
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

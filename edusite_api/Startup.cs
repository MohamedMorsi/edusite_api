using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using edusite_api.Data;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using MySqlConnector;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using Swashbuckle.Swagger;
using edusite_api.Setting;
using edusite_api.Services.Contract;
using edusite_api.Services;
using edusite_api.Repository;
using edusite_api.Data.Contract;

namespace Auth_API
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
            //connection strings conect context with connection string 
            //for mysql 
            string mySqlConnectionStr = Configuration.GetConnectionString("DBConnectionString");
            services.AddDbContextPool<DataContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

            //for sqlserver   install Microsoft.EntityFrameworkCore.SqlServer
            //services.AddDbContext<DataContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("MasterConnectionString")));

            //Automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //Controller
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();

            //Services
            services.AddScoped<ILoginService, LoginService>();
            services.AddSingleton<ITokenService, TokenService>();

            //Repositories
            services.AddScoped<IAccountRepo, AccountRepo>();

            //Microsoft.AspNetCore.Mvc.NewtonsoftJson  ===== to possible object cycle was detected which is not supported
            services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            //jwtSettings For Token
            var jwtSettings = JwtSettings.FromConfiguration(Configuration);
            services.AddSingleton(jwtSettings);
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options => options.TokenValidationParameters = jwtSettings.TokenValidationParameters);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Auth_API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("./v1/swagger.json", "Auth_API v1"));  //originally "/swagger/v1/swagger.json"
            }

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

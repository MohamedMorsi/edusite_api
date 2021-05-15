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
using Microsoft.IdentityModel.Tokens;
using System.Text;
using edusite_api.Services;
using edusite_api.Services.Contract;
using edusite_api.Settings;
using Models;
using Microsoft.AspNetCore.Identity;
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

            services.Configure<JWT>(Configuration.GetSection("JWT"));

            services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<DataContext>();


            //connection strings conect context with connection string 
            //for mysql 
            string mySqlConnectionStr = Configuration.GetConnectionString("DBConnectionString");
            services.AddDbContextPool<DataContext>(options => options.UseMySql(mySqlConnectionStr, ServerVersion.AutoDetect(mySqlConnectionStr)));

            //for sqlserver   install Microsoft.EntityFrameworkCore.SqlServer
            //services.AddDbContext<DataContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("MasterConnectionString")));

            //Automapper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());



            //Cros
            //for any origin
            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
            ////for one orgin
            //services.AddCors(c =>
            //{
            //    c.AddPolicy("AllowOrigin", options => options.WithOrigins("https://localhost:3000/"));
            //});


            //Services
            services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<ILoginService, LoginService>();
            //services.AddSingleton<ITokenService, TokenService>();

            //Repositories
            //services.AddScoped<IAccountRepo, AccountRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddScoped<IPlanRepo, PlanRepo>();
            services.AddScoped<ITeacherRepo, TeacherRepo>();
            services.AddScoped<IGradeRepo, GradeRepo>();
            services.AddScoped<ICourseRepo, CourseRepo>();

            //Microsoft.AspNetCore.Mvc.NewtonsoftJson  ===== to possible object cycle was detected which is not supported
            services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(o =>
                {
                    o.RequireHttpsMetadata = false;
                    o.SaveToken = false;
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidIssuer = Configuration["JWT:Issuer"],
                        ValidAudience = Configuration["JWT:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Key"]))
                    };
                });

            //Controller
            services.AddControllers();
            services.AddControllers().AddNewtonsoftJson();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "edusite_API", Version = "v1" });
                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First()); //This line
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, DataContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("./v1/swagger.json", "edusite_API v1"));  //originally "/swagger/v1/swagger.json"
            }

            // Creates the database if not exists
            //db.Database.EnsureCreated(); //without migration
            db.Database.Migrate(); //with all migration

            //add cros to container
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); //for any orgin
            //app.UseCors(options => options.WithOrigins("https://localhost:3000/")); //for only this orgin

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

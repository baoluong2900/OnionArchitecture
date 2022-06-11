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
using RepositoryLayer;
using ServicesLayer.EmployeeService;
using ServicesLayer.RepositoryPatten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace EmployeeManager
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
            #region Connection String
            services.AddDbContext<ApplicationDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
            #endregion
            #region Services Injected
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IEmployeeService, EmployeeService>();
            #endregion

            //#region create Configuring CORS
            //services.AddCors(options =>
            //{
            //    options.AddDefaultPolicy(builder =>
            //    {
            //        builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
            //    });


            //});
            //#endregion
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "EmployeeManager", Version = "v1" });
            });

            //#region Enables Cors
            //services.AddCors(options =>
            //{
            //    //options.AddDefaultPolicy(builder =>
            //    //{
            //    //    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
            //    //});
            //    options.AddPolicy("AllowOrigin", options => options.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());


            //});
            //#endregion

            //#region JSON Serializer
            //services.AddControllersWithViews().AddNewtonsoftJson( options => options.SerializerSettings.ReferenceLoopHandling = 
            //Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            //#endregion

            services.AddCors();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "EmployeeManager v1"));
            }
            //app.UseCors();
            app.UseCors(options => options.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:4200"));

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

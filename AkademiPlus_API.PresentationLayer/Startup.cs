using AkademiPlusAPI.BusinessLayer.Abstract;
using AkademiPlusAPI.BusinessLayer.Concrete;
using AkademiPlusAPI.DataAccessLayer.Abstract;
using AkademiPlusAPI.DataAccessLayer.Concrete;
using AkademiPlusAPI.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademiPlus_API.PresentationLayer
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
            services.AddDbContext<Context>();
            services.AddScoped<ICustomerDal,EfCustomerDal>();
            services.AddScoped<ICustomerService,CustomerManager>();

            services.AddScoped<IBalanceDal, EfBalanceDal>();
            services.AddScoped<IBalanceService, BalanceManager>();

            services.AddScoped<IActivityDal, EfActivityDal>();
            services.AddScoped<IActivityService, ActivityManager>();

            services.AddControllers();


            services.AddCors(opt =>
            {
                opt.AddPolicy("AkademiPlusCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AkademiPlus_API.PresentationLayer", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "AkademiPlus_API.PresentationLayer v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors("AkademiPlusCors");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

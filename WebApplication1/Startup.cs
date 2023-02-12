﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string _corsPolicy = "AllowAllOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "example2", Version = "v1" });
            });
            services.AddDbContext<CollegeDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultCon"));
            });

            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowAllOrigins",
                        corsBuilder =>
                        {
                            corsBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                        }
                    );

                //options.AddPolicy(name: "AllowUBTSite",
                //        corsBuilder =>
                //        {
                //            corsBuilder.WithOrigins("https://www.ubt-uni.net/").WithMethods("POST");
                //        }
                //    );
            });

            services.AddCors(options =>
            {
                options.AddPolicy(name: _corsPolicy,
                        corsBuilder =>
                        {
                            corsBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                        }
                    );


            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "example2 v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors(_corsPolicy);//cross site validation

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;

namespace WoaW.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // https://weblog.west-wind.com/posts/2016/Sep/26/ASPNET-Core-and-CORS-Gotchas
        // https://docs.microsoft.com/en-us/aspnet/core/security/cors
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy", builder =>
            //         builder.AllowAnyOrigin()
            //                .AllowAnyMethod()
            //                .AllowAnyHeader()
            //                //.AllowCredentials()
            //                );
            //});

            services.AddMvc();
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder =>
                     {
                         builder.WithOrigins("http://localhost:7002", "http://localhost:7000")
                              .AllowAnyMethod()
                              .AllowAnyHeader();
                     });
            });
            //services.Configure<MvcOptions>(options =>
            //{
            //    options.Filters.Add(new CorsAuthorizationFilterFactory("CorsPolicy"));
            //});


            services.AddMvcCore()
                .AddAuthorization()
                .AddJsonFormatters();

            services.AddAuthentication("Bearer")
                .AddIdentityServerAuthentication(options =>
                {
                    options.Authority = "http://localhost:7000";
                    options.RequireHttpsMetadata = false;

                    options.ApiName = "api1";
                });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors("CorsPolicy");

            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

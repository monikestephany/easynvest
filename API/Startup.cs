using API.Mappers;
using AutoMapper;
using CORE.Interfaces.Services;
using CORE.Services;
using DATA.Repositories.FixedIncome;
using DATA.Repositories.Funds;
using DATA.Repositories.TreasuryDirect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace API
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
            services.AddScoped<IInvestmentService, InvestmentService>();
            services.AddScoped<FixedIncomeProxy>();
            services.AddScoped<FundsProxy>();
            services.AddScoped<TreasuryDirectProxy>();

            services.AddHttpClient();
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Investimentos Easynvest",
                        Version = "v1",
                        Description = "API de investimentos da easynvest.",
                        Contact = new OpenApiContact
                        {
                            Name = "Monike Stephany Santana",
                            Url = new Uri("https://github.com/renatogroffe")
                        }
                    });
            });

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new Profiles());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvcCore()
             .AddApiExplorer();

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("../swagger/v1/swagger.json", "Investimentos Easynvest v1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

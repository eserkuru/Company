using Company.Manager.Business.Abstract;
using Company.Manager.Business.Concrete;
using Company.Manager.DataAccess.Abstract;
using Company.Manager.DataAccess.Concrete.Contexts;
using Company.Manager.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Company.Manager.WebCoreUI
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);


            #region Dals

            services.AddScoped<ICountryDal, EfCountryDal<ManagerContext>>();
            services.AddScoped<ICityDal, EfCityDal<ManagerContext>>();
            services.AddScoped<ITownDal, EfTownDal<ManagerContext>>();
            #endregion

            #region Managers

            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<ITownService, TownManager>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=User}/{action=Login}/{id?}"
                    );

                routes.MapRoute(
                      name: "areas",
                      template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                      );
            });
        }
    }
}

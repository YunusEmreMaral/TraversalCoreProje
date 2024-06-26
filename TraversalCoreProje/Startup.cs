using BusinessLayer.Abstarct;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Container;
<<<<<<< HEAD
using BusinessLayer.ValidationRule;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
=======
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
<<<<<<< HEAD
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
=======
using Microsoft.AspNetCore.Mvc.Authorization;
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
using TraversalCoreProje.Models;

namespace TraversalCoreProje
{
	public class Startup
	{
<<<<<<< HEAD

=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
<<<<<<< HEAD
            services.AddScoped<GetAllDestinationQueryHandler>();
            services.AddScoped<GetDestinationByIDQueryHandler>();
            services.AddScoped<CreateDestinationCommandHandler>();
            services.AddScoped<RemoveDestinationCommandHandler>();
            services.AddScoped<UpdateDestinationCommandHandler>();

            services.AddMediatR(typeof(Startup)); // �nemli 



=======
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
            services.AddLogging(x =>
            {
                x.ClearProviders();
                x.SetMinimumLevel(LogLevel.Debug);
                x.AddDebug();
<<<<<<< HEAD
            });  // loglama 


            services.AddDbContext<Context>(); // efcore ile veri taban� baglant�s�

            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>()
                .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();


            services.AddHttpClient();
            services.ContainerDependencies();  // bag�ml�l�klar�n eklenmesi

            services.AddAutoMapper(typeof(Startup)); // auto mapper 

            services.CustomerValidator();

            services.AddControllersWithViews().AddFluentValidation(); // mvc yap�s�n� ekler
=======
            });


            services.AddDbContext<Context>();
			services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>()
				.AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();

            services.ContainerDependencies();


            services.AddControllersWithViews();
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf

            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
<<<<<<< HEAD
            services.AddLocalization(opt =>
            {
                opt.ResourcesPath = "Resources";
            });

            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{


            var path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\Logs\\Log1.txt"); 

            if (env.IsDevelopment())    // ortam� berlielem 
=======

            services.AddMvc();
        }

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
		{
            var path = Directory.GetCurrentDirectory();
            //loggerFactory.AddFile($"{path}\\Logs\\Log1.txt");  // BURAYA TEKRAR D�N 

            if (env.IsDevelopment())
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

<<<<<<< HEAD
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");  // error page
			app.UseHttpsRedirection();  // https yapma 
			app.UseStaticFiles();  // css js statik dosyalar� sunma
			app.UseAuthentication(); // kimlik dogrulama

            var suppertesCultures = new[] { "en", "fr", "es", "gr", "tr", "de" };
            var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(suppertesCultures[4]).AddSupportedCultures(suppertesCultures).AddSupportedUICultures(suppertesCultures);
            app.UseRequestLocalization(localizationOptions);

            app.UseRouting(); // route 

			app.UseAuthorization(); // yetkilendirme 

			app.UseEndpoints(endpoints =>  // arealar� belirtme falan .
=======
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseAuthentication();
			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
>>>>>>> 310f0bbc7b07f1810adab3aa5ebf3afa76c4dedf
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
	}
}

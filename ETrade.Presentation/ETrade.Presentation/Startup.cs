using ETrade.Business.Abstract;
using ETrade.Business.Concrete;
using ETrade.Business.Helpers;
using ETrade.DataAccess.Abstract;
using ETrade.DataAccess.Concrete;
using ETrade.Presentation.Areas.Admin.Helpers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.Presentation
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
            services.AddControllersWithViews();

            services.AddScoped<ICookieHelper, CookieHelper>();
            services.AddScoped<IStringHelper, StringHelper>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDal, UserDal>();

            services.AddScoped<IUserTokenService, UserTokenService>();
            services.AddScoped<IUserTokenDal, UserTokenDal>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryDal, CategoryDal>();

            services.AddScoped<ISliderService, SliderService>();
            services.AddScoped<ISliderDal, SliderDal>();

            services.AddSingleton<ICacheManager, CacheManager>();
            services.AddSingleton<IMemoryCache, MemoryCache>();

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductDal, ProductDal>();

            services.AddScoped<IProductImageService, ProductImageService>();
            services.AddScoped<IProductImageDal, ProductImageDal>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderDal, OrderDal>();

            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IReviewDal, ReviewDal>();

            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactDal, ContactDal>();

            services.AddScoped<ICategoryProductService, CategoryProductService>();
            services.AddScoped<ICategoryProductDal, CategoryProductDal>();

            services.AddScoped<IAdminChecker, AdminChecker>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {              
                endpoints.MapControllerRoute(name: "urun", pattern: "/urun/{name}", defaults: new { controller = "Product", action = "Index" });

                endpoints.MapControllerRoute(name: "basket", pattern: "/basket", defaults: new { controller = "Basket", action = "AddBasket"});                               
                endpoints.MapControllerRoute(name: "basket", pattern: "/Rbasket", defaults: new { controller = "Basket", action = "ReduceBasket" });                               

                endpoints.MapControllerRoute(name: "getbasket", pattern: "/get-basket", defaults: new
                { controller = "Basket", action = "GetBasket" });

                // BASKET
                endpoints.MapControllerRoute(name: "basketdetail", pattern: "/mybasket", defaults: new
                { controller = "Basket", action = "Index" });

                // ORDER
                endpoints.MapControllerRoute(name: "order", pattern: "/order", defaults: new
                { controller = "Checkout", action = "Index" });

                endpoints.MapControllerRoute(name: "like", pattern: "/like", defaults: new { controller = "Like", action = "AddLike" });
                
                endpoints.MapControllerRoute(name: "getlike", pattern: "/get-like", defaults: new { controller = "Like", action = "GetLike" });
                
                endpoints.MapControllerRoute(name: "likedetail", pattern: "/mylike", defaults: new { controller = "Like", action = "Index" });

                endpoints.MapControllerRoute(name: "shop", pattern: "/kategori/{name}/{page?}", defaults: new { controller = "Shop", action = "Index" });

                endpoints.MapControllerRoute(name: "chechkoutok", pattern: "/checkoutok", defaults: new { controller = "Checkout", action = "CheckOut" });

                endpoints.MapControllerRoute(name: "contactViewOk", pattern: "/contactViewOk", defaults: new { controller = "Contact", action = "ContactViewOk" });

                endpoints.MapControllerRoute(name: "contact", pattern: "/contact", defaults: new
                { controller = "Contact", action = "Index" });

                endpoints.MapControllerRoute(
                name: "AdminArea",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

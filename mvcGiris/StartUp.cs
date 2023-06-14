using mvcTic.data.Abstract;
using mvcTic.data.Concrete.EFCore;
using mvcTic.business.Abstract;
using mvcTic.business.Concrete;

namespace mvcGiris
{
    public class StartUp
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //IProductRepository çağırıldığın EFCoreProductRepository getir
            services.AddScoped<IProductRepository, EFCoreProductRepository>();
            services.AddScoped<ICategoryRepository, EFCoreCategoryRepository>();
            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddControllersWithViews();
        }
        
        public void Configure (IApplicationBuilder app, IWebHostEnvironment env)
        {
             app.UseStaticFiles();

            if(env.IsDevelopment())
            {
                SeedDatabase.Seed();
                //test verilerini aldığı komut
                app.UseDeveloperExceptionPage();
                //projede hata varsa gördüğümüz sayfa, canlıya aldığımızda kullanıcı bu uyarıyı da görmeyecek 404 görecek
            }

            app.UseRouting();
            //UseRouting: site içerisinde yönlendirme kullanılacağını belirten komut
            app.UseEndpoints(endpoints =>
            {//UseEndpoints içi sitenin yolunu belirteceğimiz

                endpoints.MapControllerRoute(

                    name:"products",
                    pattern: "products/{category?}",
                    defaults: new {controller="mvcTic", action="list" } 
                    //artık localhost:5069/products urlsi direkt localhost:5069/mvcTic/list adresine gidecek
                );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    //controller: server(bilisim.com)
                    //action: method(bilisim.com/product)
                    //id :parameters(bilisim.com/product/2) id:2 olan producta gider
                    // ? boş da çalışabilmesi için. pattern'da opsiyonel yerlerin yanına ? koyuyoruz
                    //patterne home ve index eklememizin nedeni Default Routing
                );
            });
        }
        
    }
}
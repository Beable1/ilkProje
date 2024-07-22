using FluentValidation.AspNetCore;
using ilkProje.AutoMappers;
using ilkProje.Handlers;
using ilkProje.Models.ViewModels;
using ilkProje.Services;
using ilkProje.Services.İnterfaces;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());

        //Default olarak singleton olarak gelir
        //services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog()));
        //Singleton,Transient,Scoped olarak bu şekilde değiştirilebilir
        //services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog(),ServiceLifetime.Transient));

        //Eğer constructor parametre almıyorsa bunu kullan
        //services.AddSingleton<ConsoleLog>();
        //Eğer constructor parametre alıyorsa bunu kullan
        //services.AddSingleton<ConsoleLog>(p => new ConsoleLog(5));

        //services.AddSingleton<ILog, ConsoleLog>();
        services.AddSingleton<ILog, TextLog>();

        services.AddAutoMapper(typeof(EmployeeProfil));

    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (!env.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            //endpoints.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.Map("image/{imageName}", new ImageHandler().Handler(env.WebRootPath));
            //endpoints.MapControllerRoute("CustomRoute", "{controller=Home}/{action=Index}/{a}/{b}/{id}");
            //endpoints.MapDefaultControllerRoute();
            endpoints.MapControllers();
        });
    }
}

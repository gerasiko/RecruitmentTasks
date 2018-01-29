using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration.AspNetCore;
using SimpleInjector.Integration.AspNetCore.Mvc;
using SimpleWebApp.Logic;
using SimpleWebApp;

public class Startup
{
    private Container container = new Container();

    public Startup(IHostingEnvironment env)
    {
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();
        services.AddOptions();
        IntegrateSimpleInjector(services);
    }

    private void IntegrateSimpleInjector(IServiceCollection services)
    {
        container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        services.AddSingleton<IControllerActivator>(
            new SimpleInjectorControllerActivator(container));
        services.AddSingleton<IViewComponentActivator>(
            new SimpleInjectorViewComponentActivator(container));

        services.EnableSimpleInjectorCrossWiring(container);
        services.UseSimpleInjectorAspNetRequestScoping(container);
    }

    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
        InitializeContainer(app);
        container.Verify();

        if (env.IsDevelopment())
        {
            app.UseBrowserLink();
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
        }

        app.UseStaticFiles();

        app.UseMvc(routes =>
        {
            routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
        });
    }

    private void InitializeContainer(IApplicationBuilder app)
    {
        container.RegisterMvcControllers(app);
        container.RegisterMvcViewComponents(app);
        container.Register<IOptionGenerator>(() => new OptionGenerator("Log.txt"));
    }
}
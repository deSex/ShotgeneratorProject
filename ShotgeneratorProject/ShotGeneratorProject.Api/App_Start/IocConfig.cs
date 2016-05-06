using Autofac;
using Autofac.Integration.WebApi;
using BusinessLayer.Handlers;
using Contracts;
using DataLayer;
using System.Reflection;
using System.Web.Http;

namespace ShotGeneratorProject.Api
{
    public static class IocConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Register your Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            builder.RegisterType<GeneratorRepository>().As<IUnitOfWork>();
            builder.RegisterType<DataContext>().AsSelf();
            // Set the dependency resolver to be Autofac.

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}
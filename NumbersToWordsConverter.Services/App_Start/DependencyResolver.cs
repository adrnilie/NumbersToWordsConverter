using System.Reflection;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using NumbersToWordsConverter.Services.Repositories;

namespace NumbersToWordsConverter.Services
{
    public class DependencyResolver
    {
        private static IContainer container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }

        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<ConverterRepository>().As<IConverterRepository>();

            container = builder.Build();

            return container;
        }
    }
}
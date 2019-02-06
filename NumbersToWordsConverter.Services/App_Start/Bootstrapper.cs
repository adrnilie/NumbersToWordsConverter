using System.Web.Http;

namespace NumbersToWordsConverter.Services
{
    public class Bootstrapper
    {
        public static void Run()
        {
            DependencyResolver.Initialize(GlobalConfiguration.Configuration);
        }
    }
}
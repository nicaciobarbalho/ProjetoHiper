using Chronos.Web;
using System.Linq;
using System.Web.Mvc;
using Unity.AspNet.Mvc;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(UnityMvcActivator), nameof(UnityMvcActivator.Start))]
[assembly: ApplicationShutdownMethod(typeof(UnityMvcActivator), nameof(UnityMvcActivator.Shutdown))]

namespace Chronos.Web
{
    public static class UnityMvcActivator
    {
        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }

        public static void Start()
        {
            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(UnityConfig.Container));
            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityConfig.Container));

            Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
        }
    }
}
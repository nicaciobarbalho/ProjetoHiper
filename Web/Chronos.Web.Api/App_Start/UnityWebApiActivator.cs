using Chronos.Web.Api;
using System.Web.Http;
using Unity.AspNet.WebApi;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(UnityWebApiActivator), nameof(UnityWebApiActivator.Start))]
[assembly: ApplicationShutdownMethod(typeof(UnityWebApiActivator), nameof(UnityWebApiActivator.Shutdown))]

namespace Chronos.Web.Api
{
    public static class UnityWebApiActivator
    {
        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }

        public static void Start()
        {
            var resolver = new UnityHierarchicalDependencyResolver(UnityConfig.Container);
            GlobalConfiguration.Configuration.DependencyResolver = resolver;
        }
    }
}
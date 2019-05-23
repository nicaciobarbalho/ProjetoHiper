using Unity;
using Unity.AspNet.Mvc;
using Unity.Lifetime;

namespace Chronos.Web.Ddd.Infra.IoC.Extensions
{
    public static class UnityContainerExtensions
    {
        public static void RegisterTypeWithLifetime<TInterface, TClasse>(this IUnityContainer unityContainer)
            where TClasse : TInterface
        {
            unityContainer.RegisterType<TInterface, TClasse>(GetLifetime());
        }

        private static LifetimeManager GetLifetime()
        {
            return new PerRequestLifetimeManager();
        }
    }
}
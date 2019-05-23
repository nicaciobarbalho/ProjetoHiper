using AutoMapper;
using Chronos.Web.Ddd.Infra.IoC;
using Chronos.Web.Ddd.Services.Mappers;
using System;
using Unity;

namespace Chronos.Web.Api
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer Container => container.Value;

        public static void RegisterTypes(IUnityContainer container)
        {
            var mapper = new Mapper(new MapperConfiguration(x =>
            {
                x.ConstructServicesUsing(z => container.Resolve(z));
                x.AddProfile<ChronosMapperProfile>();
            })) as IMapper;

            container.RegisterInstance(mapper);
            IoCBootstrap.Register(container);
        }
    }
}
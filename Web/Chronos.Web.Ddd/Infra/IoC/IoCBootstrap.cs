using Chronos.Dtos;
using Chronos.Web.Ddd.Domain.Clientes.Builder;
using Chronos.Web.Ddd.Domain.Pedidos.Builder;
using Chronos.Web.Ddd.Domain.Produtos.Builder;
using Chronos.Web.Ddd.Infra.Data;
using Chronos.Web.Ddd.Infra.IoC.Extensions;
using Chronos.Web.Ddd.Services.Clientes;
using Chronos.Web.Ddd.Services.Clientes.Validators;
using Chronos.Web.Ddd.Services.Pedidos;
using Chronos.Web.Ddd.Services.Pedidos.Validators;
using Chronos.Web.Ddd.Services.Produtos;
using Chronos.Web.Ddd.Services.Produtos.Validators;
using FluentValidation;
using Unity;

namespace Chronos.Web.Ddd.Infra.IoC
{
    public static class IoCBootstrap
    {
        public static void Register(IUnityContainer unityContainer)
        {
            unityContainer.RegisterTypeWithLifetime<IChronosContext, ChronosContext>();

            unityContainer.RegisterTypeWithLifetime<IClienteService, ClienteService>();
            unityContainer.RegisterTypeWithLifetime<IClienteBuilder, ClienteBuilder>();
            unityContainer.RegisterTypeWithLifetime<IValidator<ClienteDto>, ClienteDtoValidator>();

            unityContainer.RegisterTypeWithLifetime<IProdutoService, ProdutoService>();
            unityContainer.RegisterTypeWithLifetime<IProdutoBuilder, ProdutoBuilder>();

            unityContainer.RegisterTypeWithLifetime<IPedidoBuilder, PedidoBuilder>();
            unityContainer.RegisterTypeWithLifetime<IPedidoService, PedidoService>();
            unityContainer.RegisterTypeWithLifetime<IValidator<PedidoDto>, PedidoDtoValidator>();

            unityContainer.RegisterTypeWithLifetime<IPedidoItemBuilder, PedidoItemBuilder>();
            unityContainer.RegisterTypeWithLifetime<IPedidoItemService, PedidoItemService>();
            unityContainer.RegisterTypeWithLifetime<IValidator<PedidoItemDto>, PedidoItemDtoValidator>();

            unityContainer.RegisterTypeWithLifetime<IValidator<ProdutoDto>, ProdutoDtoValidator>();
            
            
        }
    }
}
using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Domain.Clientes;
using Chronos.Web.Ddd.Domain.Pedidos;
using Chronos.Web.Ddd.Domain.Produtos;

namespace Chronos.Web.Ddd.Services.Mappers
{
    public class ChronosMapperProfile : Profile
    {
        public ChronosMapperProfile()
        {
            CreateMap<Cliente, ClienteDto>()
                .ForMember(dest => dest.Errors, opts => opts.Ignore())
                .ForMember(dest => dest.IsValid, opts => opts.Ignore());

            CreateMap<Produto, ProdutoDto>()
                .ForMember(dest => dest.Errors, opts => opts.Ignore())
                .ForMember(dest => dest.IsValid, opts => opts.Ignore());

            CreateMap<Pedido, PedidoDto>()
                .ForMember(dest => dest.Errors, opts => opts.Ignore())
                .ForMember(dest => dest.IsValid, opts => opts.Ignore());

            CreateMap<PedidoItem, PedidoItemDto>()
                .ForMember(dest => dest.Errors, opts => opts.Ignore())
                .ForMember(dest => dest.IsValid, opts => opts.Ignore());


        }
    }
}
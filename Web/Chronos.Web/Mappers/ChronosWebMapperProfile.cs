using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.ViewModel.Clientes;
using Chronos.Web.ViewModel.Pedidos;

namespace Chronos.Web.Mappers
{
    public class ChronosWebMapperProfile : Profile
    {
        public ChronosWebMapperProfile()
        {
            CreateMap<ClienteDto, ClienteGridDataViewModel>();

            CreateMap<PedidosGridDataViewModel, PedidoDto>()
                        .ReverseMap()
                        
                        .ForMember(x => x.Itens, x => x.Ignore());
        }
    }
}
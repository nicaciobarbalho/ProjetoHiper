using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.ViewModel.Clientes;

namespace Chronos.Web.Mappers
{
    public class ChronosWebMapperProfile : Profile
    {
        public ChronosWebMapperProfile()
        {
            CreateMap<ClienteDto, ClienteGridDataViewModel>();
        }
    }
}
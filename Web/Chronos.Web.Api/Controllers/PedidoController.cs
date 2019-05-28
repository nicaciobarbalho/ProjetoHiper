using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Pedidos;
using System.Collections.Generic;
using System.Web.Http;

namespace Chronos.Web.Api.Controllers
{
    public class PedidoController : ApiController
    {
        private readonly IPedidoService _PedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _PedidoService = pedidoService;
        }

        public IEnumerable<PedidoDto> Get() => _PedidoService.GetDtos();

        public PedidoDto Get(int id) => _PedidoService.GetDtoById(id);

        public PedidoDto Post([FromBody] PedidoDto dto) => _PedidoService.Salvar(dto);

        public PedidoDto Put(int id, [FromBody]PedidoDto dto)
        {
            dto.Id = id;
            return _PedidoService.Editar(dto);
        }
    }
}
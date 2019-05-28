using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Chronos.Web.Api.Controllers
{
    public class PedidoItemController : ApiController
    {
        private readonly IPedidoItemService _PedidoItemService;

        public PedidoItemController(IPedidoItemService PedidoItemService)
        {
            _PedidoItemService = PedidoItemService;
        }

        public IEnumerable<PedidoItemDto> Get() => _PedidoItemService.GetDtos();

        public PedidoItemDto Get(int id) => _PedidoItemService.GetDtoById(id);

        public PedidoItemDto Post([FromBody] PedidoItemDto dto) => _PedidoItemService.Salvar(dto);

        public PedidoItemDto Put(int id, [FromBody]PedidoItemDto dto)
        {
            dto.Id = id;
            return _PedidoItemService.Editar(dto);
        }
    }
}
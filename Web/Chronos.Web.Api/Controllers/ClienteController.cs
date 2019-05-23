using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Clientes;
using System.Collections.Generic;
using System.Web.Http;

namespace Chronos.Web.Api.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<ClienteDto> Get() => _clienteService.GetDtos();

        public ClienteDto Get(int id) => _clienteService.GetDtoById(id);

        public ClienteDto Post([FromBody] ClienteDto dto) => _clienteService.Salvar(dto);

        public ClienteDto Put(int id, [FromBody]ClienteDto dto)
        {
            dto.Id = id;
            return _clienteService.Editar(dto);
        }
    }
}
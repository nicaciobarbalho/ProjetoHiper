using Chronos.Dtos;
using System.Collections.Generic;

namespace Chronos.Web.Ddd.Services.Clientes
{
    public interface IClienteService
    {
        ClienteDto Editar(ClienteDto dto);

        ClienteDto GetDtoById(int id);

        ICollection<ClienteDto> GetDtos();

        ClienteDto Salvar(ClienteDto dto);
    }
}
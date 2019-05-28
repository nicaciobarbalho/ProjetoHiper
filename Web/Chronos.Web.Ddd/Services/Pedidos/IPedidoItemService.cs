using Chronos.Dtos;
using System.Collections.Generic;

namespace Chronos.Web.Ddd.Services.Pedidos
{
    public interface IPedidoItemService
    {
        PedidoItemDto Editar(PedidoItemDto dto);

        PedidoItemDto GetDtoById(int id);

        ICollection<PedidoItemDto> GetDtos();

        ICollection<PedidoItemDto> GetDtosByPedidoId(int id);

        PedidoItemDto Salvar(PedidoItemDto dto);
    }
}

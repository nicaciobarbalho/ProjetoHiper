using Chronos.Dtos;
using System.Collections.Generic;

namespace Chronos.Web.Ddd.Services.Pedidos
{
    public interface IPedidoService
    {
        PedidoDto Editar(PedidoDto dto);
        PedidoDto GetDtoById(int id);
        ICollection<PedidoDto> GetDtos();        
        PedidoDto Salvar(PedidoDto dto);
    }
}

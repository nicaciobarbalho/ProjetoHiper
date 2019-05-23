using Chronos.Dtos;
using System.Collections.Generic;

namespace Chronos.Web.Ddd.Services.Produtos
{
    public interface IProdutoService
    {
        ProdutoDto Editar(ProdutoDto dto);

        ProdutoDto GetDtoById(int id);

        ICollection<ProdutoDto> GetDtos();

        ProdutoDto Salvar(ProdutoDto dto);
    }
}
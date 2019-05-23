using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Produtos;
using System.Collections.Generic;
using System.Web.Http;

namespace Chronos.Web.Api.Controllers
{
    public class ProdutoController : ApiController
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<ProdutoDto> Get() => _produtoService.GetDtos();

        public ProdutoDto Get(int id) => _produtoService.GetDtoById(id);

        public ProdutoDto Post([FromBody] ProdutoDto dto) => _produtoService.Salvar(dto);

        public ProdutoDto Put(int id, [FromBody]ProdutoDto dto)
        {
            dto.Id = id;
            return _produtoService.Editar(dto);
        }
    }
}
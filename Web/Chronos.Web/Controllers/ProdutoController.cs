using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Produtos;
using Chronos.Web.ViewModel.Produtos;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Chronos.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            return View(new ProdutoGridViewModel
            {
                Dados = _mapper.Map<ICollection<ProdutoDto>, ICollection<ProdutoGridDataViewModel>>(_produtoService.GetDtos())
            });
        }
    }
}
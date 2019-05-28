using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Pedidos;
using Chronos.Web.ViewModel.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chronos.Web.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPedidoService _pedidoService;
        private readonly IPedidoItemService _pedidoItemService;

        public PedidoController(IPedidoService produtoService, IPedidoItemService pedidoItemService, IMapper mapper)
        {
            _pedidoService = produtoService;
            _pedidoItemService = pedidoItemService;
            _mapper = mapper;
        }

        // GET: Pedido
        public ActionResult Index()
        {
            var pedidos = _mapper.Map<ICollection<PedidoDto>, ICollection<PedidosGridDataViewModel>>(_pedidoService.GetDtos());

            foreach (var pedido in pedidos)
            {
                pedido.Itens = _mapper.Map<ICollection<PedidoItemDto>, ICollection<PedidoItemGridDataViewModel>>(_pedidoItemService.GetDtosByPedidoId(pedido.Id)).ToList();
            }

            return View(new PedidosGridViewModel
            {
                Dados = pedidos
            });
        }
    }
}
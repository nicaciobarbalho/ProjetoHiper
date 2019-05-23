using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Services.Clientes;
using Chronos.Web.ViewModel.Clientes;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Chronos.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IMapper _mapper;

        public ClienteController(IClienteService clienteService, IMapper mapper)
        {
            _clienteService = clienteService;
            _mapper = mapper;
        }

        public ActionResult Index()
        {
            return View(new ClienteGridViewModel
            {
                Dados = _mapper.Map<ICollection<ClienteDto>, ICollection<ClienteGridDataViewModel>>(_clienteService.GetDtos())
            });
        }
    }
}
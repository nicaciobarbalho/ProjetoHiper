using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Domain.Pedidos;
using Chronos.Web.Ddd.Domain.Pedidos.Builder;
using Chronos.Web.Ddd.Infra.Data;
using FluentValidation;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Chronos.Web.Ddd.Services.Pedidos
{
    internal class PedidoItemService : IPedidoItemService
    {
        private readonly IChronosContext _chronosContext;
        private readonly IPedidoItemBuilder _PedidoItemBuilder;
        private readonly IValidator<PedidoItemDto> _PedidoItemDtoValidator;
        private readonly IMapper _mapper;

        public PedidoItemService(
            IChronosContext chronosContext,
            IPedidoItemBuilder PedidoItemBuilder,
            IValidator<PedidoItemDto> PedidoItemDtoValidator,
            IMapper mapper)
        {
            _chronosContext = chronosContext;
            _PedidoItemDtoValidator = PedidoItemDtoValidator;
            _PedidoItemBuilder = PedidoItemBuilder;
            _mapper = mapper;
        }

        public PedidoItemDto Editar(PedidoItemDto dto)
        {
            if (dto == null)
            {
                dto = new PedidoItemDto();
                dto.AddError("Não foi informado dados suficientes para editar o PedidoItem.");
                return dto;
            }

            var validate = _PedidoItemDtoValidator.Validate(dto);
            if (!validate.IsValid)
            {
                dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                return dto;
            }

            var PedidoItem = GetById(dto.Id);
            if (PedidoItem == null)
            {
                dto.AddError("Não foi possível localizar o PedidoItem informado.");
                return dto;
            }

            PedidoItem.SetPedidoId(dto.PedidoId);
            PedidoItem.SetProdutoId(dto.ProdutoId);
            PedidoItem.SetQuantidade(dto.Quantidade);
            PedidoItem.SetValorUnitario(dto.ValorUnitario);
            PedidoItem.SetValorBruto(dto.ValorBruto);
            PedidoItem.SetValorLiquido(dto.ValorLiquido);
            PedidoItem.SetValorDesconto(dto.ValorDesconto);

            if (!PedidoItem.IsValid)
            {
                dto.AddErrors(PedidoItem.Errors);
                return dto;
            }

            _chronosContext.Entry(PedidoItem).State = EntityState.Modified;
            _chronosContext.SaveChanges();

            return _mapper.Map<PedidoItem, PedidoItemDto>(PedidoItem);
        }

        public PedidoItemDto GetDtoById(int id) => _mapper.Map<PedidoItem, PedidoItemDto>(GetById(id));

        public ICollection<PedidoItemDto> GetDtos() => _mapper.Map<ICollection<PedidoItem>, ICollection<PedidoItemDto>>((ICollection<PedidoItem>)Get());

        public PedidoItemDto Salvar(PedidoItemDto dto)
        {
            if (dto == null)
            {
                dto = new PedidoItemDto();
                dto.AddError("Não foi informado dados suficientes para salvar o PedidoItem.");
                return dto;
            }

            var validate = _PedidoItemDtoValidator.Validate(dto);
            if (!validate.IsValid)
            {
                dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                return dto;
            }

            var PedidoItem = _PedidoItemBuilder
                .ComId(dto.Id)
                .ComPedidoId(dto.PedidoId)
                .ComProdutoId(dto.ProdutoId)
                .ComQuantidade(dto.Quantidade)
                .ComValorUnitatio(dto.ValorUnitario)
                .ComValorBruto(dto.ValorBruto)
                .ComValorLiquido(dto.ValorLiquido)
                .ComValorDesconto(dto.ValorDesconto)
                .Build();
            if (!PedidoItem.IsValid)
            {
                dto.AddErrors(PedidoItem.Errors);
                return dto;
            }

            _chronosContext.PedidoItens.Add(PedidoItem);
            _chronosContext.SaveChanges();

            return _mapper.Map<PedidoItem, PedidoItemDto>(PedidoItem);
        }

        private ICollection<PedidoItem> Get() => _chronosContext.PedidoItens.ToList();

        private PedidoItem GetById(int id) => _chronosContext.PedidoItens.FirstOrDefault(x => x.Id == id);

        public ICollection<PedidoItemDto> GetDtosByPedidoId(int id) =>
             _mapper.Map<ICollection<PedidoItem> , ICollection<PedidoItemDto>>(GetByPedidoId(id));

        private ICollection<PedidoItem> GetByPedidoId(int id) =>
            _chronosContext.PedidoItens.Where(x => x.PedidoId == id).ToList();
    }
}

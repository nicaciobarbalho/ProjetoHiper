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
    internal class PedidoService : IPedidoService
        {
            private readonly IChronosContext _chronosContext;
            private readonly IPedidoBuilder _PedidoBuilder;
            private readonly IValidator<PedidoDto> _PedidoDtoValidator;
            private readonly IMapper _mapper;

            public PedidoService(
                IChronosContext chronosContext,
                IPedidoBuilder PedidoBuilder,
                IValidator<PedidoDto> PedidoDtoValidator,
                IMapper mapper)
            {
                _chronosContext = chronosContext;
                _PedidoDtoValidator = PedidoDtoValidator;
                _PedidoBuilder = PedidoBuilder;
                _mapper = mapper;
            }

            public PedidoDto Editar(PedidoDto dto)
            {
                if (dto == null)
                {
                    dto = new PedidoDto();
                    dto.AddError("Não foi informado dados suficientes para editar o Pedido.");
                    return dto;
                }

                var validate = _PedidoDtoValidator.Validate(dto);
                if (!validate.IsValid)
                {
                    dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                    return dto;
                }

                var Pedido = GetById(dto.Id);
                if (Pedido == null)
                {
                    dto.AddError("Não foi possível localizar o Pedido informado.");
                    return dto;
                }

                Pedido.SetClienteId(dto.ClienteId);
                Pedido.SetValorBruto(dto.ValorBruto);
                Pedido.SetValorLiquido(dto.ValorLiquido);
                Pedido.SetValorDesconto(dto.ValorDesconto);

            if (!Pedido.IsValid)
                {
                    dto.AddErrors(Pedido.Errors);
                    return dto;
                }

                _chronosContext.Entry(Pedido).State = EntityState.Modified;
                _chronosContext.SaveChanges();

                return _mapper.Map<Pedido, PedidoDto>(Pedido);
            }

            public PedidoDto GetDtoById(int id) => _mapper.Map<Pedido, PedidoDto>(GetById(id));

            public ICollection<PedidoDto> GetDtos() => _mapper.Map<ICollection<Pedido>, ICollection<PedidoDto>>((ICollection<Pedido>)Get());

            public PedidoDto Salvar(PedidoDto dto)
            {
                if (dto == null)
                {
                    dto = new PedidoDto();
                    dto.AddError("Não foi informado dados suficientes para salvar o Pedido.");
                    return dto;
                }

                var validate = _PedidoDtoValidator.Validate(dto);
                if (!validate.IsValid)
                {
                    dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                    return dto;
                }

                var Pedido = _PedidoBuilder
                    .ComId(dto.Id)
                    .ComClienteId(dto.ClienteId)
                    .ComValorBruto(dto.ValorBruto)
                    .ComValorLiquido(dto.ValorLiquido)
                    .ComValorDesconto(dto.ValorDesconto)  
                    .Build();
                if (!Pedido.IsValid)
                {
                    dto.AddErrors(Pedido.Errors);
                    return dto;
                }

                _chronosContext.Pedidos.Add(Pedido);
                _chronosContext.SaveChanges();

                return _mapper.Map<Pedido, PedidoDto>(Pedido);
            }

            private ICollection<Pedido> Get() => _chronosContext.Pedidos.ToList();

            private Pedido GetById(int id) => _chronosContext.Pedidos.FirstOrDefault(x => x.Id == id);
        }
}

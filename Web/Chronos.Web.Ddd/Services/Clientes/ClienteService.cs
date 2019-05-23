using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Domain.Clientes;
using Chronos.Web.Ddd.Domain.Clientes.Builder;
using Chronos.Web.Ddd.Infra.Data;
using FluentValidation;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Chronos.Web.Ddd.Services.Clientes
{
    internal class ClienteService : IClienteService
    {
        private readonly IChronosContext _chronosContext;
        private readonly IClienteBuilder _clienteBuilder;
        private readonly IValidator<ClienteDto> _clienteDtoValidator;
        private readonly IMapper _mapper;

        public ClienteService(
            IChronosContext chronosContext,
            IClienteBuilder clienteBuilder,
            IValidator<ClienteDto> clienteDtoValidator,
            IMapper mapper)
        {
            _chronosContext = chronosContext;
            _clienteDtoValidator = clienteDtoValidator;
            _clienteBuilder = clienteBuilder;
            _mapper = mapper;
        }

        public ClienteDto Editar(ClienteDto dto)
        {
            if (dto == null)
            {
                dto = new ClienteDto();
                dto.AddError("Não foi informado dados suficientes para editar o cliente.");
                return dto;
            }

            var validate = _clienteDtoValidator.Validate(dto);
            if (!validate.IsValid)
            {
                dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                return dto;
            }

            var cliente = GetById(dto.Id);
            if (cliente == null)
            {
                dto.AddError("Não foi possível localizar o cliente informado.");
                return dto;
            }

            cliente.SetNome(dto.Nome);
            cliente.SetCpf(dto.Cpf);
            cliente.SetEndereco(dto.Endereco);
            cliente.SetNumeroDoEndereco(dto.NumeroDoEndereco);
            cliente.SetBairro(dto.Bairro);
            cliente.SetCidade(dto.Cidade);
            cliente.SetUf(dto.Uf);

            if (!cliente.IsValid)
            {
                dto.AddErrors(cliente.Errors);
                return dto;
            }

            _chronosContext.Entry(cliente).State = EntityState.Modified;
            _chronosContext.SaveChanges();

            return _mapper.Map<Cliente, ClienteDto>(cliente);
        }

        public ClienteDto GetDtoById(int id) => _mapper.Map<Cliente, ClienteDto>(GetById(id));

        public ICollection<ClienteDto> GetDtos() => _mapper.Map<ICollection<Cliente>, ICollection<ClienteDto>>(Get());

        public ClienteDto Salvar(ClienteDto dto)
        {
            if (dto == null)
            {
                dto = new ClienteDto();
                dto.AddError("Não foi informado dados suficientes para salvar o cliente.");
                return dto;
            }

            var validate = _clienteDtoValidator.Validate(dto);
            if (!validate.IsValid)
            {
                dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                return dto;
            }

            var cliente = _clienteBuilder
                .ComId(dto.Id)
                .ComNome(dto.Nome)
                .ComCpf(dto.Cpf)
                .ComEndereco(dto.Endereco)
                .ComNumeroDoEndereco(dto.NumeroDoEndereco)
                .ComBairro(dto.Bairro)
                .ComCidade(dto.Cidade)
                .ComUf(dto.Uf)
                .Build();
            if (!cliente.IsValid)
            {
                dto.AddErrors(cliente.Errors);
                return dto;
            }

            _chronosContext.Clientes.Add(cliente);
            _chronosContext.SaveChanges();

            return _mapper.Map<Cliente, ClienteDto>(cliente);
        }

        private ICollection<Cliente> Get() => _chronosContext.Clientes.ToList();

        private Cliente GetById(int id) => _chronosContext.Clientes.FirstOrDefault(x => x.Id == id);
    }
}
using AutoMapper;
using Chronos.Dtos;
using Chronos.Web.Ddd.Domain.Produtos;
using Chronos.Web.Ddd.Domain.Produtos.Builder;
using Chronos.Web.Ddd.Infra.Data;
using FluentValidation;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Chronos.Web.Ddd.Services.Produtos
{
    internal class ProdutoService : IProdutoService
    {
        private readonly IChronosContext _chronosContext;
        private readonly IMapper _mapper;
        private readonly IProdutoBuilder _produtoBuilder;
        private readonly IValidator<ProdutoDto> _produtoDtoValidator;

        public ProdutoService(IChronosContext chronosContext, IMapper mapper, IValidator<ProdutoDto> produtoDtoValidator, IProdutoBuilder produtoBuilder)
        {
            _chronosContext = chronosContext;
            _mapper = mapper;
            _produtoDtoValidator = produtoDtoValidator;
            _produtoBuilder = produtoBuilder;
        }

        public ProdutoDto Editar(ProdutoDto dto)
        {
            if (dto == null)
            {
                dto = new ProdutoDto();
                dto.AddError("Não foi informado dados suficientes para editar o produto.");
                return dto;
            }

            var validate = _produtoDtoValidator.Validate(dto);
            if (!validate.IsValid)
            {
                dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                return dto;
            }

            var produto = GetById(dto.Id);
            if (produto == null)
            {
                dto.AddError("Não foi possível localizar o produto informado.");
                return dto;
            }

            produto.SetNome(dto.Nome);
            produto.SetPreco(dto.Preco);

            if (!produto.IsValid)
            {
                dto.AddErrors(produto.Errors);
                return dto;
            }

            _chronosContext.Entry(produto).State = EntityState.Modified;
            _chronosContext.SaveChanges();

            return _mapper.Map<Produto, ProdutoDto>(produto);
        }

        public ProdutoDto GetDtoById(int id) => _mapper.Map<Produto, ProdutoDto>(GetById(id));

        public ICollection<ProdutoDto> GetDtos() => _mapper.Map<ICollection<Produto>, ICollection<ProdutoDto>>(Get());

        public ProdutoDto Salvar(ProdutoDto dto)
        {
            if (dto == null)
            {
                dto = new ProdutoDto();
                dto.AddError("Não foi informado dados suficientes para salvar o produto.");
                return dto;
            }

            var validate = _produtoDtoValidator.Validate(dto);
            if (!validate.IsValid)
            {
                dto.AddErrors(validate.Errors.Select(z => z.ErrorMessage));
                return dto;
            }

            var produto = _produtoBuilder
                .ComId(dto.Id)
                .ComNome(dto.Nome)
                .ComPreco(dto.Preco)
                .Build();
            if (!produto.IsValid)
            {
                dto.AddErrors(produto.Errors);
                return dto;
            }

            _chronosContext.Produtos.Add(produto);
            _chronosContext.SaveChanges();

            return _mapper.Map<Produto, ProdutoDto>(produto);
        }

        private ICollection<Produto> Get() => _chronosContext.Produtos.ToList();

        private Produto GetById(int id) => _chronosContext.Produtos.FirstOrDefault(x => x.Id == id);
    }
}
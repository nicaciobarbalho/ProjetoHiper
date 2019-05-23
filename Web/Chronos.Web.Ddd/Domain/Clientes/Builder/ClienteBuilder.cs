using Chronos.Web.Ddd.Domain.Base.Builders;

namespace Chronos.Web.Ddd.Domain.Clientes.Builder
{
    internal class ClienteBuilder : BaseBuilder<ClienteBuilder, Cliente>, IClienteBuilder
    {
        protected string Bairro { get; set; }
        protected string Cidade { get; set; }
        protected string Cpf { get; set; }
        protected string Endereco { get; set; }
        protected string Nome { get; set; }
        protected string NumeroDoEndereco { get; set; }
        protected string Uf { get; set; }

        public override Cliente Build() => new Cliente(Id, Nome, Cpf, Endereco, NumeroDoEndereco, Bairro, Cidade, Uf);

        public ClienteBuilder ComBairro(string bairro)
        {
            Bairro = bairro;
            return this;
        }

        public ClienteBuilder ComCidade(string cidade)
        {
            Cidade = cidade;
            return this;
        }

        public ClienteBuilder ComCpf(string cpf)
        {
            Cpf = cpf;
            return this;
        }

        public ClienteBuilder ComEndereco(string endereco)
        {
            Endereco = endereco;
            return this;
        }

        public ClienteBuilder ComNome(string nome)
        {
            Nome = nome;
            return this;
        }

        public ClienteBuilder ComNumeroDoEndereco(string numeroDoEndereco)
        {
            NumeroDoEndereco = numeroDoEndereco;
            return this;
        }

        public ClienteBuilder ComUf(string uf)
        {
            Uf = uf;
            return this;
        }
    }
}
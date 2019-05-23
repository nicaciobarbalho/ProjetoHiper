using Chronos.Web.Ddd.Domain.Base.Builders;

namespace Chronos.Web.Ddd.Domain.Clientes.Builder
{
    internal interface IClienteBuilder : IBaseBuilder<ClienteBuilder, Cliente>
    {
        ClienteBuilder ComBairro(string bairro);

        ClienteBuilder ComCidade(string cidade);

        ClienteBuilder ComCpf(string cpf);

        ClienteBuilder ComEndereco(string endereco);

        ClienteBuilder ComNome(string nome);

        ClienteBuilder ComNumeroDoEndereco(string numeroDoEndereco);

        ClienteBuilder ComUf(string uf);
    }
}
using Chronos.Web.Ddd.Domain.Base.Entities;

namespace Chronos.Web.Ddd.Domain.Clientes
{
    internal class Cliente : Entity
    {
        internal Cliente(int id, string nome, string cpf, string endereco, string numeroDoEndereco, string bairro, string cidade, string uf)
        {
            SetId(id);
            SetNome(nome);
            SetCpf(cpf);
            SetEndereco(endereco);
            SetNumeroDoEndereco(numeroDoEndereco);
            SetBairro(bairro);
            SetCidade(cidade);
            SetUf(uf);
        }

        protected Cliente()
        {
        }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Cpf { get; private set; }

        public string Endereco { get; private set; }

        public string Nome { get; private set; }

        public string NumeroDoEndereco { get; private set; }

        public string Uf { get; private set; }

        public void SetBairro(string bairro)
        {
            Bairro = bairro;
        }

        public void SetCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetNumeroDoEndereco(string numeroDoEndereco)
        {
            NumeroDoEndereco = numeroDoEndereco;
        }

        public void SetUf(string uf)
        {
            Uf = uf;
        }
    }
}
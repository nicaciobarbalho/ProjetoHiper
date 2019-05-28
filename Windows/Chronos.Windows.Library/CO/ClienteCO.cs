using Chronos.Dtos;
using Chronos.Windows.Library.BO;
using Chronos.Windows.Library.DAO;
using Chronos.Windows.Library.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Linq;

namespace Chronos.Windows.Library.CO
{
    public class ClienteCO
    {
        private static readonly HttpClient client = new HttpClient();

        public bool Adicionar(ClienteBO cliente, out string msgErro)
        {
            msgErro = "";

            try
            {
                if (string.IsNullOrWhiteSpace(cliente.Nome))
                {
                    msgErro = "Nome vazio.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(cliente.Cpf))
                {
                    msgErro = "CPF vazio.";
                    return false;
                }

                if (!Validacao.ValidarCpf(cliente.Cpf))
                {
                    msgErro = "CPF inválido.";
                    return false;
                }

                return new ClienteDAO().Adicionar(cliente) > 0;
            }
            catch (Exception ex)
            {
                msgErro = $"Erro: {ex.Message}";
            }

            return false;
        }

        public List<ClienteBO> Listar()
        {
            return this.CarregarCliente(new ClienteDAO().Listar());
        }

        private List<ClienteDto> GetClientesSincronizacao()
        {
            var result = new List<ClienteDto>();

            foreach (DataRow dr in new ClienteDAO().ListarPendentesSincronizacao().Rows)
            {
                var clienteDto = new ClienteDto();
                clienteDto.Id = int.Parse(dr["id"].ToString());
                clienteDto.Nome = dr["nome"].ToString();
                clienteDto.Uf = dr["uf"].ToString();
                clienteDto.NumeroDoEndereco = dr["numero_endereco"].ToString();
                clienteDto.Endereco = dr["endereco"].ToString();
                clienteDto.Bairro = dr["bairro"].ToString();
                clienteDto.Cidade = dr["cidade"].ToString();
                clienteDto.Cpf = dr["cpf"].ToString();
                
                result.Add(clienteDto);
            }

            return result;

        }

        private List<ClienteBO> CarregarCliente(DataTable clientes)
        {
            var result = new List<ClienteBO>();

            foreach (DataRow dr in clientes.Rows)
            {
                var cliente = new ClienteBO();
                cliente.Id = int.Parse(dr["id"].ToString());
                cliente.Nome = dr["nome"].ToString();
                cliente.Uf = dr["uf"].ToString();
                cliente.NumeroEndereco = dr["numero_endereco"].ToString();
                cliente.Endereco = dr["endereco"].ToString();
                cliente.Bairro = dr["bairro"].ToString();
                cliente.Cidade = dr["cidade"].ToString();
                cliente.Cpf = dr["cpf"].ToString();
                result.Add(cliente);
            }

            return result;
        }

        public ClienteBO ClientePorId(int id)
        {
            return this.CarregarCliente(new ClienteDAO().ClientePorId(id)).FirstOrDefault();
        }

        public List<ClienteBO> ClientePorNome(string nome)
        {
            return this.CarregarCliente(new ClienteDAO().ClientePorNome(nome));
        }

        public bool SincronizarClientes(out string msgErro)
        {
            msgErro = "";

            foreach (var clienteDto in GetClientesSincronizacao())
            {
                try
                {
                    var client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    var response = client.PostAsJsonAsync(new Uri($"{ConfigurationManager.AppSettings["EnderecoApi"].ToString()}Cliente"), clienteDto);

                    new ClienteDAO().AtualizarClienteSincronizado(clienteDto.Id);
                }
                catch (Exception e)
                {
                    msgErro = e.Message;
                    return false;
                }
            }

            return true;
        }
    }
}
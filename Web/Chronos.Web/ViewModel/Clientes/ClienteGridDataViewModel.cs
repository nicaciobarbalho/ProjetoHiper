using System;

namespace Chronos.Web.ViewModel.Clientes
{
    public class ClienteGridDataViewModel
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroDoEndereco { get; set; }
        public string Uf { get; set; }

        public string GetCpfFormatado()
        {
            return string.IsNullOrWhiteSpace(Cpf)
                ? string.Empty
                : Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");
        }

        public string GetEnderecoCompleto()
        {
            var endereco = Endereco?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(Endereco)) return string.Empty;

            if (!string.IsNullOrWhiteSpace(NumeroDoEndereco)) endereco += $", {NumeroDoEndereco.Trim()}";
            if (!string.IsNullOrWhiteSpace(Bairro)) endereco += $" - {Bairro.Trim()}";
            if (!string.IsNullOrWhiteSpace(Cidade)) endereco += $" - {Cidade.Trim()}";
            if (!string.IsNullOrWhiteSpace(Uf)) endereco += $" - {Uf.Trim()}";

            return endereco;
        }
    }
}
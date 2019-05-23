namespace Chronos.Dtos
{
    public class ClienteDto : BaseDto
    {
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NumeroDoEndereco { get; set; }
        public string Uf { get; set; }
    }
}
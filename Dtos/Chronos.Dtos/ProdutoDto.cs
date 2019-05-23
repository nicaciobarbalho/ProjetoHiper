namespace Chronos.Dtos
{
    public class ProdutoDto : BaseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
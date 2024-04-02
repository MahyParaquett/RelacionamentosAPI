namespace RelacionamentosAPI.Models
{
    public class CasaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public EnderecoModel Endereco { get; set; }

        public List<QuartoModel> Quartos { get; set; }

        public List<MoradorModel> Morador { get; set;}
    }
}

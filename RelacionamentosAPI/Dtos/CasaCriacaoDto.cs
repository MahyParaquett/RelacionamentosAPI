namespace RelacionamentosAPI.Dtos
{
    public class CasaCriacaoDto
    {
        public string Descricao { get; set; }

        public EnderecoCriacaoDto enderecoDto { get; set; }

        public List<QuartoCriacaoDto> quartos { get; set; }

        public List<MoradorCriacaoDto> moradores { get; set; }
    }
}

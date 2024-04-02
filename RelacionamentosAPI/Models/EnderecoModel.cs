using System.Text.Json.Serialization;

namespace RelacionamentosAPI.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }

        public int CasaId { get; set; }

        [JsonIgnore]// pra nao dar erro de cicle
        public CasaModel Casa { get; set; }

    }
}

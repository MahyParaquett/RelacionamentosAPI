using System.Text.Json.Serialization;

namespace RelacionamentosAPI.Models
{
    public class MoradorModel
    {
        public  int Id { get; set; }
        public string Nome { get; set; }

        [JsonIgnore]
        public List<CasaModel> Casa { get; set; }
    }
}

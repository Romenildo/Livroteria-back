using System.Text.Json.Serialization;

namespace Livroteria_back.Models
{
    public class Livro
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? SubTitulo { get; set; }
    }
}

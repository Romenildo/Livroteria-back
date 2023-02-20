using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Livroteria_back.Models
{
    public class Autor
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        [JsonIgnore]
        public Guid? LivroId { get; set; }
        [JsonIgnore]
        public Livro? Livro { get; set; }
    }
}

using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Livroteria_back.Models
{
    public class Livro
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo de Titulo é obrigatorio!")]
        public string? Titulo { get; set; }

        public string? SubTitulo { get; set; }

        public string? Resumo { get; set; }

        [Required(ErrorMessage = "A quantidade de páginas é obrigatorio!")]
        [Range(1, 10000, ErrorMessage = "Quantidade de paginas deve estar entre 1 e 10000")]
        public int? QuantPaginas { get; set; }

        public DateTime? DataPublicacao { get; set; }

        [Required(ErrorMessage = "O Campo de Editora é obrigatorio!")]
        public string? Editora { get; set; }

        [Range(0, 20, ErrorMessage = "Quantidade de paginas deve estar entre 1 e 20")]
        public int? Edicao { get; set; }

        public string? Imagem { get; set; }
        [JsonIgnore]
        public DateTime? Criado_em { get; set; }
        public ICollection<Autor>? Autores { get; set; }

        public string FormatarData() {
            string[]? novaData = this.DataPublicacao.ToString()?.Split(' ')[0]?.Split(':');
            return novaData?[0];
        }


    }
}

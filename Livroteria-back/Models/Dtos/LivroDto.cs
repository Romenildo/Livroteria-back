using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Livroteria_back.Models.Dtos
{
    public class LivroDto
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? SubTitulo { get; set; }
        public string? Resumo { get; set; }
        public int? QuantPaginas { get; set; }
        public string? Editora { get; set; }
        public string? DataPublicacao { get; set; }
        public int? Edicao { get; set; }
        public string? Imagem { get; set; }
        public DateTime? Criado_em { get; set; }
        public ICollection<Autor>? Autores { get; set; }
    }
}

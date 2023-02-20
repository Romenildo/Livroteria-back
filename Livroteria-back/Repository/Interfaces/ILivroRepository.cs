using Livroteria_back.Models;
using Livroteria_back.Models.Dtos;

namespace Livroteria_back.Repository.Interfaces
{
    public interface ILivroRepository
    {
        Task<List<LivroDto>> BuscarTodosLivros();
        Task<LivroDto> BuscarPorID(Guid id);
        Task<LivroDto> Adicionar(Livro livro);
        Task<LivroDto> Atualizar(Guid id, Livro livro);
        Task<Boolean> Deletar(Guid id);
    }
}

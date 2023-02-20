using AutoMapper;
using Livroteria_back.Data;
using Livroteria_back.Models;
using Livroteria_back.Models.Dtos;
using Livroteria_back.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Livroteria_back.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DataContext _dbcontext;
        private readonly IMapper _mapper;

        public LivroRepository(DataContext dataContext, IMapper mapper)
        {
            _dbcontext = dataContext;
            _mapper = mapper;
        }

        public async Task<LivroDto> BuscarPorID(Guid id)
        {
            var resultado = await _dbcontext.Livros.FirstOrDefaultAsync(x => x.Id == id);
            var resultadoDto = _mapper.Map<LivroDto>(resultado);
            return resultadoDto;
        }

        public async Task<List<LivroDto>> BuscarTodosLivros()
        {
            return await _dbcontext.Livros
                   .Select(x => new LivroDto {Titulo = x.Titulo})
                   .ToListAsync();
        }

        public async Task<LivroDto> Adicionar(Livro livro)
        {

            livro.Id = new Guid();

            await _dbcontext.Livros.AddAsync(livro);
            await _dbcontext.SaveChangesAsync();
            var resultadoDto = _mapper.Map<LivroDto>(livro);

            return resultadoDto;
        }

        public async Task<LivroDto> Atualizar(Guid id, Livro livro)
        {

            _dbcontext.Livros.Update(livro);
            await _dbcontext.SaveChangesAsync();

            var resultadoDto = _mapper.Map<LivroDto>(livro);
            return resultadoDto;
        }

        public async Task<Boolean> Deletar(Guid id)
        {
           Livro livroBd = await _dbcontext.Livros.FirstOrDefaultAsync(x => x.Id == id);

            if (livroBd == null)
            {
                throw new Exception($"Usuario com Id: {id} não encontrado!");
            }
            _dbcontext.Livros.Remove(livroBd);
            await _dbcontext.SaveChangesAsync();

            return true;
        }

    }
}

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

        public async Task<List<LivroDto>> BuscarTodosLivros()
        {
            return await _dbcontext.Livros
                   .Select(x => new LivroDto {Id = x.Id, Titulo = x.Titulo, SubTitulo = x.SubTitulo, Edicao = x.Edicao, Resumo = x.Resumo, Editora = x.Editora, Imagem = x.Imagem, QuantPaginas = x.QuantPaginas, Criado_em = x.Criado_em,DataPublicacao = x.FormatarData(), Autores = x.Autores })
                   .ToListAsync();
        }

        public async Task<LivroDto> Adicionar(Livro livro)
        {
            Livro livroBd = await _dbcontext.Livros.FirstOrDefaultAsync(x => x.Titulo == livro.Titulo && x.SubTitulo == livro.SubTitulo && x.Edicao == livro.Edicao && x.Editora == livro.Editora);

            if (livroBd != null)
            {
                    throw new Exception("Livro Já cadastrado!");   
            }

            livro.Id = new Guid();
            livro.Criado_em = DateTime.Now;

            await _dbcontext.Livros.AddAsync(livro);
            await _dbcontext.SaveChangesAsync();
            var resultadoDto = _mapper.Map<LivroDto>(livro);

            return resultadoDto;
        }

        public async Task<LivroDto> Atualizar(Guid id, Livro livro)
        {
            Livro livroBd = await _dbcontext.Livros.FirstOrDefaultAsync(x => x.Id == id);
            
            if (livroBd == null)
            {
                throw new Exception($"Livro com Id: {id} não encontrado!");
            }
            _dbcontext.Livros.Remove(livroBd);
            await _dbcontext.SaveChangesAsync();

            livroBd.Titulo = livro.Titulo;
            livroBd.SubTitulo= livro.SubTitulo;
            livroBd.Edicao = livro.Edicao;
            livroBd.Resumo = livro.Resumo;
            livroBd.DataPublicacao = livro.DataPublicacao;
            livroBd.Editora= livro.Editora;
            livroBd.QuantPaginas = livro.QuantPaginas;
            livroBd.Autores = livro.Autores;
            livroBd.Criado_em = DateTime.Now;
            livroBd.Imagem= livro.Imagem;
            livroBd.Autores = livro.Autores;
            
            
            await _dbcontext.Livros.AddAsync(livroBd);
            await _dbcontext.SaveChangesAsync();

            var resultadoDto = _mapper.Map<LivroDto>(livroBd);
            return resultadoDto;
        }

        public async Task<Boolean> Deletar(Guid id)
        {
           Livro livroBd = await _dbcontext.Livros.FirstOrDefaultAsync(x => x.Id == id);

            if (livroBd == null)
            {
                throw new Exception($"Livro com Id: {id} não encontrado!");
            }
            _dbcontext.Livros.Remove(livroBd);
            await _dbcontext.SaveChangesAsync();

            return true;
        }

    }
}

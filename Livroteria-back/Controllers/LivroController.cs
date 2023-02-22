using Livroteria_back.Models;
using Livroteria_back.Models.Dtos;
using Livroteria_back.Repository.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Livroteria_back.Controllers
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<LivroDto>>> BuscarTodosLivros()
        {
            List<LivroDto> resultado = await _livroRepository.BuscarTodosLivros();
            return resultado.Any() ? Ok(resultado) : BadRequest("Livros não encontrados");
        }

        [HttpPost]
        public async Task<ActionResult<LivroDto>> Cadastrar([FromBody] Livro Livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            LivroDto resultado = await _livroRepository.Adicionar(Livro);
            return Created($"v1/api/Livro/{resultado.Id}", resultado);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LivroDto>> Atualizar(Guid id, [FromBody] Livro Livro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Livro.Id = id;
            LivroDto resultado = await _livroRepository.Atualizar(id, Livro);
            return Ok(resultado);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Boolean>> Deletar(Guid id)
        {
            Boolean resultado = await _livroRepository.Deletar(id);
            return Ok(resultado);
        }




    }
}

using AutoMapper;
using Livroteria_back.Models;
using Livroteria_back.Models.Dtos;

namespace Livroteria_back.Config
{
    public class MappingLivros : Profile
    {
        public MappingLivros() 
        {
            CreateMap<Livro, LivroDto>();
        }
    }
}

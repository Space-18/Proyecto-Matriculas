using AutoMapper;
using Matriculas.Application.Models.Response.Cursos;
using Matriculas.Domain.Entities;

namespace Matriculas.Application.Mappings.Cursos
{
    internal class CursosAutoMapperProfile : Profile
    {
        public CursosAutoMapperProfile()
        {
            CreateMap<Curso, CursoListViewModel>();
            CreateMap<Curso, CursoWithSeccionViewModel>();
        }
    }
}

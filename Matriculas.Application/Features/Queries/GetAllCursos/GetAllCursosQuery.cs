using Matriculas.Application.Models.Response.Cursos;
using MediatR;

namespace Matriculas.Application.Features.Queries.GetAllCursos
{
    public record GetAllCursosQuery : IRequest<List<CursoListViewModel>>
    {
    }
}

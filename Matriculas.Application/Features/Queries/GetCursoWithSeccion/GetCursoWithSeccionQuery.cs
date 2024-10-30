using Matriculas.Application.Models.Response.Cursos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Features.Queries.GetCursoWithSeccion
{
    public record GetCursoWithSeccionQuery(long CursoId) : IRequest<CursoWithSeccionViewModel>;
}

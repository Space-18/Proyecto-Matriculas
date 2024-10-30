using Matriculas.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Matriculas.Application.Models.Response.Cursos
{
    internal record CursoListViewModel
    {
        public long IdCurso { get; set; }
        public string DesCurso { get; set; }
    }
}

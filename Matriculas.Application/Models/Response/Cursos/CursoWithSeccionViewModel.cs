using Matriculas.Application.Models.Response.Secciones;
using Matriculas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Models.Response.Cursos
{
    internal record CursoWithSeccionViewModel
    {
        public long IdCurso { get; set; }
        public string DesCurso { get; set; }
        public long IdSeccion { get; set; }
        public virtual SeccionViewModel Seccion { get; set; }
    }
}

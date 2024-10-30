using Matriculas.Application.Models.Response.Aulas;
using Matriculas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Models.Response.Secciones
{
    internal record SeccionViewModel
    {
        public long IdSeccion { get; set; }

        public long IdAula { get; set; }
        public virtual AulaViewModel Aula { get; set; }

        public string Turno { get; set; }
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
    }
}

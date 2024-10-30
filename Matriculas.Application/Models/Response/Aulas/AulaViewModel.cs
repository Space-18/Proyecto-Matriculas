using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Models.Response.Aulas
{
    internal record AulaViewModel
    {
        public long IdAula { get; set; }
        public int Capacidad { get; set; }

    }
}

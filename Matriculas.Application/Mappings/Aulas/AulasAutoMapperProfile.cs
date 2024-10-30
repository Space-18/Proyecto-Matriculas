using AutoMapper;
using Matriculas.Application.Models.Response.Aulas;
using Matriculas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Mappings.Aulas
{
    internal class AulasAutoMapperProfile : Profile
    {
        public AulasAutoMapperProfile()
        {
            CreateMap<Aula, AulaViewModel>();
        }
    }
}

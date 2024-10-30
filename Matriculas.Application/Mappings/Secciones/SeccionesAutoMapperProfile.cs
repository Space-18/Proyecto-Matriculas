using AutoMapper;
using Matriculas.Application.Models.Response.Secciones;
using Matriculas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Mappings.Secciones
{
    internal class SeccionesAutoMapperProfile : Profile
    {
        public SeccionesAutoMapperProfile()
        {
            CreateMap<Seccion, SeccionViewModel>();
        }
    }
}

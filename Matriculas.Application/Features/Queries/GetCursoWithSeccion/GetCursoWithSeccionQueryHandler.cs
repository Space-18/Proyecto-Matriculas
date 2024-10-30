using AutoMapper;
using Matriculas.Application.Contracts.Persistence;
using Matriculas.Application.Features.Queries.GetAllCursos;
using Matriculas.Application.Models.Response.Cursos;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriculas.Application.Features.Queries.GetCursoWithSeccion
{
    internal class GetCursoWithSeccionQueryHandler : IRequestHandler<GetCursoWithSeccionQuery, CursoWithSeccionViewModel>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<GetCursoWithSeccionQueryHandler> _logger;

        public GetCursoWithSeccionQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<GetCursoWithSeccionQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<CursoWithSeccionViewModel> Handle(GetCursoWithSeccionQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _unitOfWork.CursoRepository.GetCursoWithDetails(request.CursoId);

                return _mapper.Map<CursoWithSeccionViewModel>(data);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Hubo un error interno: {e}", e.Message);
                throw;
            }
        }
    }
}

using AutoMapper;
using Matriculas.Application.Contracts.Persistence;
using Matriculas.Application.Models.Response.Cursos;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Matriculas.Application.Features.Queries.GetAllCursos
{
    internal class GetAllCursosQueryHandler : IRequestHandler<GetAllCursosQuery, List<CursoListViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<GetAllCursosQueryHandler> _logger;

        public GetAllCursosQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<GetAllCursosQueryHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<CursoListViewModel>> Handle(GetAllCursosQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var data = await _unitOfWork.CursoRepository.GetAllAsync();

                return _mapper.Map<List<CursoListViewModel>>(data);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Hubo un error interno: {e}", e.Message);
                throw;
            }
        }
    }
}

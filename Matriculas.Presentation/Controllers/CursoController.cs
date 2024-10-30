using Matriculas.Application.Features.Queries.GetAllCursos;
using Matriculas.Application.Features.Queries.GetCursoWithSeccion;
using Matriculas.Presentation.Controllers.Commons;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Matriculas.Presentation.Controllers
{
    public class CursoController : BaseController
    {
        public CursoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("GetAll")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllCursosQuery()));
        }

        [HttpGet("GetOneWithSeccion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetOneWithSeccion(long cursoId)
        {
            return Ok(await _mediator.Send(new GetCursoWithSeccionQuery(cursoId)));
        }
    }
}

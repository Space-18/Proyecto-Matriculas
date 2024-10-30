using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Matriculas.Presentation.Controllers.Commons
{
    [Route("api/[controller]")]
    public class BaseController(IMediator mediator) : ControllerBase
    {
        protected readonly IMediator _mediator = mediator;
    }
}

using Matriculas.Presentation.Controllers.Commons;
using MediatR;

namespace Matriculas.Presentation.Controllers
{
    public class AulaController : BaseController
    {
        public AulaController(IMediator mediator) : base(mediator)
        {
        }

        //[HttpGet("GetAll")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult> GetAll()
        //{

        //}

        //[HttpPost("Insert")]
        //[ProducesResponseType((int)HttpStatusCode.OK)]
        //public async Task<ActionResult> Insert(Aula aula)
        //{

        //}
    }
}

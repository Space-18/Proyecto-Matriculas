using Matriculas.Presentation.Controllers.Commons;
using MediatR;

namespace Matriculas.Presentation.Controllers
{
    public class MatriculaController : BaseController
    {
        public MatriculaController(IMediator mediator) : base(mediator)
        {
        }
    }
}

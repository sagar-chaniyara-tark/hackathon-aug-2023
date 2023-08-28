using Microsoft.AspNetCore.Mvc;
using Worker.Service;

namespace Worker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecutionsController : ControllerBase
    {
        private readonly IExecution _execution;
        public ExecutionsController(IExecution execution)
        {
            _execution = execution;
        }

        [HttpPost]
        [Route("")]
        public IActionResult Execution()
        {
            _execution.Execute();
            return Ok();
        }
    }
}

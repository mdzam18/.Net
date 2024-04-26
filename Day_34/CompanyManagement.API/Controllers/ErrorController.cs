using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class ErrorController : Controller
    {
        [HttpGet]
        [Route("error-local-development")]
        public IActionResult ErrorLocalDevelopmen([FromServices] IWebHostEnvironment webHostEnv)
        {
            if (webHostEnv.EnvironmentName != "Development")
            {
                throw new InvalidOperationException("this should not be invoked non-developmemt enviroment");
            }

            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();

            return Problem(detail: context.Error.StackTrace, title: context.Error.Message, statusCode: 400);
        }

        [HttpGet]
        [Route("error")]
        public IActionResult Error([FromServices] IWebHostEnvironment webHostEnv)
        {
            return Problem();
        }
    }
}

using CompanyManagement.API.Infrastructure;
using CompanyManagement.Application;
using CompanyManagement.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        #region Endpoints

        [HttpGet]
        public List<string> GetCompanies()
        {
            return _companyService.GetCompanies();
        }


        [HttpGet("{id}")]
        public ActionResult<string> GetCompanyByName(string id)
        {
            try
            {
                var companies = _companyService.GetCompanyByName(id);
                return Ok(companies);
            }
            catch (CompanyNotFoundException ex)
            {
                return NotFound(new ApiError(HttpContext, ex));
            }
        }


        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(string id)
        {
            try
            {
                var companyDeleted = _companyService.Delete(id);
                return Ok(companyDeleted);
            }
            catch (CompanyNotFoundException ex)
            {
                return NotFound(new ApiError(HttpContext, ex));
            }
        }

        #endregion
    }
}

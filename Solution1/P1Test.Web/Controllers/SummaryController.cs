using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P1Test.Interfaces.Services;

namespace P1Test.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SummaryController : ControllerBase
    {
        private readonly IMiddleWareService _middleWareService;

        public SummaryController(IMiddleWareService middleWareService)
        {
            _middleWareService = middleWareService;
        }

        public async Task<IActionResult> Get()
        {
            return Ok(await _middleWareService.FirmSummary());
        }
    }
}

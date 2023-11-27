using Microsoft.AspNetCore.Mvc;
using P1Test.Interfaces.Services;
using P1Test.Models.FrontEnd;

namespace P1Test.Web.React.Server.Controllers
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
        

        [HttpGet(Name = "GetFirmSummary")]
        public async Task<PortFolioCollection> Get()
        {
            return await _middleWareService.FirmSummary();
        }
    }
}

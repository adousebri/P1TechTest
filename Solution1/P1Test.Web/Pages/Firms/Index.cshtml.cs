namespace P1Test.Web.Pages.Firms
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using P1Test.Interfaces.Services;
    using P1Test.Models.FrontEnd;

    [AllowAnonymous]
    public class IndexModel : PageModel
    {
        private readonly IMiddleWareService _middleWareService;

        public FirmSummary FirmSummary { get; set; }

        public IndexModel(IMiddleWareService middleWareService)
        {
            _middleWareService = middleWareService;
        }

        public async void OnGet()
        {
            FirmSummary = await _middleWareService.FirmSummary();

        }
    }
}

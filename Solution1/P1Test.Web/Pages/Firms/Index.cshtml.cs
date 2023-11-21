namespace P1Test.Web.Pages.Firms
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using P1Test.Interfaces.Services;

    public class IndexModel : PageModel
    {
        private readonly IMiddleWareService _middleWareService;

        public IndexModel(IMiddleWareService middleWareService)
        {
            _middleWareService = middleWareService;
        }

        public void OnGet()
        {
        }
    }
}

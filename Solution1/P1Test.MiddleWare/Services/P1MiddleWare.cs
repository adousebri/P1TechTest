namespace P1Test.MiddleWare.Services
{
    using P1Test.Interfaces.API;
    using P1Test.Interfaces.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class P1MiddleWare : IMiddleWareService
    {
        private readonly IPortfolioDataAPI _portfolioDataAPI;

        public P1MiddleWare(IPortfolioDataAPI portfolioDataAPI)
        {
            _portfolioDataAPI = portfolioDataAPI;
        }

        public object FirmSummary()
        {
            return null;
        }
    }
}

using P1Test.Models.FrontEnd;

namespace P1Test.Interfaces.Services
{
    public interface IMiddleWareService
    {
        Task<PortFolioCollection> FirmSummary();
    }
}

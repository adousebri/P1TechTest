using P1Test.Models.FrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Test.Interfaces.Services
{
    public interface IMiddleWareService
    {
        Task<FirmSummary> FirmSummary();
    }
}

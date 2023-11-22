namespace P1Test.API.SECCI.Test.Handlers
{
    using NUnit.Framework;
    using Moq;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using global::P1Test.API.SECCI.Handlers;
    using global::P1Test.API.SECCI.Requests;
    using global::P1Test.Interfaces.API;
    using global::P1Test.Models.FrontEnd;
    using global::P1Test.Models.SECCI;

    namespace P1Test.API.SECCI.Handlers.Tests
    {
        [TestFixture]
        public class GetPortfolioReportHandlerTests
        {
            [Test]
            public async Task Handle_ValidRequest_ReturnsPortfolioReportModel()
            {
                // Arrange
                var firmId = "testFirmId";
                var fromDate = new DateTime(2023, 1, 1);
                var toDate = new DateTime(2023, 1, 31);
                var request = new GetPortfolioReportRequest
                {
                    FirmId = firmId,
                    FromDate = fromDate,
                    ToDate = toDate
                };

                var expectedPortfolioReport = new ReportData(); // Replace with your expected data

                var portfolioDataApiMock = new Mock<IPortfolioDataAPI>();
                portfolioDataApiMock.Setup(api => api.GetPortfolioReport(firmId, fromDate, toDate))
                    .ReturnsAsync(expectedPortfolioReport);

                var handler = new GetPortfolioReportHandler(portfolioDataApiMock.Object);

                // Act
                var result = await handler.Handle(request, CancellationToken.None);

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOf<PortfolioReportModel>(result);
                // Add more specific assertions based on your implementation and expected behavior
            }
        }
    }

}

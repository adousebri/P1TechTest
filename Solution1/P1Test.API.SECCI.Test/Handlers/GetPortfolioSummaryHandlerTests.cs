namespace P1Test.API.SECCI.Test.Handlers
{
    using NUnit.Framework;
    using Moq;
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
        public class GetPortfolioSummaryHandlerTests
        {
            [Test]
            public async Task Handle_ValidRequest_ReturnsPortfolioSummaryModel()
            {
                // Arrange
                var firmId = "testFirmId";
                var id = "testId";
                var request = new GetPortfolioSummaryRequest
                {
                    FirmId = firmId,
                    Id = id
                };

                var expectedPortfolioSummary = new SummaryData(); // Replace with your expected data

                var portfolioDataApiMock = new Mock<IPortfolioDataAPI>();
                portfolioDataApiMock.Setup(api => api.GetPortfolioSummary(firmId, id))
                    .ReturnsAsync(expectedPortfolioSummary);

                var handler = new GetPortfolioSummaryHandler(portfolioDataApiMock.Object);

                // Act
                var result = await handler.Handle(request, CancellationToken.None);

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOf<PortfolioSummaryModel>(result);
                // Add more specific assertions based on your implementation and expected behavior
            }
        }
    }

}

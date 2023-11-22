namespace P1Test.API.SECCI.Test.Handlers
{
    using NUnit.Framework;
    using Moq;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using global::P1Test.API.SECCI.Requests;
    using global::P1Test.Models.SECCI;
    using global::P1Test.API.SECCI.Handlers;
    using global::P1Test.Interfaces.API;
    using global::P1Test.Models.FrontEnd;

    namespace P1Test.API.SECCI.Handlers.Tests
    {
        [TestFixture]
        public class GetListPortFoliosHandlerTests
        {
            [Test]
            public async Task Handle_ValidRequest_ReturnsPortFolioCollection()
            {
                // Arrange
                var firmId = "testFirmId";
                var request = new GetListPortFoliosRequest { FirmId = firmId };
                var expectedPortFolios = new List<ListPortFoliosData> { /* Populate with test data */ };

                var portfolioDataApiMock = new Mock<IPortfolioDataAPI>();
                portfolioDataApiMock.Setup(api => api.GetListPortFolios(firmId))
                    .ReturnsAsync(expectedPortFolios);

                var handler = new GetListPortFoliosHandler(portfolioDataApiMock.Object);

                // Act
                var result = await handler.Handle(request, CancellationToken.None);

                // Assert
                Assert.IsNotNull(result);
                Assert.IsInstanceOf<PortFolioCollection>(result);
                Assert.IsNotNull(result.PortFolios);
                Assert.AreEqual(expectedPortFolios.Count, result.PortFolios.Count());
                // Add more specific assertions based on your implementation and expected behavior
            }
        }
    }

}

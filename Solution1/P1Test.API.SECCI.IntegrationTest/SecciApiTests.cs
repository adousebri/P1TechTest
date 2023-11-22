using Microsoft.Extensions.Configuration;
using Moq;
using P1Test.Interfaces.API;
using P1Test.Models.SECCI;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1Test.API.SECCI.IntegrationTest
{
    public class SecciApiTests
    {
        private ISecciClient _restClient;
        private Mock<IConfiguration> _configuration;
        private SecciApi _secciApi;

        [SetUp]
        public void Setup()
        {
            _configuration = new Mock<IConfiguration>();
            _configuration.Setup(r => r["Secci.BaseUrl"])
                .Returns("http://localhost:3001");

            _secciApi = new SecciApi(new SecciClient(_configuration.Object));
        }

        [Test]

        public async Task Authenticate_ValidCredentials_ReturnsAuthenticationData()
        {
            // Arrange
            var firmId = "testFirmId";
            var userId = "testUserId";
            var userPassword = "testPassword";
            var expectedAuthenticationData = new AuthenticationData();

            // Act
            var result = await _secciApi.Authenticate(firmId, userId, userPassword);

            // Assert
            Assert.AreEqual(expectedAuthenticationData, result);
        }

        [Test]
        public async Task GetListPortFolios_ValidFirmId_ReturnsListPortFoliosDataList()
        {
            // Arrange
            var firmId = "testFirmId";
            var expectedListPortFoliosData = new List<ListPortFoliosData>();

            // Act
            var result = await _secciApi.GetListPortFolios(firmId);

            // Assert
            Assert.AreEqual(expectedListPortFoliosData, result);
        }

        [Test]
        public async Task GetPortfolioReport_ValidParameters_ReturnsReportData()
        {
            // Arrange
            var firmId = "testFirmId";
            var fromDate = DateTime.Now.AddDays(-7);
            var toDate = DateTime.Now;
            var expectedReportData = new ReportData();

            // Act
            var result = await _secciApi.GetPortfolioReport(firmId, fromDate, toDate);

            // Assert
            Assert.AreEqual(expectedReportData, result);
        }

        [Test]
        public async Task GetPortfolioSummary_ValidParameters_ReturnsSummaryData()
        {
            // Arrange
            var firmId = "testFirmId";
            var id = "testId";
            var expectedSummaryData = new SummaryData();

            // Act
            var result = await _secciApi.GetPortfolioSummary(firmId, id);

            // Assert
            Assert.AreEqual(expectedSummaryData, result);
        }

        [TearDown]
        public void TearDown()
        { 
            _secciApi = null;
        }
    }
}

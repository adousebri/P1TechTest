namespace P1Test.API.SECCI.Tests
{
    using RestSharp;
    using P1Test.Models.SECCI;


    [TestFixture]
    [Ignore("The latest version of RestSharp changd ExecuteAsync() to an extension method. Using Integration tests instead")]
    public class SecciApiTests
    {
        private IRestClient _restClient;
        private SecciApi _secciApi;

        [SetUp]
        public void Setup()
        {
            _restClient = new RestClient("http:\\localhost:3001");
            _secciApi = new SecciApi(_restClient);
        }

        [Test]

        public async Task Authenticate_ValidCredentials_ReturnsAuthenticationData()
        {
            // Arrange
            var firmId = "testFirmId";
            var userId = "testUserId";
            var userPassword = "testPassword";
            var expectedAuthenticationData = new AuthenticationData(); // Set your expected data here

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
            var expectedListPortFoliosData = new List<ListPortFoliosData>(); // Set your expected data here

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
            var expectedReportData = new ReportData(); // Set your expected data here

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
            _restClient = null;
            _secciApi = null;
        }
    }
}

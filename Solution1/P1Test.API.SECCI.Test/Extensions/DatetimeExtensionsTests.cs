namespace P1Test.API.SECCI.Test.Extensions
{
    using global::P1Test.API.SECCI.Extensions;
    using NUnit.Framework;
    using System;

    namespace P1Test.API.SECCI.Extensions.Tests
    {
        [TestFixture]
        public class DatetimeExtensionsTests
        {
            [Test]
            public void StartOfToday_ValidInput_ReturnsStartOfToday()
            {
                // Arrange
                var currentDate = DateTime.Now;

                // Act
                var startOfToday = currentDate.StartOfToday();

                // Assert
                Assert.That(startOfToday.Year, Is.EqualTo(currentDate.Year));
                Assert.That(startOfToday.Month, Is.EqualTo(currentDate.Month));
                Assert.That(startOfToday.Day, Is.EqualTo(currentDate.Day));
                Assert.That(startOfToday.Hour, Is.EqualTo(0));
                Assert.That(startOfToday.Minute, Is.EqualTo(0));
                Assert.That(startOfToday.Second, Is.EqualTo(0));
            }

            [Test]
            public void EndOfToday_ValidInput_ReturnsEndOfToday()
            {
                // Arrange
                var currentDate = DateTime.Now;

                // Act
                var endOfToday = currentDate.EndOfToday();

                // Assert
                Assert.That(endOfToday.Year, Is.EqualTo(currentDate.Year));
                Assert.That(endOfToday.Month, Is.EqualTo(currentDate.Month));
                Assert.That(endOfToday.Day, Is.EqualTo(currentDate.Day));
                Assert.That(endOfToday.Hour, Is.EqualTo(23));
                Assert.That(endOfToday.Minute, Is.EqualTo(59));
                Assert.That(endOfToday.Second, Is.EqualTo(59));
            }
        }
    }

}

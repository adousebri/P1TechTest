namespace P1Test.API.SECCI.Extensions
{
    public static class DatetimeExtensions
    {
        public static DateTime StartOfToday(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
        }

        public static DateTime EndOfToday(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
        }
    }
}

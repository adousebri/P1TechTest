namespace P1Test.Models.SECCI
{
    public class Root<T>
        where T: class
    {
        public T Data { get; set; }

        public Meta meta { get; set; }
    }
}

namespace P1Test.Models.SECCI
{
    public class AuthenticationData
    {
        public string Token { get; set; }
        public string UserName { get; set; }
        public string UserType { get; set; }
        public List<AuthenticationScope> Scopes { get; set; }
        public List<string> Services { get; set; }
    }

}

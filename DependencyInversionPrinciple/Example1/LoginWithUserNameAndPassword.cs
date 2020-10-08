namespace DependencyInversionPrinciple.Example1
{
    public class LoginWithUserNameAndPassword : ILogin
    {
        private readonly string _username;
        private readonly string _password;

        public LoginWithUserNameAndPassword(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public bool IsUserValid()
        {
            return _username.Equals("ABC") && _password.Equals("1234"); // Used Dummy Data for simplicity
        }
    }
}

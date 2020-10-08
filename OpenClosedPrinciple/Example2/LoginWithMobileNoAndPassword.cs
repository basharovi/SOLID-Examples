namespace OpenClosedPrinciple.Example2
{
    public class LoginWithMobileNoAndPassword : ILogin
    {
        private readonly int _mobileNo;
        public readonly string _password;

        public LoginWithMobileNoAndPassword(int mobileNo, string password)
        {
            _mobileNo = mobileNo;
            _password = password;
        }


        public bool IsUserValid()
        {
            return _mobileNo == 017 && _password.Equals("1234"); // Used Dummy Data for simplicity
        }
    }
}

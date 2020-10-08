namespace OpenClosedPrinciple.Example2
{
    class LoginWithUserNameAndPassword : ILogin
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public bool IsUserValid()
        {
            return Username.Equals("ABC") && Password.Equals("1234"); // Used Dummy Data for simplicity
        }
    }
}

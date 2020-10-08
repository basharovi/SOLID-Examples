namespace OpenClosedPrinciple.Example2
{
    class LoginWithMobileNoAndPassword : ILogin
    {
        public int MobileNo { get; set; }
        public string Password { get; set; }


        public bool IsUserValid()
        {
            return MobileNo == 017 && Password.Equals("1234"); // Used Dummy Data for simplicity
        }
    }
}

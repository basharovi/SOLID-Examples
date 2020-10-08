namespace SingleResponsibilityPrinciple.Example1
{
    public static class Price
    {
        private const decimal CurrentUnitPrice = 100; // Used Dummy Data for simplicity

        public static decimal GetSingleItemPrice()
        {
            return CurrentUnitPrice;
        }
    }
}

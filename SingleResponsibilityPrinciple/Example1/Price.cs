namespace SingleResponsibilityPrinciple.Example1
{
    public static class Price
    {
        private static decimal currentUnitPrice = 100; // Used Dummy Data for simplicity

        public static decimal GetSingleItemPrice()
        {
            return currentUnitPrice;
        }
    }
}

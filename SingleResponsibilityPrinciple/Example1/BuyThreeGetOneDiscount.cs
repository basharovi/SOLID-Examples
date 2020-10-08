namespace SingleResponsibilityPrinciple.Example1
{
    public class BuyThreeGetOneDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal singleItemPrice, int quantity)
        {
            return singleItemPrice * (quantity / 3);
        }
    }
}

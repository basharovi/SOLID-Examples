namespace SingleResponsibilityPrinciple.Example1
{
    public class BuyTwoGetOneDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal singleItemPrice, int quantity)
        {
            return singleItemPrice * (quantity / 2);
        }
    }
}

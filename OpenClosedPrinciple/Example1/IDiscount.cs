namespace OpenClosedPrinciple.Example1
{
    public interface IDiscount
    {
        decimal CalculateDiscount(decimal singleItemPrice, int quantity);
    }
}

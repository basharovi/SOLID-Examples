namespace SingleResponsibilityPrinciple.Example1
{
    public class BillCalculator
    {
        private readonly IDiscount _discount;
        private readonly decimal _singleItemPrice;

        public BillCalculator(IDiscount discount)
        {
            _discount = discount;
            _singleItemPrice = Price.GetSingleItemPrice();
        }

        public decimal CalculatePayableBill(int quantity)
        {
            var totalPrice = _singleItemPrice * quantity;
            var discountAmount = _discount.CalculateDiscount(_singleItemPrice, quantity);

            return totalPrice - discountAmount;
        }
    }
}

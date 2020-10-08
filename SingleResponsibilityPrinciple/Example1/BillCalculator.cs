namespace SingleResponsibilityPrinciple.Example1
{
    class BillCalculator
    {
        private readonly IDiscount _discount;
        private readonly decimal singleItemPrice;

        public BillCalculator(IDiscount discount)
        {
            _discount = discount;
            singleItemPrice = Price.GetSingleItemPrice();
        }

        public decimal CalculatePaybleBill(int quantity)
        {
            return _discount.CalculateDiscount(singleItemPrice, quantity);
        }
    }
}

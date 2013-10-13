namespace PricingABasket.Items
{
    class Apples : IItem
    {
        public string Description
        {
            get { return "Apples"; }
        }

        public decimal Price
        {
            get { return 1.00m; }
        }

        public UnitType Unit
        {
            get { return UnitType.Bag; }
        }
    }
}

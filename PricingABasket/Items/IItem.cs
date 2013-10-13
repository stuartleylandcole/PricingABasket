namespace PricingABasket.items
{
    public interface IItem
    {
        string Description { get; }
        decimal Price { get; }
        UnitType Unit { get; }
    }

    public enum UnitType
    {
        Tin, Loaf, Bottle, Bag
    }
}

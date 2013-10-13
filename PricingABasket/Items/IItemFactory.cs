namespace PricingABasket.Items
{
    public interface IItemFactory
    {
        IItem CreateItem(string description);
    }
}

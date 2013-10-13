using PricingABasket.Offers;
namespace PricingABasket.Pricing
{
    public class OfferAndSaving
    {
        private readonly IOffer _offer;
        public decimal Saving { get; private set; }
        
        private OfferAndSaving(IOffer offer, decimal saving)
        {
            _offer = offer;
            Saving = saving;
        }
        
        public string Description
        {
            get { return _offer.Description; }
        }
    }
}

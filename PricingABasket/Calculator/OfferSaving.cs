using PricingABasket.Items.Offers;

namespace PricingABasket.Calculator
{
    public class OfferSaving
    {
        private readonly IOffer _offer;
        public decimal Saving { get; private set; }
        
        public OfferSaving(IOffer offer, decimal saving)
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

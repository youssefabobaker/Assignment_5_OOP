namespace Assignment_5
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost
        { 
            get { throw new NotImplementedException(); } 
        }

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}

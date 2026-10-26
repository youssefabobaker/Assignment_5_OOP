
namespace Assignment_5
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment (string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5);
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
            
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} {Trackingstatus}.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m; 
        }

        public void UpdateTrackingStatus()
        {
            if(Trackingstatus == "is Ready")
            {
                Trackingstatus = "is Out for Delivery";
            }
            else if (Trackingstatus == "is Out for Delivery")
            {
                Trackingstatus = "has been Delivered";
            }
            OnTrackingStatusChanged(Trackingstatus);
        }
    }
}


namespace Assignment_5
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                if (value >= 0)
                    extraFee = value;
            }
        }

        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.extraFee = extraFee;
        }

        

        public override decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5) + extraFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Extra Fee: ${ExtraFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} {Trackingstatus}.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }

        public void UpdateTrackingStatus()
        {
            if (Trackingstatus == "is Ready")
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

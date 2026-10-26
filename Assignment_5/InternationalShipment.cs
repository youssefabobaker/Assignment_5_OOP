
namespace Assignment_5
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        private string destinationCountry;
        private decimal customsFee;
        public String DestinationCountry
        {
            get 
            { 
                return destinationCountry; 
            }
            set
            {
                if (value != null && value != string.Empty && value != " ")
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value >= 0)
                    customsFee = value;
            }
        }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.destinationCountry = destinationCountry;
            this.customsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get => DeliveryFee + ((decimal)Weight * 5) + CustomsFee;
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} kg");
            Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Destination Country: {DestinationCountry}");
            Console.WriteLine($"Customs Fee: ${CustomsFee}");
            Console.WriteLine($"Estimated Cost: ${EstimatedCost}");
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Customs Report for Shipment {TrackingCode}:");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} {Trackingstatus}.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
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

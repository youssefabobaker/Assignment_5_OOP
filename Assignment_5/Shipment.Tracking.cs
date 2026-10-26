namespace Assignment_5
{
    internal partial class Shipment
    {
        private string trackingstatus;
        public string Trackingstatus
        {
            get { return trackingstatus; }
            set { trackingstatus = value; }
        }

        protected partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status of shipment {TrackingCode} changed to: {newStatus}");
        }

    }
}

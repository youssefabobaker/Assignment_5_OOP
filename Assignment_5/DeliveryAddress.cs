
namespace Assignment_5
{
    internal struct DeliveryAddress
    {
        public String City { get; set; }
        public String Street { get; set; }
        public int BuildingNumber { get; set; }

        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }

        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street} Street, {City}";
        }
    }
}

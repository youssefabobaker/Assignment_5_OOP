
namespace Assignment_5.StaticClasses;

internal static class ShipmentExtensions
{
    public static string GetSummary(this Shipment shipment)
    {
        string shipmentType = shipment.GetType().Name.Replace("Shipment", string.Empty);
        return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight}KG | {shipment.Trackingstatus}";
    }

    public static bool IsDelivered(this Shipment shipment)
    {
        if (shipment is ITrackable trackable)
            return trackable.GetTrackingStatus().Contains("Delivered", StringComparison.OrdinalIgnoreCase);
        return false;
    }
}

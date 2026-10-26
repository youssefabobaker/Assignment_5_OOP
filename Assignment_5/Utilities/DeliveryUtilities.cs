namespace Assignment_5.Utilities;

internal static class DeliveryUtilities
{
    public static void PrintSeparator()
    {
        Console.WriteLine(new string('=', 30));
    }

    public static void PrintSystemTitle()
    {
        PrintSeparator();
        Console.WriteLine("Delivery Center");
        PrintSeparator();
    }
}

while(true)
{
try
{
    Console.WriteLine("Enter choice and parcel weight");
    var delivery = Console.ReadLine();

    Console.WriteLine("Enter choice and parcel weight");
    var weight = decimal.Parse(Console.ReadLine());

    if (string.IsNullOrWhiteSpace(delivery))
    {
        Console.WriteLine("Invalid input");
        return;
    }
    //creating a calculator factory
    IDeliveryCalculator calculator = DeliveryCalculatorFactory.CalculatorFactory(delivery);

    //using the calculator factory to calculate the price of delivery
    decimal price = calculator.Calculator(weight);
    
    Console.WriteLine($"Delivery cost: {price:C}");
}
catch(ArgumentException ex)
{
    Console.WriteLine($"Input error: {ex.Message}");
}
catch(FormatException)
    {
        Console.WriteLine("Weight must be a number");
    }
}
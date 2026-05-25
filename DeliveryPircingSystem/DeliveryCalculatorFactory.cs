public static class DeliveryCalculatorFactory
{
    public static IDeliveryCalculator CalculatorFactory(string calculator)
    {
        IDeliveryCalculator calculate = calculator.ToLower() switch
        {
            "standard" => new StandardCalculator(),
            "express" => new ExpressCalculator(),
            "overnight" => new OvernightCalculator(),
            _ => throw new ArgumentException("Invalid delivery method")
        };
        return calculate;
    }
}
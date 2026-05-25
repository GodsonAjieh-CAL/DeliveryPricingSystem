public interface IDeliveryCalculator
{
    decimal Calculator(decimal weight);
}

public class StandardCalculator : IDeliveryCalculator
{
    public decimal Calculator(decimal weight) => weight * 0.80m + 2.50m;
}

public class ExpressCalculator : IDeliveryCalculator
{
    public decimal Calculator(decimal weight) => weight * 1.50m + 5.00m;
}
public class OvernightCalculator : IDeliveryCalculator
{
    
    public decimal Calculator(decimal weight)
    {
        decimal subtotal = weight * 2.20m + 10.0m;
        return subtotal * 1.15m;
    }
        
}
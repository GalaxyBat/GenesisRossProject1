namespace GenesisRossProject1.Models;

public class Shopper
{
    public string? Name { get; set; }
    public decimal MoneyAvailable { get; set; }
    private List<Car> _cars;

    public Shopper(string? name, decimal moneyAvailable)
    {
        Name = name;
        MoneyAvailable = moneyAvailable;
        _cars = [];

        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name can not be null");
        }

        if (moneyAvailable < 0m)
        {
            throw new ArgumentException("Your money can't be below 0");
        }
    }

    public bool CanPurchase(Car car)
    {
        return MoneyAvailable >= car.Price + CarLot.TaxRate;
    }

    public void PurchaseCar(Car car)
    { 
        _cars.Add(car);
        MoneyAvailable -= car.Price + CarLot.TaxRate;
    }
}
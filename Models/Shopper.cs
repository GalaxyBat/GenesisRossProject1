using System.Text;

namespace GenesisRossProject1.Models;

public class Shopper
{
    public string? Name { get; set; }
    public decimal MoneyAvailable { get; set; }
    public List<Car> Cars { get; }

    public Shopper(string? name, decimal moneyAvailable)
    {
        Name = name;
        MoneyAvailable = moneyAvailable;
        Cars = [];

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
        Cars.Add(car);
        MoneyAvailable -= car.Price + CarLot.TaxRate;
    }

    override
        public string ToString()
    {
        var shopperBuilder = new StringBuilder();
        shopperBuilder.AppendLine("Shopper: " + Name + "      Funds Available: $" + MoneyAvailable.ToString("C"));
        shopperBuilder.AppendLine("\n" + "# of Cars Purchased: " + Cars);
        return shopperBuilder.ToString();
    }
}
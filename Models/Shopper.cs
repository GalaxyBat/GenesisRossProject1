using System.Text;

namespace GenesisRossProject1.Models;
/// <summary>
/// The Class Shopper
/// </summary>
public class Shopper
{
    public string? Name { get; set; }
    public decimal MoneyAvailable { get; set; }
    public List<Car> Cars { get; }

    /// <summary>
    /// The constructor to create the class Shopper
    /// </summary>
    /// <param name="name">The name of the shopper</param>
    /// <param name="moneyAvailable">The money the shopper have available to buy car(s)</param>
    /// <exception cref="ArgumentException"></exception>
    public Shopper(string? name, decimal moneyAvailable)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name can not be null");
        }

        if (moneyAvailable < 0m)
        {
            throw new ArgumentException("Your money can't be below 0");
        }

        Name = name;
        MoneyAvailable = moneyAvailable;
        Cars = [];
    }

    /// <summary>
    /// Checks to see if the car can be purchased by the shopper
    /// </summary>
    /// <param name="car"></param>
    /// <returns></returns>
    public bool CanPurchase(Car car)
    {
        return MoneyAvailable >= car.Price + CarLot.TaxRate;
    }
    /// <summary>
    /// Allows the car to be purchased
    /// </summary>
    /// <param name="car"></param>
    public void PurchaseCar(Car car)
    { 
        Cars.Add(car);
        MoneyAvailable -= car.Price + CarLot.TaxRate;
    }

    /// <summary>
    /// Creating the output for the Car Class
    /// </summary>
    /// <returns></returns>
    override
        public string ToString()
    {
        var shopperBuilder = new StringBuilder();
        shopperBuilder.AppendLine("Shopper: " + Name + "      Funds Available: " + MoneyAvailable.ToString("C"));
        shopperBuilder.AppendLine("\n" + "# of Cars Purchased: " + Cars.Count);
        return shopperBuilder.ToString();
    }
}
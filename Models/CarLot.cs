using System.Text;

namespace GenesisRossProject1.Models;

/// <summary>
/// The Class CarLot
/// </summary>
public class CarLot
{
    public const decimal TaxRate = 0.078m;
    public int InventoryCount => Inventory.Count;
    public List<Car> Inventory { get; }

    /// <summary>
    /// The Constructor the creates CarLot
    /// </summary>
    public CarLot()
    {
        Inventory = [];
        StockLotWithDefaultInventory();
    }

    /// <summary>
    /// Loads the car lot with default values
    /// </summary>
    private void StockLotWithDefaultInventory()
    {
        Inventory.Add(new Car("Ford", "Focus ST", 28.3m, 26298.98m));
        Inventory.Add(new Car("Chevrolet", "Camaro ZL1", 19m, 65401.23m));
        Inventory.Add(new Car("Honda", "Accord Sedan EX", 30.2m, 26780m));
        Inventory.Add(new Car("Lexus", "ES 350", 24.1m, 42101.10m));

    }

    /// <summary>
    /// Finds the cars by the name of the maker
    /// </summary>
    /// <param name="make">The make of the car</param>
    /// <returns>The list of the cars made by a certain maker</returns>
    public List<Car> FindCarsByMake(string? make)
    {
        List<Car> carsByMake = [];
        foreach (var car in Inventory)
        {
            if (car.Make != null && car.Make.Equals(make, StringComparison.OrdinalIgnoreCase))
            {
                carsByMake.Add(car);
            }
        }
        return carsByMake;
    }

    /// <summary>
    /// Finds the cars by the name of the model
    /// </summary>
    /// <param name="model">The model of the car</param>
    /// <returns>A list of cars with the same model</returns>
    public List<Car> FindCarsByModel(string? model)
    {
        List<Car> carsByModel = [];
        foreach (var car in Inventory)
        {
            if (car.Model != null && car.Model.Equals(model, StringComparison.OrdinalIgnoreCase))
            {
                carsByModel.Add(car);
            }
        }
        return carsByModel;
    }

    /// <summary>
    /// Buys the car by the make and model
    /// </summary>
    /// <param name="make">The make of the car</param>
    /// <param name="model">The model of the car</param>
    /// <returns>The car that was bought</returns>
    public Car? PurchaseCar(string? make, string? model)
    {
        Car? purchasedCar = null;
        foreach (var car in Inventory.ToList())
        {
            if (car.Make == null || !car.Make.Equals(make, StringComparison.OrdinalIgnoreCase) ||
                car.Model == null || !car.Model.Equals(model, StringComparison.OrdinalIgnoreCase)) continue;
            purchasedCar = car;
            Inventory.Remove(purchasedCar);
        }

        return purchasedCar;
    }

    /// <summary>
    /// Adds a car to the inventory by the make, model, mpg, and price
    /// </summary>
    /// <param name="make">The make of the car</param>
    /// <param name="model">The model of the car</param>
    /// <param name="mpg">How much mileage the car has</param>
    /// <param name="price">The price of the car</param>
    public void AddCar(string? make, string? model, decimal mpg, decimal price)
    {
        var newCar = new Car(make, model, mpg, price);
        Inventory.Add(newCar);
    }


    /// <summary>
    /// Calculates the total cost of your purchases
    /// </summary>
    /// <returns>The total cost of your purchases</returns>
    public decimal GetTotalCostOfPurchase()
    {
        var totalPrice = Inventory.Sum(car => car.Price);

        totalPrice += TaxRate;
        return totalPrice;
    }

    /// <summary>
    /// Compares the cars' prices and finds the least expensive car in the lot
    /// </summary>
    /// <returns>The least expensive car</returns>
    public Car? FindLeastExpensiveCar()
    {
        Car? leastExpensiveCar = null;
        const decimal minPrice = decimal.MaxValue;
        foreach (var car in Inventory.Where(car => car.Price < minPrice))
        {
            leastExpensiveCar = car;
        }
        return leastExpensiveCar;
    }

    /// <summary>
    /// Compares the cars' prices and finds the most expensive car in the lot
    /// </summary>
    /// <returns>The most expensive car</returns>
    public Car? FindMostExpensiveCar()
    {
        Car? mostExpensiveCar = null;
        const decimal maxPrice = decimal.MinValue;
        foreach (var car in Inventory.Where(car => car.Price > maxPrice))
        {
            mostExpensiveCar = car;
        }
        return mostExpensiveCar;
    }

    /// <summary>
    /// Compares the cars' mileage and finds the car with the best mileage in the lot
    /// </summary>
    /// <returns>The car with the best mileage</returns>
    public Car? FindBestMpgCar()
    {
        Car? bestMpgCar = null;
        const decimal bestMpg = decimal.MinValue;
        foreach (var car in Inventory.Where(car => car.Mpg > bestMpg))
        {
            bestMpgCar = car;
        }
        return bestMpgCar;
    }

    /// <summary>
    /// Compares the cars' mileage and finds the car with the worst mileage in the lot
    /// </summary>
    /// <returns>The car with the worst mileage</returns>
    public Car? FindWorstMpgCar()
    {
        Car? worstMpgCar = null;
        const decimal worstMpg = decimal.MaxValue;
        foreach (var car in Inventory.Where(car => car.Mpg < worstMpg))
        {
            worstMpgCar = car;
        }
        return worstMpgCar;
    }

    override
        public string ToString()
    {
        var carLotBuilder = new StringBuilder();
        carLotBuilder.AppendLine("Inventory of " + InventoryCount + " cars" + "\n" + Inventory);
        carLotBuilder.AppendLine("\n" + "Most expensive" + "\n" + FindMostExpensiveCar());
        carLotBuilder.AppendLine("\n" + "Least expensive" + "\n" + FindLeastExpensiveCar());
        carLotBuilder.AppendLine("\n" + "Best MPG" + "\n" + FindBestMpgCar());
        carLotBuilder.AppendLine("\n" + "Worst" + "\n" + FindWorstMpgCar());

        return carLotBuilder.ToString();
    }
    
}
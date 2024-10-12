namespace GenesisRossProject1.Models;

/// <summary>
/// The Class Car
/// </summary>
public class Car
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public decimal Mpg { get; set; }
    public decimal Price { get; set; }

    /// <summary>
    /// The Constructor for Class Car
    /// </summary>
    /// <param name="make"> The make of the car</param>
    /// <param name="model">The model of the care</param>
    /// <param name="mpg">The miles per gallon for the car</param>
    /// <param name="price">The price of the car</param>
    /// <exception cref="ArgumentException"></exception>
    public Car(string? make, string? model, decimal mpg, decimal price)
    {

        if (string.IsNullOrWhiteSpace(make))
        {
            throw new ArgumentException("Make's name can not be null");
        }

        if (string.IsNullOrWhiteSpace(model))
        {
            throw new ArgumentException("Model's name can not be null or empty");
        }

        if (mpg is < 0.00m or > 200.00m)
        {
            throw new ArgumentException("MGP can not be less than 0 or greater then 200.00");
        }

        if (price is < 0.00m or > 200000.00m)
        {
            throw new ArgumentException("Price can not be less than 0 dollars or more than 200,000 dollars");
        }

        Make = make;
        Model = model;
        Mpg = mpg;
        Price = price;

    }

    /// <summary>
    /// Creating the output for the Car Class
    /// </summary>
    /// <returns></returns>
    override
        public string ToString()
    {
        return Make + " " + Model + " " + Price.ToString("C") + " " + Mpg.ToString("F1") + "mpg";
    }

}
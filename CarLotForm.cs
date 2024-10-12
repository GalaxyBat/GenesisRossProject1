using GenesisRossProject1.Models;
using GenesisRossProject1.View;

namespace GenesisRossProject1;

/// <summary>
/// The Partial Class CarLotForm
/// </summary>
public partial class CarLotForm : Form
{
    private CarForm _carForm = null!;
    private ShopperForm _shopperForm = null!;
    private readonly CarLot _carLot;

    /// <summary>
    /// The constructor for CarLotForm
    /// </summary>
    public CarLotForm()
    {
        InitializeComponent();
        _carLot = new CarLot();
        LoadInventory();
    }

    /// <summary>
    /// Preloads Car Lot
    /// </summary>
    private void LoadInventory()
    {
        foreach (var car in _carLot.Inventory)
        {
            carLotListBox.Items.Add($"{car.Make} {car.Model} {car.Price:C} {car.Mpg:F1}");
        }
    }

    /// <summary>
    /// Adds a car to the carLotListBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addCarButton_Click(object sender, EventArgs e)
    {
        try
        {
            _carForm = new CarForm();
            _carForm.ShowDialog();
            _carLot.AddCar(_carForm.Car);
            carLotListBox.DataSource = null;
            carLotListBox.Items.Clear();
            carLotListBox.DataSource = _carLot.Inventory;
            carLotListBox.Refresh();
        }
        catch (Exception exception)
        {
            ErrorMessage(exception.Message);
        }

    }

    /// <summary>
    /// Message box showing the inventory of the car lot
    /// </summary>
    private void InventoryMessageBox()
    {
        var inventory = _carLot.ToString();
        const string caption = "The Inventory";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(inventory, caption, buttons);
    }

    /// <summary>
    /// Shows an error message if an error occurs
    /// </summary>
    /// <param name="errorMessage"></param>
    private static void ErrorMessage(string errorMessage)
    {
       const string caption = "Error Message";
       const MessageBoxButtons buttons = MessageBoxButtons.OK;
       MessageBox.Show(errorMessage, caption, buttons);
    }

    /// <summary>
    /// Tells Shopper that they don't have enough money
    /// </summary>
    private static void NotEnoughMoney()
    {
        const string message = "Sorry, you don't have enough funds available for this car purchase";
        const string caption = "Notification";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(message, caption, buttons);
    }

    /// <summary>
    /// Congratulates the shopper on their purchase
    /// </summary>
    private static void Congratulations()
    {
        const string message = "Congratulations on your purchase";
        const string caption = "Notification";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(message, caption, buttons);
    }

    /// <summary>
    /// Adds a car to the shopper while removing a car from the car lot
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void purchaseCarButton_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedCar = (Car)carLotListBox.SelectedItem!;
            if (_shopperForm.Shopper.CanPurchase(selectedCar))
            {
                _carLot.PurchaseCar(selectedCar.Make, selectedCar.Model);
                carLotListBox.DataSource = null;
                carLotListBox.Items.Clear();
                carLotListBox.DataSource = _carLot.Inventory;
                carLotListBox.Refresh();
                _shopperForm.Shopper.PurchaseCar(selectedCar);
                shopperInfoTXB.Text = _shopperForm.Shopper.ToString();
                Congratulations();
            }
            else
            {
                NotEnoughMoney();
            }
        }
        catch (Exception exception)
        {
           ErrorMessage(exception.Message);
        }

    }

    /// <summary>
    /// Adds shopper to the main form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addShopperBTN_Click(object sender, EventArgs e)
    {
        try
        {
            _shopperForm = new ShopperForm();
            _shopperForm.ShowDialog();
            shopperInfoTXB.Text = _shopperForm.Shopper.ToString();
        }
        catch (Exception exception)
        {
            ErrorMessage(exception.Message);
        }
        
    }

    /// <summary>
    /// Allows for the Inventory Message Box to appear when pressing the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void inventoryBTN_Click(object sender, EventArgs e)
    {
        InventoryMessageBox();
    }

    
}
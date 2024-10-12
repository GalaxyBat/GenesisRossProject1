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
    private CarLot _carLot;
    public CarLotForm()
    {
        InitializeComponent();
        _carLot = new CarLot();
        LoadInventory();
    }

    private void LoadInventory()
    {
        foreach (Car car in _carLot.Inventory)
        {
            carLotListBox.Items.Add($"{car.Make} {car.Model} {car.Price:C} {car.Mpg:F1}");
        }
    }
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

    private void InventoryMessageBox()
    {
        var inventory = _carLot.ToString();
        const string caption = "The Inventory";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(inventory, caption, buttons);
    }

    private void ErrorMessage(string errorMessage)
    {
       const string caption = "Error Message";
       const MessageBoxButtons buttons = MessageBoxButtons.OK;
       MessageBox.Show(errorMessage, caption, buttons);
    }

    private void NotEnoughMoney()
    {
        const string message = "Sorry, you don't have enough funds available for this car purchase";
        const string caption = "The Inventory";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(message, caption, buttons);
    }

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

    private void inventoryBTN_Click(object sender, EventArgs e)
    {
        InventoryMessageBox();
    }

    
}
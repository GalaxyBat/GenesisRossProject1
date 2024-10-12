using GenesisRossProject1.Models;
using GenesisRossProject1.View;

namespace GenesisRossProject1;

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
        _carForm = new CarForm();
        _carForm.ShowDialog();
        _carLot.AddCar(_carForm.Car);
        carLotListBox.DataSource = null;
        carLotListBox.Items.Clear();
        carLotListBox.DataSource = _carLot.Inventory;
        carLotListBox.Refresh();
    }

    private void InventoryMessageBox()
    {
        string inventory = _carLot.ToString();
        string caption = "The Inventory";
        MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(inventory, caption, buttons);
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
                _shopperForm.Shopper.PurchaseCar(selectedCar);
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
    private void addShopperBTN_Click(object sender, EventArgs e)
    {
        _shopperForm = new ShopperForm();
        _shopperForm.ShowDialog();
        shopperInfoTXB.Text = _shopperForm.Shopper.ToString();
    }

    private void inventoryBTN_Click(object sender, EventArgs e)
    {
        InventoryMessageBox();
    }

    
}
using GenesisRossProject1.Models;

namespace GenesisRossProject1.View;

public partial class ShopperForm : Form
{
    public Shopper Shopper = null!;
    public ShopperForm()
    {
        InitializeComponent();
    }

    private void addShopperBTN_Click(object sender, EventArgs e)
    {
        try
        {
            if (IsValidUserEntry())
            {
                var name = nameTXB.Text;
                var moneyAvailable = Convert.ToDecimal(moneyAvailableTXB.Text);
                Shopper = new Shopper(name, moneyAvailable);
                DialogResult = DialogResult.OK;
            }
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
        finally
        {
            Close();
        }
        
    }

    private void cancelBTN_Click(object sender, EventArgs e)
    {
        Close();
    }

    private bool IsValidUserEntry()
    {
        var isMoneyDecimal = decimal.TryParse(moneyAvailableTXB.Text, out _);
        var isNameDecimal = decimal.TryParse(nameTXB.Text, out _);
        if (string.IsNullOrWhiteSpace(nameTXB.Text))
        {
            const string message = "You did not enter a name. Please enter a  name to continue use.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (string.IsNullOrWhiteSpace(moneyAvailableTXB.Text))
        {
            const string message = "You did not enter the money amount. Please enter the money amount.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (!isMoneyDecimal)
        {
            const string message = "You did not enter a monetary value. Please enter a monetary value.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (isNameDecimal)
        {
            const string message = "You did not enter a name. Please enter a name.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }
        return true;
    }
}
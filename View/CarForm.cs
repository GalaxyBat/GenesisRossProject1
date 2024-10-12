using GenesisRossProject1.Models;

namespace GenesisRossProject1.View;

public partial class CarForm : Form
{
    public Car Car = null!;
    public CarForm()
    {
        InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (IsValidUserEntry())
            {
                var make = makeTXB.Text;
                var model = modelTXB.Text;
                var mpg = Convert.ToDecimal(mpgTXB.Text);
                var price = Convert.ToDecimal(priceTXB.Text);
                Car = new Car(make, model, mpg, price);
                DialogResult = DialogResult.OK;
            }
        }
        catch (ArgumentException exception)
        {
            ErrorMessage(exception.Message);
        }
        finally
        {
            Close();
        }
        
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private bool IsValidUserEntry()
    {
        var isMakeDecimal = decimal.TryParse(makeTXB.Text, out _);
        var isModelDecimal = decimal.TryParse(modelTXB.Text, out _);
        var isMpgDecimal = decimal.TryParse(mpgTXB.Text, out _);
        var isPriceDecimal = decimal.TryParse(priceTXB.Text, out _);
        
        if (string.IsNullOrWhiteSpace(makeTXB.Text))
        {
            const string message = "You did not enter a make's name. Please enter a  name to continue use.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (string.IsNullOrWhiteSpace(modelTXB.Text))
        {
            const string message = "You did not enter a model's name. Please enter a name to continue to use.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (string.IsNullOrWhiteSpace(mpgTXB.Text))
        {
            const string message = "You did not enter the mileage. Please enter the mileage to continue to use.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (string.IsNullOrWhiteSpace(priceTXB.Text))
        {
            const string message = "You did not enter the money amount. Please enter the money amount to continue to use.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (!isPriceDecimal)
        {
            const string message = "You did not enter a monetary value. Please enter a monetary value.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (!isMpgDecimal)
        {
            const string message = "You did not enter a numeric value. Please enter a numeric value.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (isModelDecimal)
        {
            const string message = "You did not enter an alphabetic value. Please enter an alphabetic value.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }

        if (isMakeDecimal)
        {
            const string message = "You did not enter an alphabetic value. Please enter an alphabetic value.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }
        return true;
    }

    private void ErrorMessage(string errorMessage)
    {
        const string caption = "Error Message";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(errorMessage, caption, buttons);
    }
}
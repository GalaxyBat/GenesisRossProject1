using System.Diagnostics;

namespace GenesisRossProject1.View;

public partial class CarForm : Form
{
    public CarForm()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        
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
}
using GenesisRossProject1.Models;

namespace GenesisRossProject1.View;

/// <summary>
/// Partial Class CarForm
/// </summary>
public partial class CarForm : Form
{
    public Car Car = null!;

    /// <summary>
    /// The Constructor to create the Class CarForm
    /// </summary>
    public CarForm()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Adds car when clicking the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!IsValidUserEntry()) return;
            var make = makeTXB.Text;
            var model = modelTXB.Text;
            var mpg = Convert.ToDecimal(mpgTXB.Text);
            var price = Convert.ToDecimal(priceTXB.Text);
            Car = new Car(make, model, mpg, price);
            DialogResult = DialogResult.OK;
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

    /// <summary>
    /// Closes the CarForm Form when clicking the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    /// <summary>
    /// Checks to see if the user entry is valid or not
    /// </summary>
    /// <returns>true if it's valid, false if otherwise</returns>
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

        if (!isMakeDecimal) return true;
        {
            const string message = "You did not enter an alphabetic value. Please enter an alphabetic value.";
            const string caption = "Error Detected in Input";
            const MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
            return false;
        }
    }

    /// <summary>
    /// Pops up an error message box if an error occurs
    /// </summary>
    /// <param name="errorMessage"></param>
    private static void ErrorMessage(string errorMessage)
    {
        const string caption = "Error Message";
        const MessageBoxButtons buttons = MessageBoxButtons.OK;
        MessageBox.Show(errorMessage, caption, buttons);
    }
}
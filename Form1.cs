using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Bell_Vouncher_Calculator
{
    public partial class Form1 : Form
    {
        private readonly BellVoucher _voucher;
        private bool _suppressTextChanged;

        public Form1()
        {
            InitializeComponent();
            _voucher = new BellVoucher();

            // Restrict typing to digits and handle pasted text that may contain non-digits.
            nookMilesInput.KeyPress += NookMilesInput_KeyPress;
            nookMilesInput.TextChanged += NookMilesInput_TextChanged;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            var raw = nookMilesInput.Text.Trim();

            //check for empty input.
            if (string.IsNullOrEmpty(raw))
            {
                MessageBox.Show("Please enter the number of Nook Miles.", "Input required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // parse the input just in case.
            if (!int.TryParse(raw, NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out int miles))
            {
                MessageBox.Show("Please enter a valid numeric value for Nook Miles.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // check for negative input.
            if (miles < _voucher.MilesPerVoucher)
            {
                MessageBox.Show($"The minimum number of Nook Miles you can input is {_voucher.MilesPerVoucher}.", "Insufficient miles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int vouchersRedeemed = miles / _voucher.MilesPerVoucher;
            int totalBells = vouchersRedeemed * _voucher.BellsPerVoucher;

            // Display results.
            bellsResult.Text = $"You can redeem {vouchersRedeemed} Bell Voucher{(vouchersRedeemed == 1 ? "" : "s")} for a total of {totalBells:N0} bells.";
        }

        // Prevent typing non-digit characters
        private void NookMilesInput_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Strip any non-digits that may appear from paste operations. Comma should be allowed for thousands separator.
        private void NookMilesInput_TextChanged(object? sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            var original = nookMilesInput.Text;
            var digitsOnly = new string(original.Where(char.IsDigit).ToArray());

            _suppressTextChanged = true;

            // If the input is empty or contains no digits, clear the field and exit.
            if (string.IsNullOrEmpty(digitsOnly))
            {
                nookMilesInput.Clear();
                _suppressTextChanged = false;
                return;
            }

            // Try to parse the digits. If it fails (e.g., due to overflow), set it to the maximum int value.
            if (!long.TryParse(digitsOnly, out long value))
            {
                value = int.MaxValue; //maximum value for int.
            }

            // Cap the value at int.MaxValue to prevent overflow issues.
            if (value > int.MaxValue)
            {
                value = int.MaxValue;
            }

            var formatted = value.ToString("N0", CultureInfo.CurrentCulture);

            int originalSelection = nookMilesInput.SelectionStart;
            int digitsBeforeCaret = original.Take(Math.Max(0, originalSelection)).Count(char.IsDigit);

            int newSelection = formatted.Length - (digitsOnly.Length - digitsBeforeCaret);
            newSelection = Math.Max(0, Math.Min(formatted.Length, newSelection));

            nookMilesInput.Text = formatted;
            nookMilesInput.SelectionStart = newSelection;

            _suppressTextChanged = false;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear input and results

            nookMilesInput.Clear();
            bellsResult.Text = string.Empty;
            nookMilesInput.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

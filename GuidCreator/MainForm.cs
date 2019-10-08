using System;
using System.Windows.Forms;

namespace GuidCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void genGuidButton_Click(object sender, EventArgs e)
        {
            var newGuid = Guid.NewGuid().ToString();
            guidTextBox.Text = uppercaseGuidCheckBox.Checked ? newGuid.ToUpper() : newGuid.ToLower();
        }

        private void copyGuidButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(guidTextBox.Text)) Clipboard.SetText(guidTextBox.Text);
        }

        private void uppercaseGuidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uppercaseGuidCheckBox.Checked)
                guidTextBox.Text = !string.IsNullOrWhiteSpace(guidTextBox.Text) ? guidTextBox.Text.ToUpper() : "";
            else
                guidTextBox.Text = !string.IsNullOrWhiteSpace(guidTextBox.Text) ? guidTextBox.Text.ToLower() : "";
        }
    }
}
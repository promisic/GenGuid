/*
 *  Simple GUID generation tool
 *  Copyright (C) 2019-2020  Dusan Misic <promisic@gmail.com>
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
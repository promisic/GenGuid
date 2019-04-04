namespace GuidCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.guidGroupBox = new System.Windows.Forms.GroupBox();
            this.guidTextBox = new System.Windows.Forms.TextBox();
            this.genGuidButton = new System.Windows.Forms.Button();
            this.copyGuidButton = new System.Windows.Forms.Button();
            this.uppercaseGuidCheckBox = new System.Windows.Forms.CheckBox();
            this.guidGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // guidGroupBox
            // 
            this.guidGroupBox.Controls.Add(this.uppercaseGuidCheckBox);
            this.guidGroupBox.Controls.Add(this.guidTextBox);
            this.guidGroupBox.Location = new System.Drawing.Point(12, 12);
            this.guidGroupBox.Name = "guidGroupBox";
            this.guidGroupBox.Size = new System.Drawing.Size(315, 71);
            this.guidGroupBox.TabIndex = 0;
            this.guidGroupBox.TabStop = false;
            this.guidGroupBox.Text = "Generated GUID:";
            // 
            // guidTextBox
            // 
            this.guidTextBox.Location = new System.Drawing.Point(6, 24);
            this.guidTextBox.Name = "guidTextBox";
            this.guidTextBox.ReadOnly = true;
            this.guidTextBox.Size = new System.Drawing.Size(303, 20);
            this.guidTextBox.TabIndex = 0;
            this.guidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // genGuidButton
            // 
            this.genGuidButton.Location = new System.Drawing.Point(224, 89);
            this.genGuidButton.Name = "genGuidButton";
            this.genGuidButton.Size = new System.Drawing.Size(103, 35);
            this.genGuidButton.TabIndex = 1;
            this.genGuidButton.Text = "Generate GUID";
            this.genGuidButton.UseVisualStyleBackColor = true;
            this.genGuidButton.Click += new System.EventHandler(this.genGuidButton_Click);
            // 
            // copyGuidButton
            // 
            this.copyGuidButton.Location = new System.Drawing.Point(12, 89);
            this.copyGuidButton.Name = "copyGuidButton";
            this.copyGuidButton.Size = new System.Drawing.Size(107, 35);
            this.copyGuidButton.TabIndex = 2;
            this.copyGuidButton.Text = "Copy to clipboard";
            this.copyGuidButton.UseVisualStyleBackColor = true;
            this.copyGuidButton.Click += new System.EventHandler(this.copyGuidButton_Click);
            // 
            // uppercaseGuidCheckBox
            // 
            this.uppercaseGuidCheckBox.AutoSize = true;
            this.uppercaseGuidCheckBox.Location = new System.Drawing.Point(6, 48);
            this.uppercaseGuidCheckBox.Name = "uppercaseGuidCheckBox";
            this.uppercaseGuidCheckBox.Size = new System.Drawing.Size(108, 17);
            this.uppercaseGuidCheckBox.TabIndex = 1;
            this.uppercaseGuidCheckBox.Text = "Uppercase GUID";
            this.uppercaseGuidCheckBox.UseVisualStyleBackColor = true;
            this.uppercaseGuidCheckBox.CheckedChanged += new System.EventHandler(this.uppercaseGuidCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 136);
            this.Controls.Add(this.copyGuidButton);
            this.Controls.Add(this.genGuidButton);
            this.Controls.Add(this.guidGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID Generation tool";
            this.guidGroupBox.ResumeLayout(false);
            this.guidGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox guidGroupBox;
        private System.Windows.Forms.Button genGuidButton;
        private System.Windows.Forms.Button copyGuidButton;
        private System.Windows.Forms.TextBox guidTextBox;
        private System.Windows.Forms.CheckBox uppercaseGuidCheckBox;
    }
}


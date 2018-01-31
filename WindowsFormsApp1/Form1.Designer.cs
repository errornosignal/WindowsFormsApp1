namespace WindowsFormsApp1
{
    partial class Form1
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
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.ShippingGroupBox = new System.Windows.Forms.GroupBox();
            this.StandardShippingRadioButton = new System.Windows.Forms.RadioButton();
            this.ExpeditedShippingRadioButton = new System.Windows.Forms.RadioButton();
            this.InternationalShippingRadioButton = new System.Windows.Forms.RadioButton();
            this.ShippingChargesLabel = new System.Windows.Forms.Label();
            this.ShippingChargesTextBox = new System.Windows.Forms.TextBox();
            this.CalculateShippingChargesButton = new System.Windows.Forms.Button();
            this.ShippingWeightTextBox = new System.Windows.Forms.TextBox();
            this.ShippingWeightLabel = new System.Windows.Forms.Label();
            this.ResetFormButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ShippingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(47, 9);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 0;
            this.LengthLabel.Text = "Length";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(52, 31);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Width";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.AcceptsReturn = true;
            this.LengthTextBox.Location = new System.Drawing.Point(93, 6);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 0;
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.AcceptsReturn = true;
            this.WidthTextBox.Location = new System.Drawing.Point(93, 28);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 1;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 57);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Enabled = false;
            this.ResultsTextBox.Location = new System.Drawing.Point(93, 60);
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultsTextBox.TabIndex = 5;
            // 
            // ShippingGroupBox
            // 
            this.ShippingGroupBox.Controls.Add(this.InternationalShippingRadioButton);
            this.ShippingGroupBox.Controls.Add(this.ExpeditedShippingRadioButton);
            this.ShippingGroupBox.Controls.Add(this.StandardShippingRadioButton);
            this.ShippingGroupBox.Location = new System.Drawing.Point(12, 104);
            this.ShippingGroupBox.Name = "ShippingGroupBox";
            this.ShippingGroupBox.Size = new System.Drawing.Size(200, 107);
            this.ShippingGroupBox.TabIndex = 3;
            this.ShippingGroupBox.TabStop = false;
            this.ShippingGroupBox.Text = "Shipping Options";
            // 
            // StandardShippingRadioButton
            // 
            this.StandardShippingRadioButton.AutoSize = true;
            this.StandardShippingRadioButton.Checked = true;
            this.StandardShippingRadioButton.Location = new System.Drawing.Point(6, 19);
            this.StandardShippingRadioButton.Name = "StandardShippingRadioButton";
            this.StandardShippingRadioButton.Size = new System.Drawing.Size(112, 17);
            this.StandardShippingRadioButton.TabIndex = 4;
            this.StandardShippingRadioButton.TabStop = true;
            this.StandardShippingRadioButton.Text = "Standard Shipping";
            this.StandardShippingRadioButton.UseVisualStyleBackColor = true;
            // 
            // ExpeditedShippingRadioButton
            // 
            this.ExpeditedShippingRadioButton.AutoSize = true;
            this.ExpeditedShippingRadioButton.Location = new System.Drawing.Point(6, 42);
            this.ExpeditedShippingRadioButton.Name = "ExpeditedShippingRadioButton";
            this.ExpeditedShippingRadioButton.Size = new System.Drawing.Size(116, 17);
            this.ExpeditedShippingRadioButton.TabIndex = 5;
            this.ExpeditedShippingRadioButton.TabStop = true;
            this.ExpeditedShippingRadioButton.Text = "Expedited Shipping";
            this.ExpeditedShippingRadioButton.UseVisualStyleBackColor = true;
            // 
            // InternationalShippingRadioButton
            // 
            this.InternationalShippingRadioButton.AutoSize = true;
            this.InternationalShippingRadioButton.Location = new System.Drawing.Point(6, 65);
            this.InternationalShippingRadioButton.Name = "InternationalShippingRadioButton";
            this.InternationalShippingRadioButton.Size = new System.Drawing.Size(127, 17);
            this.InternationalShippingRadioButton.TabIndex = 6;
            this.InternationalShippingRadioButton.TabStop = true;
            this.InternationalShippingRadioButton.Text = "International Shipping";
            this.InternationalShippingRadioButton.UseVisualStyleBackColor = true;
            // 
            // ShippingChargesLabel
            // 
            this.ShippingChargesLabel.AutoSize = true;
            this.ShippingChargesLabel.Location = new System.Drawing.Point(15, 292);
            this.ShippingChargesLabel.Name = "ShippingChargesLabel";
            this.ShippingChargesLabel.Size = new System.Drawing.Size(90, 13);
            this.ShippingChargesLabel.TabIndex = 7;
            this.ShippingChargesLabel.Text = "Shipping Charges";
            // 
            // ShippingChargesTextBox
            // 
            this.ShippingChargesTextBox.Enabled = false;
            this.ShippingChargesTextBox.Location = new System.Drawing.Point(111, 285);
            this.ShippingChargesTextBox.Name = "ShippingChargesTextBox";
            this.ShippingChargesTextBox.ReadOnly = true;
            this.ShippingChargesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShippingChargesTextBox.TabIndex = 8;
            this.ShippingChargesTextBox.TabStop = false;
            // 
            // CalculateShippingChargesButton
            // 
            this.CalculateShippingChargesButton.Location = new System.Drawing.Point(18, 323);
            this.CalculateShippingChargesButton.Name = "CalculateShippingChargesButton";
            this.CalculateShippingChargesButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateShippingChargesButton.TabIndex = 8;
            this.CalculateShippingChargesButton.Text = "Calculate";
            this.CalculateShippingChargesButton.UseVisualStyleBackColor = true;
            this.CalculateShippingChargesButton.Click += new System.EventHandler(this.CalculateShippingChargesButton_Click);
            // 
            // ShippingWeightTextBox
            // 
            this.ShippingWeightTextBox.AcceptsReturn = true;
            this.ShippingWeightTextBox.Location = new System.Drawing.Point(111, 236);
            this.ShippingWeightTextBox.Name = "ShippingWeightTextBox";
            this.ShippingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.ShippingWeightTextBox.TabIndex = 7;
            // 
            // ShippingWeightLabel
            // 
            this.ShippingWeightLabel.AutoSize = true;
            this.ShippingWeightLabel.Location = new System.Drawing.Point(13, 239);
            this.ShippingWeightLabel.Name = "ShippingWeightLabel";
            this.ShippingWeightLabel.Size = new System.Drawing.Size(85, 13);
            this.ShippingWeightLabel.TabIndex = 11;
            this.ShippingWeightLabel.Text = "Shipping Weight";
            // 
            // ResetFormButton
            // 
            this.ResetFormButton.Location = new System.Drawing.Point(18, 356);
            this.ResetFormButton.Name = "ResetFormButton";
            this.ResetFormButton.Size = new System.Drawing.Size(75, 23);
            this.ResetFormButton.TabIndex = 12;
            this.ResetFormButton.Text = "Reset Form";
            this.ResetFormButton.UseVisualStyleBackColor = true;
            this.ResetFormButton.Click += new System.EventHandler(this.ResetFormButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(189, 356);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 391);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetFormButton);
            this.Controls.Add(this.ShippingWeightLabel);
            this.Controls.Add(this.ShippingWeightTextBox);
            this.Controls.Add(this.CalculateShippingChargesButton);
            this.Controls.Add(this.ShippingChargesTextBox);
            this.Controls.Add(this.ShippingChargesLabel);
            this.Controls.Add(this.ShippingGroupBox);
            this.Controls.Add(this.ResultsTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.LengthLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ShippingGroupBox.ResumeLayout(false);
            this.ShippingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.GroupBox ShippingGroupBox;
        private System.Windows.Forms.RadioButton InternationalShippingRadioButton;
        private System.Windows.Forms.RadioButton ExpeditedShippingRadioButton;
        private System.Windows.Forms.RadioButton StandardShippingRadioButton;
        private System.Windows.Forms.Label ShippingChargesLabel;
        private System.Windows.Forms.TextBox ShippingChargesTextBox;
        private System.Windows.Forms.Button CalculateShippingChargesButton;
        private System.Windows.Forms.TextBox ShippingWeightTextBox;
        private System.Windows.Forms.Label ShippingWeightLabel;
        private System.Windows.Forms.Button ResetFormButton;
        private System.Windows.Forms.Button ExitButton;
    }
}


namespace Assignment_6
{
    partial class BMICalculator
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
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIText = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightEntry = new System.Windows.Forms.TextBox();
            this.HeightEntry = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMIDisplay = new System.Windows.Forms.TextBox();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImperialButton
            // 
            this.ImperialButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(105, 382);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(103, 39);
            this.ImperialButton.TabIndex = 0;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(135, 202);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(155, 37);
            this.CalculateBMIButton.TabIndex = 9;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // BMIText
            // 
            this.BMIText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BMIText.BackColor = System.Drawing.Color.White;
            this.BMIText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIText.Enabled = false;
            this.BMIText.ForeColor = System.Drawing.Color.Black;
            this.BMIText.Location = new System.Drawing.Point(19, 297);
            this.BMIText.Multiline = true;
            this.BMIText.Name = "BMIText";
            this.BMIText.Size = new System.Drawing.Size(252, 77);
            this.BMIText.TabIndex = 10;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Location = new System.Drawing.Point(12, 9);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(289, 41);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height(metres)";
            // 
            // WeightLabel
            // 
            this.WeightLabel.Location = new System.Drawing.Point(12, 104);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(259, 41);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight(kg)";
            // 
            // WeightEntry
            // 
            this.WeightEntry.Location = new System.Drawing.Point(19, 148);
            this.WeightEntry.Name = "WeightEntry";
            this.WeightEntry.Size = new System.Drawing.Size(252, 48);
            this.WeightEntry.TabIndex = 5;
            // 
            // HeightEntry
            // 
            this.HeightEntry.Location = new System.Drawing.Point(19, 53);
            this.HeightEntry.Name = "HeightEntry";
            this.HeightEntry.Size = new System.Drawing.Size(252, 48);
            this.HeightEntry.TabIndex = 6;
            // 
            // BMILabel
            // 
            this.BMILabel.Location = new System.Drawing.Point(12, 199);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(124, 41);
            this.BMILabel.TabIndex = 7;
            this.BMILabel.Text = "My BMI";
            // 
            // BMIDisplay
            // 
            this.BMIDisplay.BackColor = System.Drawing.Color.White;
            this.BMIDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMIDisplay.Enabled = false;
            this.BMIDisplay.ForeColor = System.Drawing.Color.Black;
            this.BMIDisplay.Location = new System.Drawing.Point(19, 243);
            this.BMIDisplay.Name = "BMIDisplay";
            this.BMIDisplay.Size = new System.Drawing.Size(252, 48);
            this.BMIDisplay.TabIndex = 8;
            // 
            // MetricButton
            // 
            this.MetricButton.Checked = true;
            this.MetricButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.Location = new System.Drawing.Point(3, 382);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(86, 39);
            this.MetricButton.TabIndex = 11;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = true;
            this.MetricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(210, 383);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 38);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.MetricButton);
            this.Controls.Add(this.BMIText);
            this.Controls.Add(this.BMIDisplay);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.HeightEntry);
            this.Controls.Add(this.WeightEntry);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Mass Index Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightEntry;
        private System.Windows.Forms.TextBox HeightEntry;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox BMIDisplay;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIText;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Button ResetButton;
    }
}


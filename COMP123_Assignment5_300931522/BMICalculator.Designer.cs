namespace COMP123_Assignment5_300931522
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
            this.UITableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.MetricButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.InchOrMeterLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.PoundOrFeetLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIScaleTextBox = new System.Windows.Forms.TextBox();
            this.UITableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UITableLayoutPanel
            // 
            this.UITableLayoutPanel.BackColor = System.Drawing.Color.Black;
            this.UITableLayoutPanel.ColumnCount = 2;
            this.UITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.UITableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UITableLayoutPanel.Controls.Add(this.ImperialButton, 0, 0);
            this.UITableLayoutPanel.Controls.Add(this.MetricButton, 1, 0);
            this.UITableLayoutPanel.Controls.Add(this.InchOrMeterLabel, 0, 2);
            this.UITableLayoutPanel.Controls.Add(this.HeightTextBox, 0, 3);
            this.UITableLayoutPanel.Controls.Add(this.WeightTextBox, 0, 6);
            this.UITableLayoutPanel.Controls.Add(this.WeightLabel, 0, 4);
            this.UITableLayoutPanel.Controls.Add(this.PoundOrFeetLabel, 0, 5);
            this.UITableLayoutPanel.Controls.Add(this.BMITextBox, 0, 8);
            this.UITableLayoutPanel.Controls.Add(this.ResetButton, 1, 7);
            this.UITableLayoutPanel.Controls.Add(this.BMIScaleTextBox, 0, 9);
            this.UITableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.UITableLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 7);
            this.UITableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.UITableLayoutPanel.Name = "UITableLayoutPanel";
            this.UITableLayoutPanel.RowCount = 11;
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.601873F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.07026F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UITableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.UITableLayoutPanel.Size = new System.Drawing.Size(299, 427);
            this.UITableLayoutPanel.TabIndex = 0;
            // 
            // ImperialButton
            // 
            this.ImperialButton.BackColor = System.Drawing.Color.Transparent;
            this.ImperialButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.ForeColor = System.Drawing.Color.White;
            this.ImperialButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(141, 34);
            this.ImperialButton.TabIndex = 0;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialButton.UseVisualStyleBackColor = false;
            // 
            // MetricButton
            // 
            this.MetricButton.BackColor = System.Drawing.Color.Transparent;
            this.MetricButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricButton.ForeColor = System.Drawing.Color.White;
            this.MetricButton.Location = new System.Drawing.Point(150, 3);
            this.MetricButton.Name = "MetricButton";
            this.MetricButton.Size = new System.Drawing.Size(146, 34);
            this.MetricButton.TabIndex = 1;
            this.MetricButton.TabStop = true;
            this.MetricButton.Text = "Metric";
            this.MetricButton.UseVisualStyleBackColor = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.UITableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(3, 40);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(293, 40);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // InchOrMeterLabel
            // 
            this.InchOrMeterLabel.BackColor = System.Drawing.Color.Transparent;
            this.UITableLayoutPanel.SetColumnSpan(this.InchOrMeterLabel, 2);
            this.InchOrMeterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InchOrMeterLabel.ForeColor = System.Drawing.Color.White;
            this.InchOrMeterLabel.Location = new System.Drawing.Point(3, 80);
            this.InchOrMeterLabel.Name = "InchOrMeterLabel";
            this.InchOrMeterLabel.Size = new System.Drawing.Size(293, 39);
            this.InchOrMeterLabel.TabIndex = 3;
            this.InchOrMeterLabel.Text = "Inches";
            this.InchOrMeterLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // HeightTextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(3, 123);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(293, 38);
            this.HeightTextBox.TabIndex = 4;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightTextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(3, 243);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(293, 38);
            this.WeightTextBox.TabIndex = 5;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // WeightLabel
            // 
            this.WeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.UITableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.ForeColor = System.Drawing.Color.White;
            this.WeightLabel.Location = new System.Drawing.Point(3, 159);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(293, 41);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "My Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PoundOrFeetLabel
            // 
            this.PoundOrFeetLabel.BackColor = System.Drawing.Color.Transparent;
            this.UITableLayoutPanel.SetColumnSpan(this.PoundOrFeetLabel, 2);
            this.PoundOrFeetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PoundOrFeetLabel.ForeColor = System.Drawing.Color.White;
            this.PoundOrFeetLabel.Location = new System.Drawing.Point(3, 200);
            this.PoundOrFeetLabel.Name = "PoundOrFeetLabel";
            this.PoundOrFeetLabel.Size = new System.Drawing.Size(293, 39);
            this.PoundOrFeetLabel.TabIndex = 7;
            this.PoundOrFeetLabel.Text = "Pounds";
            this.PoundOrFeetLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BMITextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.BMITextBox, 2);
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITextBox.Location = new System.Drawing.Point(3, 323);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(293, 38);
            this.BMITextBox.TabIndex = 8;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.BackColor = System.Drawing.Color.SkyBlue;
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 283);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(141, 34);
            this.CalculateBMIButton.TabIndex = 9;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(150, 283);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 34);
            this.ResetButton.TabIndex = 10;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            // 
            // BMIScaleTextBox
            // 
            this.UITableLayoutPanel.SetColumnSpan(this.BMIScaleTextBox, 2);
            this.BMIScaleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIScaleTextBox.Location = new System.Drawing.Point(3, 363);
            this.BMIScaleTextBox.Multiline = true;
            this.BMIScaleTextBox.Name = "BMIScaleTextBox";
            this.UITableLayoutPanel.SetRowSpan(this.BMIScaleTextBox, 2);
            this.BMIScaleTextBox.Size = new System.Drawing.Size(293, 61);
            this.BMIScaleTextBox.TabIndex = 11;
            this.BMIScaleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.UITableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMICalculator";
            this.UITableLayoutPanel.ResumeLayout(false);
            this.UITableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel UITableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.RadioButton MetricButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label InchOrMeterLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label PoundOrFeetLabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox BMIScaleTextBox;
    }
}


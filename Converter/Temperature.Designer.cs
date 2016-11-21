namespace Converter
{
    partial class Temperature
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.cmbTempUnit = new System.Windows.Forms.ComboBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(148, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(148, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "F°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(148, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "C°";
            // 
            // txtKelvin
            // 
            this.txtKelvin.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtKelvin.ForeColor = System.Drawing.Color.Navy;
            this.txtKelvin.Location = new System.Drawing.Point(22, 196);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.ReadOnly = true;
            this.txtKelvin.Size = new System.Drawing.Size(100, 25);
            this.txtKelvin.TabIndex = 43;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFahrenheit.ForeColor = System.Drawing.Color.Navy;
            this.txtFahrenheit.Location = new System.Drawing.Point(22, 148);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.ReadOnly = true;
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 25);
            this.txtFahrenheit.TabIndex = 42;
            // 
            // txtCelsius
            // 
            this.txtCelsius.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCelsius.ForeColor = System.Drawing.Color.Navy;
            this.txtCelsius.Location = new System.Drawing.Point(22, 105);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.ReadOnly = true;
            this.txtCelsius.Size = new System.Drawing.Size(100, 25);
            this.txtCelsius.TabIndex = 41;
            // 
            // cmbTempUnit
            // 
            this.cmbTempUnit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTempUnit.FormattingEnabled = true;
            this.cmbTempUnit.Items.AddRange(new object[] {
            "Celsius (C°)",
            "Fahrenheit  (F°)",
            "Kelvin  (K)"});
            this.cmbTempUnit.Location = new System.Drawing.Point(153, 60);
            this.cmbTempUnit.Name = "cmbTempUnit";
            this.cmbTempUnit.Size = new System.Drawing.Size(147, 26);
            this.cmbTempUnit.TabIndex = 40;
            this.cmbTempUnit.SelectedIndexChanged += new System.EventHandler(this.cmbTempUnit_SelectedIndexChanged);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTemperature.Location = new System.Drawing.Point(22, 60);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 23);
            this.txtTemperature.TabIndex = 39;
            this.txtTemperature.Text = "0";
            this.txtTemperature.TextChanged += new System.EventHandler(this.txtTemperature_TextChanged);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemperature.ForeColor = System.Drawing.Color.Maroon;
            this.lblTemperature.Location = new System.Drawing.Point(19, 14);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(115, 20);
            this.lblTemperature.TabIndex = 38;
            this.lblTemperature.Text = "Temperature";
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.cmbTempUnit);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblTemperature);
            this.Name = "Temperature";
            this.Size = new System.Drawing.Size(410, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.ComboBox cmbTempUnit;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblTemperature;
    }
}

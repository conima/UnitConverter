namespace Converter
{
    partial class Pressure
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtPascal = new System.Windows.Forms.TextBox();
            this.txtPsi = new System.Windows.Forms.TextBox();
            this.txtAtm = new System.Windows.Forms.TextBox();
            this.cmbPressureUnit = new System.Windows.Forms.ComboBox();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(153, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "bar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(153, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Pa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(153, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "psi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(153, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 49;
            this.label2.Text = "atm";
            // 
            // txtBar
            // 
            this.txtBar.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBar.ForeColor = System.Drawing.Color.Navy;
            this.txtBar.Location = new System.Drawing.Point(22, 240);
            this.txtBar.Name = "txtBar";
            this.txtBar.ReadOnly = true;
            this.txtBar.Size = new System.Drawing.Size(100, 25);
            this.txtBar.TabIndex = 44;
            // 
            // txtPascal
            // 
            this.txtPascal.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPascal.ForeColor = System.Drawing.Color.Navy;
            this.txtPascal.Location = new System.Drawing.Point(22, 196);
            this.txtPascal.Name = "txtPascal";
            this.txtPascal.ReadOnly = true;
            this.txtPascal.Size = new System.Drawing.Size(100, 25);
            this.txtPascal.TabIndex = 43;
            // 
            // txtPsi
            // 
            this.txtPsi.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPsi.ForeColor = System.Drawing.Color.Navy;
            this.txtPsi.Location = new System.Drawing.Point(22, 148);
            this.txtPsi.Name = "txtPsi";
            this.txtPsi.ReadOnly = true;
            this.txtPsi.Size = new System.Drawing.Size(100, 25);
            this.txtPsi.TabIndex = 42;
            // 
            // txtAtm
            // 
            this.txtAtm.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAtm.ForeColor = System.Drawing.Color.Navy;
            this.txtAtm.Location = new System.Drawing.Point(22, 105);
            this.txtAtm.Name = "txtAtm";
            this.txtAtm.ReadOnly = true;
            this.txtAtm.Size = new System.Drawing.Size(100, 25);
            this.txtAtm.TabIndex = 41;
            // 
            // cmbPressureUnit
            // 
            this.cmbPressureUnit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbPressureUnit.FormattingEnabled = true;
            this.cmbPressureUnit.Items.AddRange(new object[] {
            "atmosphere (atm)",
            "psi",
            "pascal  (Pa)",
            "bar"});
            this.cmbPressureUnit.Location = new System.Drawing.Point(153, 60);
            this.cmbPressureUnit.Name = "cmbPressureUnit";
            this.cmbPressureUnit.Size = new System.Drawing.Size(147, 26);
            this.cmbPressureUnit.TabIndex = 40;
            this.cmbPressureUnit.SelectedIndexChanged += new System.EventHandler(this.cmbPressureUnit_SelectedIndexChanged);
            // 
            // txtPressure
            // 
            this.txtPressure.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPressure.Location = new System.Drawing.Point(22, 60);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(100, 23);
            this.txtPressure.TabIndex = 39;
            this.txtPressure.Text = "1";
            this.txtPressure.TextChanged += new System.EventHandler(this.txtPressure_TextChanged);
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPressure.ForeColor = System.Drawing.Color.Maroon;
            this.lblPressure.Location = new System.Drawing.Point(19, 14);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(85, 20);
            this.lblPressure.TabIndex = 38;
            this.lblPressure.Text = "Pressure";
            // 
            // Pressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBar);
            this.Controls.Add(this.txtPascal);
            this.Controls.Add(this.txtPsi);
            this.Controls.Add(this.txtAtm);
            this.Controls.Add(this.cmbPressureUnit);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.lblPressure);
            this.Name = "Pressure";
            this.Size = new System.Drawing.Size(410, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtPascal;
        private System.Windows.Forms.TextBox txtPsi;
        private System.Windows.Forms.TextBox txtAtm;
        private System.Windows.Forms.ComboBox cmbPressureUnit;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label lblPressure;
    }
}

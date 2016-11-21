namespace Converter
{
    partial class Area
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
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.cmbAreaUnit = new System.Windows.Forms.ComboBox();
            this.txtSqM = new System.Windows.Forms.TextBox();
            this.txtSqMm = new System.Windows.Forms.TextBox();
            this.txtSqCm = new System.Windows.Forms.TextBox();
            this.txtSqKm = new System.Windows.Forms.TextBox();
            this.txtSqIn = new System.Windows.Forms.TextBox();
            this.txtSqFt = new System.Windows.Forms.TextBox();
            this.txtSqYd = new System.Windows.Forms.TextBox();
            this.txtSqAcre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArea.ForeColor = System.Drawing.Color.Maroon;
            this.lblArea.Location = new System.Drawing.Point(19, 14);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(48, 20);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area";
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtArea.Location = new System.Drawing.Point(22, 60);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 23);
            this.txtArea.TabIndex = 1;
            this.txtArea.Text = "1";
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // cmbAreaUnit
            // 
            this.cmbAreaUnit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAreaUnit.FormattingEnabled = true;
            this.cmbAreaUnit.Items.AddRange(new object[] {
            "meter²  (m²)",
            "millimeter²  (mm²)",
            "centimeter²  (cm²)",
            "kilometer²  (km²)",
            "inch²  (in²)",
            "foot²  (ft²)",
            "yard²  (yd²)",
            "acre"});
            this.cmbAreaUnit.Location = new System.Drawing.Point(153, 60);
            this.cmbAreaUnit.Name = "cmbAreaUnit";
            this.cmbAreaUnit.Size = new System.Drawing.Size(147, 26);
            this.cmbAreaUnit.TabIndex = 2;
            this.cmbAreaUnit.SelectedIndexChanged += new System.EventHandler(this.cmbAreaUnit_SelectedIndexChanged);
            // 
            // txtSqM
            // 
            this.txtSqM.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqM.ForeColor = System.Drawing.Color.Navy;
            this.txtSqM.Location = new System.Drawing.Point(22, 105);
            this.txtSqM.Name = "txtSqM";
            this.txtSqM.ReadOnly = true;
            this.txtSqM.Size = new System.Drawing.Size(100, 23);
            this.txtSqM.TabIndex = 3;
            // 
            // txtSqMm
            // 
            this.txtSqMm.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqMm.ForeColor = System.Drawing.Color.Navy;
            this.txtSqMm.Location = new System.Drawing.Point(22, 148);
            this.txtSqMm.Name = "txtSqMm";
            this.txtSqMm.ReadOnly = true;
            this.txtSqMm.Size = new System.Drawing.Size(100, 23);
            this.txtSqMm.TabIndex = 4;
            // 
            // txtSqCm
            // 
            this.txtSqCm.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqCm.ForeColor = System.Drawing.Color.Navy;
            this.txtSqCm.Location = new System.Drawing.Point(22, 196);
            this.txtSqCm.Name = "txtSqCm";
            this.txtSqCm.ReadOnly = true;
            this.txtSqCm.Size = new System.Drawing.Size(100, 23);
            this.txtSqCm.TabIndex = 5;
            // 
            // txtSqKm
            // 
            this.txtSqKm.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqKm.ForeColor = System.Drawing.Color.Navy;
            this.txtSqKm.Location = new System.Drawing.Point(22, 240);
            this.txtSqKm.Name = "txtSqKm";
            this.txtSqKm.ReadOnly = true;
            this.txtSqKm.Size = new System.Drawing.Size(100, 23);
            this.txtSqKm.TabIndex = 6;
            // 
            // txtSqIn
            // 
            this.txtSqIn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqIn.ForeColor = System.Drawing.Color.Navy;
            this.txtSqIn.Location = new System.Drawing.Point(22, 285);
            this.txtSqIn.Name = "txtSqIn";
            this.txtSqIn.ReadOnly = true;
            this.txtSqIn.Size = new System.Drawing.Size(100, 23);
            this.txtSqIn.TabIndex = 7;
            // 
            // txtSqFt
            // 
            this.txtSqFt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqFt.ForeColor = System.Drawing.Color.Navy;
            this.txtSqFt.Location = new System.Drawing.Point(22, 335);
            this.txtSqFt.Name = "txtSqFt";
            this.txtSqFt.ReadOnly = true;
            this.txtSqFt.Size = new System.Drawing.Size(100, 23);
            this.txtSqFt.TabIndex = 8;
            // 
            // txtSqYd
            // 
            this.txtSqYd.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqYd.ForeColor = System.Drawing.Color.Navy;
            this.txtSqYd.Location = new System.Drawing.Point(22, 385);
            this.txtSqYd.Name = "txtSqYd";
            this.txtSqYd.ReadOnly = true;
            this.txtSqYd.Size = new System.Drawing.Size(100, 23);
            this.txtSqYd.TabIndex = 9;
            // 
            // txtSqAcre
            // 
            this.txtSqAcre.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSqAcre.ForeColor = System.Drawing.Color.Navy;
            this.txtSqAcre.Location = new System.Drawing.Point(22, 437);
            this.txtSqAcre.Name = "txtSqAcre";
            this.txtSqAcre.ReadOnly = true;
            this.txtSqAcre.Size = new System.Drawing.Size(100, 23);
            this.txtSqAcre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(153, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "m²";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(153, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "mm²";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(153, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "cm²";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(153, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "km²";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(153, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "in²";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(153, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "ft²";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(153, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "yd²";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(153, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "acre";
            // 
            // Area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSqAcre);
            this.Controls.Add(this.txtSqYd);
            this.Controls.Add(this.txtSqFt);
            this.Controls.Add(this.txtSqIn);
            this.Controls.Add(this.txtSqKm);
            this.Controls.Add(this.txtSqCm);
            this.Controls.Add(this.txtSqMm);
            this.Controls.Add(this.txtSqM);
            this.Controls.Add(this.cmbAreaUnit);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Name = "Area";
            this.Size = new System.Drawing.Size(410, 496);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.ComboBox cmbAreaUnit;
        private System.Windows.Forms.TextBox txtSqM;
        private System.Windows.Forms.TextBox txtSqMm;
        private System.Windows.Forms.TextBox txtSqCm;
        private System.Windows.Forms.TextBox txtSqKm;
        private System.Windows.Forms.TextBox txtSqIn;
        private System.Windows.Forms.TextBox txtSqFt;
        private System.Windows.Forms.TextBox txtSqYd;
        private System.Windows.Forms.TextBox txtSqAcre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

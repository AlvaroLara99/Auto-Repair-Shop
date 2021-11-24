namespace Auto_Repair_Shop
{
    partial class frmMain
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
            this.gbxOil = new System.Windows.Forms.GroupBox();
            this.gbxMisc = new System.Windows.Forms.GroupBox();
            this.cbxOil = new System.Windows.Forms.CheckBox();
            this.cbxLube = new System.Windows.Forms.CheckBox();
            this.cbxTire = new System.Windows.Forms.CheckBox();
            this.cbxInspection = new System.Windows.Forms.CheckBox();
            this.cbxMuffler = new System.Windows.Forms.CheckBox();
            this.cbxRadiator = new System.Windows.Forms.CheckBox();
            this.cbxTransmission = new System.Windows.Forms.CheckBox();
            this.gbxFlush = new System.Windows.Forms.GroupBox();
            this.gbxTotal = new System.Windows.Forms.GroupBox();
            this.gbxParts = new System.Windows.Forms.GroupBox();
            this.bntCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSumServices = new System.Windows.Forms.Label();
            this.lblSumParts = new System.Windows.Forms.Label();
            this.lblSumTax = new System.Windows.Forms.Label();
            this.lblSumTotalCharge = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.txtTotalServices = new System.Windows.Forms.TextBox();
            this.txtTotalParts = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.gbxOil.SuspendLayout();
            this.gbxMisc.SuspendLayout();
            this.gbxFlush.SuspendLayout();
            this.gbxTotal.SuspendLayout();
            this.gbxParts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOil
            // 
            this.gbxOil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.gbxOil.Controls.Add(this.cbxLube);
            this.gbxOil.Controls.Add(this.cbxOil);
            this.gbxOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxOil.Location = new System.Drawing.Point(19, 24);
            this.gbxOil.Name = "gbxOil";
            this.gbxOil.Size = new System.Drawing.Size(300, 125);
            this.gbxOil.TabIndex = 0;
            this.gbxOil.TabStop = false;
            this.gbxOil.Text = "Oil and Lube";
            // 
            // gbxMisc
            // 
            this.gbxMisc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.gbxMisc.Controls.Add(this.cbxMuffler);
            this.gbxMisc.Controls.Add(this.cbxTire);
            this.gbxMisc.Controls.Add(this.cbxInspection);
            this.gbxMisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMisc.Location = new System.Drawing.Point(19, 192);
            this.gbxMisc.Name = "gbxMisc";
            this.gbxMisc.Size = new System.Drawing.Size(300, 125);
            this.gbxMisc.TabIndex = 2;
            this.gbxMisc.TabStop = false;
            this.gbxMisc.Text = "Miscellaneous";
            // 
            // cbxOil
            // 
            this.cbxOil.AutoSize = true;
            this.cbxOil.Location = new System.Drawing.Point(6, 23);
            this.cbxOil.Name = "cbxOil";
            this.cbxOil.Size = new System.Drawing.Size(168, 24);
            this.cbxOil.TabIndex = 0;
            this.cbxOil.Text = "Oil Change - $26.00";
            this.cbxOil.UseVisualStyleBackColor = true;
            // 
            // cbxLube
            // 
            this.cbxLube.AutoSize = true;
            this.cbxLube.Location = new System.Drawing.Point(0, 87);
            this.cbxLube.Name = "cbxLube";
            this.cbxLube.Size = new System.Drawing.Size(177, 24);
            this.cbxLube.TabIndex = 1;
            this.cbxLube.Text = "Luberication - $18.00";
            this.cbxLube.UseVisualStyleBackColor = true;
            // 
            // cbxTire
            // 
            this.cbxTire.AutoSize = true;
            this.cbxTire.Location = new System.Drawing.Point(6, 87);
            this.cbxTire.Name = "cbxTire";
            this.cbxTire.Size = new System.Drawing.Size(181, 24);
            this.cbxTire.TabIndex = 5;
            this.cbxTire.Text = "Tire Rotation - $20.00";
            this.cbxTire.UseVisualStyleBackColor = true;
            // 
            // cbxInspection
            // 
            this.cbxInspection.AutoSize = true;
            this.cbxInspection.Location = new System.Drawing.Point(6, 23);
            this.cbxInspection.Name = "cbxInspection";
            this.cbxInspection.Size = new System.Drawing.Size(164, 24);
            this.cbxInspection.TabIndex = 4;
            this.cbxInspection.Text = "Inspection - $15.00";
            this.cbxInspection.UseVisualStyleBackColor = true;
            // 
            // cbxMuffler
            // 
            this.cbxMuffler.AutoSize = true;
            this.cbxMuffler.Location = new System.Drawing.Point(6, 55);
            this.cbxMuffler.Name = "cbxMuffler";
            this.cbxMuffler.Size = new System.Drawing.Size(247, 24);
            this.cbxMuffler.TabIndex = 6;
            this.cbxMuffler.Text = "Muffler Replacement - $100.00";
            this.cbxMuffler.UseVisualStyleBackColor = true;
            // 
            // cbxRadiator
            // 
            this.cbxRadiator.AutoSize = true;
            this.cbxRadiator.Location = new System.Drawing.Point(6, 23);
            this.cbxRadiator.Name = "cbxRadiator";
            this.cbxRadiator.Size = new System.Drawing.Size(194, 24);
            this.cbxRadiator.TabIndex = 2;
            this.cbxRadiator.Text = "Radiator Flush - $30.00";
            this.cbxRadiator.UseVisualStyleBackColor = true;
            // 
            // cbxTransmission
            // 
            this.cbxTransmission.AutoSize = true;
            this.cbxTransmission.Location = new System.Drawing.Point(6, 87);
            this.cbxTransmission.Name = "cbxTransmission";
            this.cbxTransmission.Size = new System.Drawing.Size(226, 24);
            this.cbxTransmission.TabIndex = 3;
            this.cbxTransmission.Text = "Transmission Flush - $80.00";
            this.cbxTransmission.UseVisualStyleBackColor = true;
            // 
            // gbxFlush
            // 
            this.gbxFlush.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.gbxFlush.Controls.Add(this.cbxTransmission);
            this.gbxFlush.Controls.Add(this.cbxRadiator);
            this.gbxFlush.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFlush.Location = new System.Drawing.Point(371, 24);
            this.gbxFlush.Name = "gbxFlush";
            this.gbxFlush.Size = new System.Drawing.Size(300, 125);
            this.gbxFlush.TabIndex = 1;
            this.gbxFlush.TabStop = false;
            this.gbxFlush.Text = "Flushes";
            // 
            // gbxTotal
            // 
            this.gbxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.gbxTotal.Controls.Add(this.txtTotal);
            this.gbxTotal.Controls.Add(this.txtTax);
            this.gbxTotal.Controls.Add(this.txtTotalParts);
            this.gbxTotal.Controls.Add(this.txtTotalServices);
            this.gbxTotal.Controls.Add(this.lblSumServices);
            this.gbxTotal.Controls.Add(this.lblSumParts);
            this.gbxTotal.Controls.Add(this.lblSumTax);
            this.gbxTotal.Controls.Add(this.lblSumTotalCharge);
            this.gbxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTotal.Location = new System.Drawing.Point(19, 351);
            this.gbxTotal.Name = "gbxTotal";
            this.gbxTotal.Size = new System.Drawing.Size(652, 207);
            this.gbxTotal.TabIndex = 3;
            this.gbxTotal.TabStop = false;
            this.gbxTotal.Text = "Total";
            // 
            // gbxParts
            // 
            this.gbxParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.gbxParts.Controls.Add(this.lblLabor);
            this.gbxParts.Controls.Add(this.txtLabor);
            this.gbxParts.Controls.Add(this.txtParts);
            this.gbxParts.Controls.Add(this.lblParts);
            this.gbxParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxParts.Location = new System.Drawing.Point(371, 192);
            this.gbxParts.Name = "gbxParts";
            this.gbxParts.Size = new System.Drawing.Size(300, 125);
            this.gbxParts.TabIndex = 2;
            this.gbxParts.TabStop = false;
            this.gbxParts.Text = "Parts and Labor";
            // 
            // bntCalculate
            // 
            this.bntCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalculate.Location = new System.Drawing.Point(17, 572);
            this.bntCalculate.Name = "bntCalculate";
            this.bntCalculate.Size = new System.Drawing.Size(200, 75);
            this.bntCalculate.TabIndex = 4;
            this.bntCalculate.Text = "Calculate";
            this.bntCalculate.UseVisualStyleBackColor = true;
            this.bntCalculate.Click += new System.EventHandler(this.bntCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(471, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 75);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(244, 572);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 75);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSumServices
            // 
            this.lblSumServices.Location = new System.Drawing.Point(161, 36);
            this.lblSumServices.Name = "lblSumServices";
            this.lblSumServices.Size = new System.Drawing.Size(115, 20);
            this.lblSumServices.TabIndex = 8;
            this.lblSumServices.Text = "Services:";
            this.lblSumServices.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumParts
            // 
            this.lblSumParts.Location = new System.Drawing.Point(161, 75);
            this.lblSumParts.Name = "lblSumParts";
            this.lblSumParts.Size = new System.Drawing.Size(115, 20);
            this.lblSumParts.TabIndex = 7;
            this.lblSumParts.Text = "Parts:";
            this.lblSumParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumTax
            // 
            this.lblSumTax.Location = new System.Drawing.Point(161, 121);
            this.lblSumTax.Name = "lblSumTax";
            this.lblSumTax.Size = new System.Drawing.Size(115, 20);
            this.lblSumTax.TabIndex = 6;
            this.lblSumTax.Text = "Tax - On Parts:";
            this.lblSumTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumTotalCharge
            // 
            this.lblSumTotalCharge.Location = new System.Drawing.Point(161, 170);
            this.lblSumTotalCharge.Name = "lblSumTotalCharge";
            this.lblSumTotalCharge.Size = new System.Drawing.Size(115, 20);
            this.lblSumTotalCharge.TabIndex = 5;
            this.lblSumTotalCharge.Text = "Total Charges:";
            this.lblSumTotalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(12, 24);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(46, 20);
            this.lblParts.TabIndex = 5;
            this.lblParts.Text = "Parts";
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(93, 21);
            this.txtParts.Name = "txtParts";
            this.txtParts.Size = new System.Drawing.Size(156, 26);
            this.txtParts.TabIndex = 6;
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(162, 71);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(121, 26);
            this.txtLabor.TabIndex = 7;
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(12, 74);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(130, 20);
            this.lblLabor.TabIndex = 8;
            this.lblLabor.Text = "Labor - $20.00 hr";
            // 
            // txtTotalServices
            // 
            this.txtTotalServices.Location = new System.Drawing.Point(282, 33);
            this.txtTotalServices.Name = "txtTotalServices";
            this.txtTotalServices.ReadOnly = true;
            this.txtTotalServices.Size = new System.Drawing.Size(156, 26);
            this.txtTotalServices.TabIndex = 13;
            // 
            // txtTotalParts
            // 
            this.txtTotalParts.Location = new System.Drawing.Point(282, 72);
            this.txtTotalParts.Name = "txtTotalParts";
            this.txtTotalParts.ReadOnly = true;
            this.txtTotalParts.Size = new System.Drawing.Size(156, 26);
            this.txtTotalParts.TabIndex = 14;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(282, 167);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(156, 26);
            this.txtTotal.TabIndex = 16;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(282, 119);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(156, 26);
            this.txtTax.TabIndex = 15;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(22)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.bntCalculate);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.gbxParts);
            this.Controls.Add(this.gbxMisc);
            this.Controls.Add(this.gbxFlush);
            this.Controls.Add(this.gbxOil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Auto Repair";
            this.gbxOil.ResumeLayout(false);
            this.gbxOil.PerformLayout();
            this.gbxMisc.ResumeLayout(false);
            this.gbxMisc.PerformLayout();
            this.gbxFlush.ResumeLayout(false);
            this.gbxFlush.PerformLayout();
            this.gbxTotal.ResumeLayout(false);
            this.gbxTotal.PerformLayout();
            this.gbxParts.ResumeLayout(false);
            this.gbxParts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOil;
        private System.Windows.Forms.GroupBox gbxMisc;
        private System.Windows.Forms.CheckBox cbxLube;
        private System.Windows.Forms.CheckBox cbxOil;
        private System.Windows.Forms.CheckBox cbxMuffler;
        private System.Windows.Forms.CheckBox cbxTire;
        private System.Windows.Forms.CheckBox cbxInspection;
        private System.Windows.Forms.CheckBox cbxRadiator;
        private System.Windows.Forms.CheckBox cbxTransmission;
        private System.Windows.Forms.GroupBox gbxFlush;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.GroupBox gbxParts;
        private System.Windows.Forms.Button bntCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSumServices;
        private System.Windows.Forms.Label lblSumParts;
        private System.Windows.Forms.Label lblSumTax;
        private System.Windows.Forms.Label lblSumTotalCharge;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtTotalParts;
        private System.Windows.Forms.TextBox txtTotalServices;
    }
}


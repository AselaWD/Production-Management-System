namespace ProductionManagementSystem
{
    partial class frm_IncentiveManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IncentiveManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_QRProcess = new System.Windows.Forms.Label();
            this.cmbIncentivePlan = new System.Windows.Forms.ComboBox();
            this.lblIncentivePlan = new System.Windows.Forms.Label();
            this.dateTimePickerIncentiveMonth = new System.Windows.Forms.DateTimePicker();
            this.lblIncentiveMonth = new System.Windows.Forms.Label();
            this.numericUpDownIncentiveAmount = new System.Windows.Forms.NumericUpDown();
            this.lblIncentiveAmount = new System.Windows.Forms.Label();
            this.lblIncentiveLimit = new System.Windows.Forms.Label();
            this.numericUpDownIncentiveLimit = new System.Windows.Forms.NumericUpDown();
            this.groupBoxMakePlan = new System.Windows.Forms.GroupBox();
            this.btnMakePlan = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncentiveAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncentiveLimit)).BeginInit();
            this.groupBoxMakePlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // label_QRProcess
            // 
            this.label_QRProcess.AutoSize = true;
            this.label_QRProcess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label_QRProcess.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_QRProcess.Location = new System.Drawing.Point(133, 13);
            this.label_QRProcess.Name = "label_QRProcess";
            this.label_QRProcess.Size = new System.Drawing.Size(367, 37);
            this.label_QRProcess.TabIndex = 101;
            this.label_QRProcess.Text = "Incentive Management";
            // 
            // cmbIncentivePlan
            // 
            this.cmbIncentivePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncentivePlan.FormattingEnabled = true;
            this.cmbIncentivePlan.Items.AddRange(new object[] {
            "Page Count",
            "Book Count"});
            this.cmbIncentivePlan.Location = new System.Drawing.Point(151, 67);
            this.cmbIncentivePlan.Name = "cmbIncentivePlan";
            this.cmbIncentivePlan.Size = new System.Drawing.Size(154, 26);
            this.cmbIncentivePlan.TabIndex = 103;
            // 
            // lblIncentivePlan
            // 
            this.lblIncentivePlan.AutoSize = true;
            this.lblIncentivePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIncentivePlan.Location = new System.Drawing.Point(43, 72);
            this.lblIncentivePlan.Name = "lblIncentivePlan";
            this.lblIncentivePlan.Size = new System.Drawing.Size(102, 18);
            this.lblIncentivePlan.TabIndex = 104;
            this.lblIncentivePlan.Text = "Incentive Plan:";
            // 
            // dateTimePickerIncentiveMonth
            // 
            this.dateTimePickerIncentiveMonth.CustomFormat = "MMMM yyyy";
            this.dateTimePickerIncentiveMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerIncentiveMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIncentiveMonth.Location = new System.Drawing.Point(151, 26);
            this.dateTimePickerIncentiveMonth.Name = "dateTimePickerIncentiveMonth";
            this.dateTimePickerIncentiveMonth.Size = new System.Drawing.Size(159, 24);
            this.dateTimePickerIncentiveMonth.TabIndex = 105;
            // 
            // lblIncentiveMonth
            // 
            this.lblIncentiveMonth.AutoSize = true;
            this.lblIncentiveMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIncentiveMonth.Location = new System.Drawing.Point(26, 31);
            this.lblIncentiveMonth.Name = "lblIncentiveMonth";
            this.lblIncentiveMonth.Size = new System.Drawing.Size(119, 18);
            this.lblIncentiveMonth.TabIndex = 106;
            this.lblIncentiveMonth.Text = "Incentive Month: ";
            // 
            // numericUpDownIncentiveAmount
            // 
            this.numericUpDownIncentiveAmount.DecimalPlaces = 2;
            this.numericUpDownIncentiveAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIncentiveAmount.Location = new System.Drawing.Point(151, 150);
            this.numericUpDownIncentiveAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIncentiveAmount.Name = "numericUpDownIncentiveAmount";
            this.numericUpDownIncentiveAmount.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownIncentiveAmount.TabIndex = 107;
            this.numericUpDownIncentiveAmount.ThousandsSeparator = true;
            // 
            // lblIncentiveAmount
            // 
            this.lblIncentiveAmount.AutoSize = true;
            this.lblIncentiveAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIncentiveAmount.Location = new System.Drawing.Point(17, 154);
            this.lblIncentiveAmount.Name = "lblIncentiveAmount";
            this.lblIncentiveAmount.Size = new System.Drawing.Size(128, 18);
            this.lblIncentiveAmount.TabIndex = 108;
            this.lblIncentiveAmount.Text = "Incentive Amount: ";
            // 
            // lblIncentiveLimit
            // 
            this.lblIncentiveLimit.AutoSize = true;
            this.lblIncentiveLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblIncentiveLimit.Location = new System.Drawing.Point(37, 113);
            this.lblIncentiveLimit.Name = "lblIncentiveLimit";
            this.lblIncentiveLimit.Size = new System.Drawing.Size(108, 18);
            this.lblIncentiveLimit.TabIndex = 110;
            this.lblIncentiveLimit.Text = "Incentive Limit: ";
            // 
            // numericUpDownIncentiveLimit
            // 
            this.numericUpDownIncentiveLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIncentiveLimit.Location = new System.Drawing.Point(151, 109);
            this.numericUpDownIncentiveLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIncentiveLimit.Name = "numericUpDownIncentiveLimit";
            this.numericUpDownIncentiveLimit.Size = new System.Drawing.Size(120, 24);
            this.numericUpDownIncentiveLimit.TabIndex = 109;
            this.numericUpDownIncentiveLimit.ThousandsSeparator = true;
            // 
            // groupBoxMakePlan
            // 
            this.groupBoxMakePlan.Controls.Add(this.btnMakePlan);
            this.groupBoxMakePlan.Controls.Add(this.lblIncentiveMonth);
            this.groupBoxMakePlan.Controls.Add(this.lblIncentiveLimit);
            this.groupBoxMakePlan.Controls.Add(this.cmbIncentivePlan);
            this.groupBoxMakePlan.Controls.Add(this.numericUpDownIncentiveLimit);
            this.groupBoxMakePlan.Controls.Add(this.lblIncentivePlan);
            this.groupBoxMakePlan.Controls.Add(this.lblIncentiveAmount);
            this.groupBoxMakePlan.Controls.Add(this.dateTimePickerIncentiveMonth);
            this.groupBoxMakePlan.Controls.Add(this.numericUpDownIncentiveAmount);
            this.groupBoxMakePlan.Location = new System.Drawing.Point(140, 87);
            this.groupBoxMakePlan.Name = "groupBoxMakePlan";
            this.groupBoxMakePlan.Size = new System.Drawing.Size(417, 200);
            this.groupBoxMakePlan.TabIndex = 111;
            this.groupBoxMakePlan.TabStop = false;
            // 
            // btnMakePlan
            // 
            this.btnMakePlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakePlan.Location = new System.Drawing.Point(326, 167);
            this.btnMakePlan.Name = "btnMakePlan";
            this.btnMakePlan.Size = new System.Drawing.Size(85, 27);
            this.btnMakePlan.TabIndex = 111;
            this.btnMakePlan.Text = "Make Plan";
            this.btnMakePlan.UseVisualStyleBackColor = true;
            this.btnMakePlan.Click += new System.EventHandler(this.btnMakePlan_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(140, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 112;
            this.checkBox1.Text = "Make a Plan";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(531, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 39);
            this.btnExit.TabIndex = 112;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frm_IncentiveManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(654, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBoxMakePlan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_QRProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_IncentiveManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incentive Management";
            this.Load += new System.EventHandler(this.frm_IncentiveManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncentiveAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIncentiveLimit)).EndInit();
            this.groupBoxMakePlan.ResumeLayout(false);
            this.groupBoxMakePlan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_QRProcess;
        private System.Windows.Forms.ComboBox cmbIncentivePlan;
        private System.Windows.Forms.Label lblIncentivePlan;
        private System.Windows.Forms.DateTimePicker dateTimePickerIncentiveMonth;
        private System.Windows.Forms.Label lblIncentiveMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownIncentiveAmount;
        private System.Windows.Forms.Label lblIncentiveAmount;
        private System.Windows.Forms.Label lblIncentiveLimit;
        private System.Windows.Forms.NumericUpDown numericUpDownIncentiveLimit;
        private System.Windows.Forms.GroupBox groupBoxMakePlan;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnMakePlan;
        private System.Windows.Forms.Button btnExit;
    }
}
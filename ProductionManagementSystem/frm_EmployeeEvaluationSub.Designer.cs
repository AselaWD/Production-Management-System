namespace ProductionManagementSystem
{
    partial class frm_EmployeeEvaluationSub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmployeeEvaluationSub));
            this.label_DcdInventory = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbUID = new System.Windows.Forms.ComboBox();
            this.lblUID = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.radioAllUser = new System.Windows.Forms.RadioButton();
            this.radioUserWise = new System.Windows.Forms.RadioButton();
            this.radioButtonShipmentName = new System.Windows.Forms.RadioButton();
            this.lblShipmentName = new System.Windows.Forms.Label();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DcdInventory
            // 
            this.label_DcdInventory.AutoSize = true;
            this.label_DcdInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label_DcdInventory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_DcdInventory.Location = new System.Drawing.Point(92, 12);
            this.label_DcdInventory.Name = "label_DcdInventory";
            this.label_DcdInventory.Size = new System.Drawing.Size(306, 37);
            this.label_DcdInventory.TabIndex = 14;
            this.label_DcdInventory.Text = "Production History";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(501, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cmbUID
            // 
            this.cmbUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUID.FormattingEnabled = true;
            this.cmbUID.Location = new System.Drawing.Point(114, 94);
            this.cmbUID.Name = "cmbUID";
            this.cmbUID.Size = new System.Drawing.Size(80, 24);
            this.cmbUID.TabIndex = 16;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUID.Location = new System.Drawing.Point(51, 97);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(56, 16);
            this.lblUID.TabIndex = 17;
            this.lblUID.Text = "User ID:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(501, 86);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(128, 41);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // radioAllUser
            // 
            this.radioAllUser.AutoSize = true;
            this.radioAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAllUser.Location = new System.Drawing.Point(21, 27);
            this.radioAllUser.Name = "radioAllUser";
            this.radioAllUser.Size = new System.Drawing.Size(44, 20);
            this.radioAllUser.TabIndex = 19;
            this.radioAllUser.TabStop = true;
            this.radioAllUser.Text = "All ";
            this.radioAllUser.UseVisualStyleBackColor = true;
            this.radioAllUser.CheckedChanged += new System.EventHandler(this.radioAllUser_CheckedChanged);
            // 
            // radioUserWise
            // 
            this.radioUserWise.AutoSize = true;
            this.radioUserWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUserWise.Location = new System.Drawing.Point(21, 62);
            this.radioUserWise.Name = "radioUserWise";
            this.radioUserWise.Size = new System.Drawing.Size(89, 20);
            this.radioUserWise.TabIndex = 20;
            this.radioUserWise.TabStop = true;
            this.radioUserWise.Text = "User Wise";
            this.radioUserWise.UseVisualStyleBackColor = true;
            this.radioUserWise.CheckedChanged += new System.EventHandler(this.radioUserWise_CheckedChanged);
            // 
            // radioButtonShipmentName
            // 
            this.radioButtonShipmentName.AutoSize = true;
            this.radioButtonShipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonShipmentName.Location = new System.Drawing.Point(21, 131);
            this.radioButtonShipmentName.Name = "radioButtonShipmentName";
            this.radioButtonShipmentName.Size = new System.Drawing.Size(113, 20);
            this.radioButtonShipmentName.TabIndex = 23;
            this.radioButtonShipmentName.TabStop = true;
            this.radioButtonShipmentName.Text = "Shpment Wise";
            this.radioButtonShipmentName.UseVisualStyleBackColor = true;
            this.radioButtonShipmentName.CheckedChanged += new System.EventHandler(this.radioButtonShipmentName_CheckedChanged);
            // 
            // lblShipmentName
            // 
            this.lblShipmentName.AutoSize = true;
            this.lblShipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipmentName.Location = new System.Drawing.Point(51, 164);
            this.lblShipmentName.Name = "lblShipmentName";
            this.lblShipmentName.Size = new System.Drawing.Size(107, 16);
            this.lblShipmentName.TabIndex = 22;
            this.lblShipmentName.Text = "Shipment Name:";
            // 
            // cmbShipment
            // 
            this.cmbShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Location = new System.Drawing.Point(164, 161);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(182, 24);
            this.cmbShipment.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonShipmentName);
            this.groupBox1.Controls.Add(this.lblShipmentName);
            this.groupBox1.Controls.Add(this.cmbShipment);
            this.groupBox1.Controls.Add(this.radioUserWise);
            this.groupBox1.Controls.Add(this.radioAllUser);
            this.groupBox1.Controls.Add(this.lblUID);
            this.groupBox1.Controls.Add(this.cmbUID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(99, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 225);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by:";
            // 
            // frm_EmployeeEvaluationSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(644, 308);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label_DcdInventory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_EmployeeEvaluationSub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production History";
            this.Load += new System.EventHandler(this.frm_EmployeeEvaluationSub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DcdInventory;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbUID;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton radioAllUser;
        private System.Windows.Forms.RadioButton radioUserWise;
        private System.Windows.Forms.RadioButton radioButtonShipmentName;
        private System.Windows.Forms.Label lblShipmentName;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
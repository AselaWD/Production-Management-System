namespace ProductionManagementSystem
{
    partial class frm_AssignProduction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AssignProduction));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAssignUID = new System.Windows.Forms.Button();
            this.label_DcdInventory = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPID = new System.Windows.Forms.ComboBox();
            this.btnRemoveUID = new System.Windows.Forms.Button();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.dataGridBeforeAssignedUID = new System.Windows.Forms.DataGridView();
            this.lblLBookTitle = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.cmbUserID = new System.Windows.Forms.ComboBox();
            this.dataGridAfterAssignedUID = new System.Windows.Forms.DataGridView();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModifyUID = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCUID = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBeforeAssignedUID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfterAssignedUID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(199, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shipment:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(194, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Book Title:";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Location = new System.Drawing.Point(507, 67);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(50, 35);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(762, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Start Date: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "dd/MMM/yyyy";
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(855, 149);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(159, 24);
            this.dateTimePickerStartDate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.Location = new System.Drawing.Point(736, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Output Format:";
            // 
            // btnAssignUID
            // 
            this.btnAssignUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAssignUID.Location = new System.Drawing.Point(1099, 248);
            this.btnAssignUID.Name = "btnAssignUID";
            this.btnAssignUID.Size = new System.Drawing.Size(132, 43);
            this.btnAssignUID.TabIndex = 23;
            this.btnAssignUID.Text = "Assign UID";
            this.btnAssignUID.UseVisualStyleBackColor = true;
            this.btnAssignUID.Click += new System.EventHandler(this.btnAssignUID_Click);
            // 
            // label_DcdInventory
            // 
            this.label_DcdInventory.AutoSize = true;
            this.label_DcdInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label_DcdInventory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_DcdInventory.Location = new System.Drawing.Point(169, 9);
            this.label_DcdInventory.Name = "label_DcdInventory";
            this.label_DcdInventory.Size = new System.Drawing.Size(300, 37);
            this.label_DcdInventory.TabIndex = 25;
            this.label_DcdInventory.Text = "Assign Production";
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1099, 496);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 43);
            this.button3.TabIndex = 35;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(171, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Production ID:";
            // 
            // cmbPID
            // 
            this.cmbPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPID.FormattingEnabled = true;
            this.cmbPID.Location = new System.Drawing.Point(279, 108);
            this.cmbPID.Name = "cmbPID";
            this.cmbPID.Size = new System.Drawing.Size(150, 26);
            this.cmbPID.TabIndex = 41;
            // 
            // btnRemoveUID
            // 
            this.btnRemoveUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnRemoveUID.Location = new System.Drawing.Point(1099, 372);
            this.btnRemoveUID.Name = "btnRemoveUID";
            this.btnRemoveUID.Size = new System.Drawing.Size(132, 43);
            this.btnRemoveUID.TabIndex = 23;
            this.btnRemoveUID.Text = "Remove UID";
            this.btnRemoveUID.UseVisualStyleBackColor = true;
            this.btnRemoveUID.Click += new System.EventHandler(this.btnRemoveUID_Click);
            // 
            // cmbShipment
            // 
            this.cmbShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Location = new System.Drawing.Point(279, 71);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(222, 26);
            this.cmbShipment.TabIndex = 43;
            // 
            // dataGridBeforeAssignedUID
            // 
            this.dataGridBeforeAssignedUID.AllowUserToAddRows = false;
            this.dataGridBeforeAssignedUID.AllowUserToDeleteRows = false;
            this.dataGridBeforeAssignedUID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridBeforeAssignedUID.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridBeforeAssignedUID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridBeforeAssignedUID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBeforeAssignedUID.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridBeforeAssignedUID.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridBeforeAssignedUID.Location = new System.Drawing.Point(5, 201);
            this.dataGridBeforeAssignedUID.MultiSelect = false;
            this.dataGridBeforeAssignedUID.Name = "dataGridBeforeAssignedUID";
            this.dataGridBeforeAssignedUID.ReadOnly = true;
            this.dataGridBeforeAssignedUID.RowHeadersVisible = false;
            this.dataGridBeforeAssignedUID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBeforeAssignedUID.Size = new System.Drawing.Size(1088, 180);
            this.dataGridBeforeAssignedUID.TabIndex = 44;
            this.dataGridBeforeAssignedUID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBeforeAssignedUID_CellContentClick);
            // 
            // lblLBookTitle
            // 
            this.lblLBookTitle.AutoSize = true;
            this.lblLBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLBookTitle.Location = new System.Drawing.Point(276, 154);
            this.lblLBookTitle.Name = "lblLBookTitle";
            this.lblLBookTitle.Size = new System.Drawing.Size(0, 18);
            this.lblLBookTitle.TabIndex = 45;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUserID.Location = new System.Drawing.Point(782, 113);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(62, 18);
            this.lblUserID.TabIndex = 47;
            this.lblUserID.Text = "User ID:";
            // 
            // cmbUserID
            // 
            this.cmbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbUserID.FormattingEnabled = true;
            this.cmbUserID.Location = new System.Drawing.Point(855, 110);
            this.cmbUserID.Name = "cmbUserID";
            this.cmbUserID.Size = new System.Drawing.Size(135, 26);
            this.cmbUserID.TabIndex = 46;
            // 
            // dataGridAfterAssignedUID
            // 
            this.dataGridAfterAssignedUID.AllowUserToAddRows = false;
            this.dataGridAfterAssignedUID.AllowUserToDeleteRows = false;
            this.dataGridAfterAssignedUID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAfterAssignedUID.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAfterAssignedUID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAfterAssignedUID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfterAssignedUID.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAfterAssignedUID.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAfterAssignedUID.Location = new System.Drawing.Point(5, 410);
            this.dataGridAfterAssignedUID.MultiSelect = false;
            this.dataGridAfterAssignedUID.Name = "dataGridAfterAssignedUID";
            this.dataGridAfterAssignedUID.ReadOnly = true;
            this.dataGridAfterAssignedUID.RowHeadersVisible = false;
            this.dataGridAfterAssignedUID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAfterAssignedUID.Size = new System.Drawing.Size(1088, 180);
            this.dataGridAfterAssignedUID.TabIndex = 48;
            this.dataGridAfterAssignedUID.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAfterAssignedUID_CellContentClick);
            // 
            // cmbFormat
            // 
            this.cmbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point(855, 71);
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size(135, 26);
            this.cmbFormat.TabIndex = 18;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1099, 434);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 43);
            this.btnRefresh.TabIndex = 49;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "File(s) to be assigned:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 51;
            this.label7.Text = "Assigned File(s):";
            // 
            // btnModifyUID
            // 
            this.btnModifyUID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnModifyUID.Location = new System.Drawing.Point(1099, 310);
            this.btnModifyUID.Name = "btnModifyUID";
            this.btnModifyUID.Size = new System.Drawing.Size(132, 43);
            this.btnModifyUID.TabIndex = 52;
            this.btnModifyUID.Text = "Modify UID";
            this.btnModifyUID.UseVisualStyleBackColor = true;
            this.btnModifyUID.Click += new System.EventHandler(this.btnModifyUID_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // lblCUID
            // 
            this.lblCUID.AutoSize = true;
            this.lblCUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblCUID.Location = new System.Drawing.Point(996, 24);
            this.lblCUID.Name = "lblCUID";
            this.lblCUID.Size = new System.Drawing.Size(41, 18);
            this.lblCUID.TabIndex = 54;
            this.lblCUID.Text = "[UID]";
            this.lblCUID.Visible = false;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTeam.Location = new System.Drawing.Point(1086, 24);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(54, 18);
            this.lblTeam.TabIndex = 55;
            this.lblTeam.Text = "[Team]";
            this.lblTeam.Visible = false;
            // 
            // frm_AssignProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1243, 596);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblCUID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModifyUID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridAfterAssignedUID);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.cmbUserID);
            this.Controls.Add(this.lblLBookTitle);
            this.Controls.Add(this.dataGridBeforeAssignedUID);
            this.Controls.Add(this.cmbShipment);
            this.Controls.Add(this.cmbPID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label_DcdInventory);
            this.Controls.Add(this.btnRemoveUID);
            this.Controls.Add(this.btnAssignUID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFormat);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_AssignProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Production";
            this.Load += new System.EventHandler(this.frm_AssignProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBeforeAssignedUID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfterAssignedUID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAssignUID;
        private System.Windows.Forms.Label label_DcdInventory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPID;
        private System.Windows.Forms.Button btnRemoveUID;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.DataGridView dataGridBeforeAssignedUID;
        private System.Windows.Forms.Label lblLBookTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.ComboBox cmbUserID;
        private System.Windows.Forms.DataGridView dataGridAfterAssignedUID;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModifyUID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCUID;
        private System.Windows.Forms.Label lblTeam;
    }
}
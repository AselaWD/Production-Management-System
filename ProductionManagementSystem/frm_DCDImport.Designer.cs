namespace ProductionManagementSystem
{
    partial class frm_DCDImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DCDImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbShipmentName = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.dataGridViewDCDImport = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label_DcdInventory = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblImportPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.dateTimePickerDCDImport = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlDCDImport = new System.Windows.Forms.TabControl();
            this.tabPageImportShipment = new System.Windows.Forms.TabPage();
            this.tabPageeBookInventory = new System.Windows.Forms.TabPage();
            this.dataGridViewDCDInventory = new System.Windows.Forms.DataGridView();
            this.dateTimePickerAllocatedDate = new System.Windows.Forms.DateTimePicker();
            this.lblAllocatedDate = new System.Windows.Forms.Label();
            this.cmbPDTeam = new System.Windows.Forms.ComboBox();
            this.lblPDTeam = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDCDImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlDCDImport.SuspendLayout();
            this.tabPageImportShipment.SuspendLayout();
            this.tabPageeBookInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDCDInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbShipmentName
            // 
            this.cmbShipmentName.BackColor = System.Drawing.Color.LightBlue;
            this.cmbShipmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipmentName.FormattingEnabled = true;
            this.cmbShipmentName.Location = new System.Drawing.Point(229, 74);
            this.cmbShipmentName.Name = "cmbShipmentName";
            this.cmbShipmentName.Size = new System.Drawing.Size(226, 26);
            this.cmbShipmentName.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(1165, 379);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 39);
            this.btnRefresh.TabIndex = 32;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(1165, 322);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(73, 39);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1165, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 39);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(1153, 83);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(85, 57);
            this.btnImport.TabIndex = 28;
            this.btnImport.Text = "Import Shipment";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewDCDImport
            // 
            this.dataGridViewDCDImport.AllowUserToAddRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDCDImport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDCDImport.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewDCDImport.ColumnHeadersHeight = 25;
            this.dataGridViewDCDImport.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewDCDImport.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDCDImport.MultiSelect = false;
            this.dataGridViewDCDImport.Name = "dataGridViewDCDImport";
            this.dataGridViewDCDImport.ReadOnly = true;
            this.dataGridViewDCDImport.RowHeadersVisible = false;
            this.dataGridViewDCDImport.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDCDImport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDCDImport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewDCDImport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDCDImport.RowTemplate.ReadOnly = true;
            this.dataGridViewDCDImport.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDCDImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDCDImport.Size = new System.Drawing.Size(1138, 286);
            this.dataGridViewDCDImport.TabIndex = 27;
            this.dataGridViewDCDImport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDCDImport_CellContentClick_1);
            this.dataGridViewDCDImport.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewdataGridViewDCDImport_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Dowloaded Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "File Count:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Shipment: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1165, 435);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(73, 39);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_DcdInventory
            // 
            this.label_DcdInventory.AutoSize = true;
            this.label_DcdInventory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label_DcdInventory.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_DcdInventory.Location = new System.Drawing.Point(141, 12);
            this.label_DcdInventory.Name = "label_DcdInventory";
            this.label_DcdInventory.Size = new System.Drawing.Size(281, 37);
            this.label_DcdInventory.TabIndex = 20;
            this.label_DcdInventory.Text = "Shipment Handle";
            this.label_DcdInventory.Click += new System.EventHandler(this.label_DcdInventory_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xls,.xlsx";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Open Shipment";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lblImportPath
            // 
            this.lblImportPath.AutoSize = true;
            this.lblImportPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportPath.Location = new System.Drawing.Point(83, 516);
            this.lblImportPath.Name = "lblImportPath";
            this.lblImportPath.Size = new System.Drawing.Size(16, 15);
            this.lblImportPath.TabIndex = 36;
            this.lblImportPath.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Excel Path:";
            // 
            // lblFileCount
            // 
            this.lblFileCount.AutoSize = true;
            this.lblFileCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblFileCount.Location = new System.Drawing.Point(229, 113);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Size = new System.Drawing.Size(0, 18);
            this.lblFileCount.TabIndex = 38;
            // 
            // dateTimePickerDCDImport
            // 
            this.dateTimePickerDCDImport.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dateTimePickerDCDImport.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerDCDImport.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerDCDImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerDCDImport.CustomFormat = "";
            this.dateTimePickerDCDImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerDCDImport.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDCDImport.Location = new System.Drawing.Point(604, 75);
            this.dateTimePickerDCDImport.Name = "dateTimePickerDCDImport";
            this.dateTimePickerDCDImport.Size = new System.Drawing.Size(131, 24);
            this.dateTimePickerDCDImport.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlDCDImport
            // 
            this.tabControlDCDImport.Controls.Add(this.tabPageImportShipment);
            this.tabControlDCDImport.Controls.Add(this.tabPageeBookInventory);
            this.tabControlDCDImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlDCDImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDCDImport.Location = new System.Drawing.Point(0, 174);
            this.tabControlDCDImport.Multiline = true;
            this.tabControlDCDImport.Name = "tabControlDCDImport";
            this.tabControlDCDImport.SelectedIndex = 0;
            this.tabControlDCDImport.Size = new System.Drawing.Size(1146, 315);
            this.tabControlDCDImport.TabIndex = 40;
            this.tabControlDCDImport.Click += new System.EventHandler(this.tabControlDCDImport_Click);
            // 
            // tabPageImportShipment
            // 
            this.tabPageImportShipment.Controls.Add(this.dataGridViewDCDImport);
            this.tabPageImportShipment.ForeColor = System.Drawing.Color.Black;
            this.tabPageImportShipment.Location = new System.Drawing.Point(4, 25);
            this.tabPageImportShipment.Name = "tabPageImportShipment";
            this.tabPageImportShipment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImportShipment.Size = new System.Drawing.Size(1138, 286);
            this.tabPageImportShipment.TabIndex = 0;
            this.tabPageImportShipment.Text = "Import Shipment";
            // 
            // tabPageeBookInventory
            // 
            this.tabPageeBookInventory.Controls.Add(this.dataGridViewDCDInventory);
            this.tabPageeBookInventory.ForeColor = System.Drawing.Color.Black;
            this.tabPageeBookInventory.Location = new System.Drawing.Point(4, 25);
            this.tabPageeBookInventory.Name = "tabPageeBookInventory";
            this.tabPageeBookInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageeBookInventory.Size = new System.Drawing.Size(1138, 286);
            this.tabPageeBookInventory.TabIndex = 1;
            this.tabPageeBookInventory.Text = "eBook Inventory";
            // 
            // dataGridViewDCDInventory
            // 
            this.dataGridViewDCDInventory.AllowUserToAddRows = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDCDInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDCDInventory.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridViewDCDInventory.ColumnHeadersHeight = 25;
            this.dataGridViewDCDInventory.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewDCDInventory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDCDInventory.MultiSelect = false;
            this.dataGridViewDCDInventory.Name = "dataGridViewDCDInventory";
            this.dataGridViewDCDInventory.ReadOnly = true;
            this.dataGridViewDCDInventory.RowHeadersVisible = false;
            this.dataGridViewDCDInventory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewDCDInventory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDCDInventory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewDCDInventory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDCDInventory.RowTemplate.ReadOnly = true;
            this.dataGridViewDCDInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDCDInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDCDInventory.Size = new System.Drawing.Size(1138, 286);
            this.dataGridViewDCDInventory.TabIndex = 28;
            this.dataGridViewDCDInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDCDInventory_CellClick);
            this.dataGridViewDCDInventory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDCDInventory_CellDoubleClick);
            // 
            // dateTimePickerAllocatedDate
            // 
            this.dateTimePickerAllocatedDate.CalendarMonthBackground = System.Drawing.Color.LightBlue;
            this.dateTimePickerAllocatedDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAllocatedDate.CalendarTitleForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePickerAllocatedDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerAllocatedDate.CustomFormat = "";
            this.dateTimePickerAllocatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dateTimePickerAllocatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAllocatedDate.Location = new System.Drawing.Point(604, 108);
            this.dateTimePickerAllocatedDate.Name = "dateTimePickerAllocatedDate";
            this.dateTimePickerAllocatedDate.Size = new System.Drawing.Size(131, 24);
            this.dateTimePickerAllocatedDate.TabIndex = 41;
            // 
            // lblAllocatedDate
            // 
            this.lblAllocatedDate.AutoSize = true;
            this.lblAllocatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllocatedDate.Location = new System.Drawing.Point(491, 113);
            this.lblAllocatedDate.Name = "lblAllocatedDate";
            this.lblAllocatedDate.Size = new System.Drawing.Size(107, 18);
            this.lblAllocatedDate.TabIndex = 42;
            this.lblAllocatedDate.Text = "Allocated Date:";
            // 
            // cmbPDTeam
            // 
            this.cmbPDTeam.BackColor = System.Drawing.Color.LightBlue;
            this.cmbPDTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPDTeam.FormattingEnabled = true;
            this.cmbPDTeam.Location = new System.Drawing.Point(604, 142);
            this.cmbPDTeam.Name = "cmbPDTeam";
            this.cmbPDTeam.Size = new System.Drawing.Size(193, 26);
            this.cmbPDTeam.TabIndex = 43;
            // 
            // lblPDTeam
            // 
            this.lblPDTeam.AutoSize = true;
            this.lblPDTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDTeam.Location = new System.Drawing.Point(472, 145);
            this.lblPDTeam.Name = "lblPDTeam";
            this.lblPDTeam.Size = new System.Drawing.Size(126, 18);
            this.lblPDTeam.TabIndex = 44;
            this.lblPDTeam.Text = "Production Team:";
            // 
            // btnNew
            // 
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(1165, 211);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(73, 39);
            this.btnNew.TabIndex = 45;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frm_DCDImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1250, 538);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblPDTeam);
            this.Controls.Add(this.cmbPDTeam);
            this.Controls.Add(this.dateTimePickerAllocatedDate);
            this.Controls.Add(this.lblAllocatedDate);
            this.Controls.Add(this.tabControlDCDImport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePickerDCDImport);
            this.Controls.Add(this.lblFileCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblImportPath);
            this.Controls.Add(this.cmbShipmentName);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label_DcdInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_DCDImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCD Import";
            this.Load += new System.EventHandler(this.frm_DCDImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDCDImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlDCDImport.ResumeLayout(false);
            this.tabPageImportShipment.ResumeLayout(false);
            this.tabPageeBookInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDCDInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShipmentName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.DataGridView dataGridViewDCDImport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label_DcdInventory;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblImportPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.DateTimePicker dateTimePickerDCDImport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlDCDImport;
        private System.Windows.Forms.TabPage tabPageImportShipment;
        private System.Windows.Forms.TabPage tabPageeBookInventory;
        public System.Windows.Forms.DataGridView dataGridViewDCDInventory;
        private System.Windows.Forms.DateTimePicker dateTimePickerAllocatedDate;
        private System.Windows.Forms.Label lblAllocatedDate;
        private System.Windows.Forms.ComboBox cmbPDTeam;
        private System.Windows.Forms.Label lblPDTeam;
        private System.Windows.Forms.Button btnNew;
    }
}
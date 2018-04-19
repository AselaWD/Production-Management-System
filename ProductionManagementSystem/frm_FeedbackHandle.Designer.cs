namespace ProductionManagementSystem
{
    partial class frm_FeedbackHandle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FeedbackHandle));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.notifyFiles = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnReturnFile = new System.Windows.Forms.Button();
            this.dataGridViewFeedbackFile = new System.Windows.Forms.DataGridView();
            this.lblUTeam = new System.Windows.Forms.Label();
            this.lblUID = new System.Windows.Forms.Label();
            this.lbldRecivedDate = new System.Windows.Forms.Label();
            this.lbldXmittedDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFeedbackDone = new System.Windows.Forms.Label();
            this.lblPendingFeedback = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblXmittedDate = new System.Windows.Forms.Label();
            this.dataGridXmittedFiles = new System.Windows.Forms.DataGridView();
            this.cmbShipment = new System.Windows.Forms.ComboBox();
            this.cmbPISBN = new System.Windows.Forms.ComboBox();
            this.lblPISBN = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label_QRProcess = new System.Windows.Forms.Label();
            this.btnAddFeedBack = new System.Windows.Forms.Button();
            this.btnModifyFeedback = new System.Windows.Forms.Button();
            this.lblRecivedDate = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblShipment = new System.Windows.Forms.Label();
            this.lblbFormat = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lbldAuditName = new System.Windows.Forms.Label();
            this.lblAudiName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedbackFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXmittedFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyFiles
            // 
            this.notifyFiles.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyFiles.Icon")));
            this.notifyFiles.Text = "Production Management System - eBooks";
            this.notifyFiles.Visible = true;
            // 
            // btnReturnFile
            // 
            this.btnReturnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnReturnFile.Location = new System.Drawing.Point(1101, 364);
            this.btnReturnFile.Name = "btnReturnFile";
            this.btnReturnFile.Size = new System.Drawing.Size(142, 43);
            this.btnReturnFile.TabIndex = 130;
            this.btnReturnFile.Text = "Remove Feedback";
            this.btnReturnFile.UseVisualStyleBackColor = true;
            this.btnReturnFile.Click += new System.EventHandler(this.btnReturnFile_Click);
            // 
            // dataGridViewFeedbackFile
            // 
            this.dataGridViewFeedbackFile.AllowUserToAddRows = false;
            this.dataGridViewFeedbackFile.AllowUserToDeleteRows = false;
            this.dataGridViewFeedbackFile.AllowUserToResizeRows = false;
            this.dataGridViewFeedbackFile.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFeedbackFile.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFeedbackFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFeedbackFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFeedbackFile.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFeedbackFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFeedbackFile.Location = new System.Drawing.Point(5, 410);
            this.dataGridViewFeedbackFile.MultiSelect = false;
            this.dataGridViewFeedbackFile.Name = "dataGridViewFeedbackFile";
            this.dataGridViewFeedbackFile.ReadOnly = true;
            this.dataGridViewFeedbackFile.RowHeadersVisible = false;
            this.dataGridViewFeedbackFile.RowTemplate.ReadOnly = true;
            this.dataGridViewFeedbackFile.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFeedbackFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFeedbackFile.Size = new System.Drawing.Size(1088, 175);
            this.dataGridViewFeedbackFile.TabIndex = 129;
            // 
            // lblUTeam
            // 
            this.lblUTeam.AutoSize = true;
            this.lblUTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUTeam.Location = new System.Drawing.Point(1177, 28);
            this.lblUTeam.Name = "lblUTeam";
            this.lblUTeam.Size = new System.Drawing.Size(54, 18);
            this.lblUTeam.TabIndex = 128;
            this.lblUTeam.Text = "[Team]";
            this.lblUTeam.Visible = false;
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblUID.Location = new System.Drawing.Point(1130, 28);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(41, 18);
            this.lblUID.TabIndex = 127;
            this.lblUID.Text = "[UID]";
            this.lblUID.Visible = false;
            // 
            // lbldRecivedDate
            // 
            this.lbldRecivedDate.AutoSize = true;
            this.lbldRecivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbldRecivedDate.Location = new System.Drawing.Point(276, 153);
            this.lbldRecivedDate.Name = "lbldRecivedDate";
            this.lbldRecivedDate.Size = new System.Drawing.Size(0, 18);
            this.lbldRecivedDate.TabIndex = 126;
            // 
            // lbldXmittedDate
            // 
            this.lbldXmittedDate.AutoSize = true;
            this.lbldXmittedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbldXmittedDate.Location = new System.Drawing.Point(852, 74);
            this.lbldXmittedDate.Name = "lbldXmittedDate";
            this.lbldXmittedDate.Size = new System.Drawing.Size(0, 18);
            this.lbldXmittedDate.TabIndex = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // lblFeedbackDone
            // 
            this.lblFeedbackDone.AutoSize = true;
            this.lblFeedbackDone.Location = new System.Drawing.Point(2, 394);
            this.lblFeedbackDone.Name = "lblFeedbackDone";
            this.lblFeedbackDone.Size = new System.Drawing.Size(88, 13);
            this.lblFeedbackDone.TabIndex = 123;
            this.lblFeedbackDone.Text = "Feedback File(s):";
            // 
            // lblPendingFeedback
            // 
            this.lblPendingFeedback.AutoSize = true;
            this.lblPendingFeedback.Location = new System.Drawing.Point(2, 185);
            this.lblPendingFeedback.Name = "lblPendingFeedback";
            this.lblPendingFeedback.Size = new System.Drawing.Size(75, 13);
            this.lblPendingFeedback.TabIndex = 122;
            this.lblPendingFeedback.Text = "Xmitted File(s):";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1103, 426);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 43);
            this.btnRefresh.TabIndex = 113;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblXmittedDate
            // 
            this.lblXmittedDate.AutoSize = true;
            this.lblXmittedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblXmittedDate.Location = new System.Drawing.Point(747, 74);
            this.lblXmittedDate.Name = "lblXmittedDate";
            this.lblXmittedDate.Size = new System.Drawing.Size(97, 18);
            this.lblXmittedDate.TabIndex = 121;
            this.lblXmittedDate.Text = "Xmitted Date:";
            // 
            // dataGridXmittedFiles
            // 
            this.dataGridXmittedFiles.AllowUserToAddRows = false;
            this.dataGridXmittedFiles.AllowUserToDeleteRows = false;
            this.dataGridXmittedFiles.AllowUserToResizeRows = false;
            this.dataGridXmittedFiles.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridXmittedFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridXmittedFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridXmittedFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridXmittedFiles.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridXmittedFiles.Location = new System.Drawing.Point(5, 201);
            this.dataGridXmittedFiles.MultiSelect = false;
            this.dataGridXmittedFiles.Name = "dataGridXmittedFiles";
            this.dataGridXmittedFiles.ReadOnly = true;
            this.dataGridXmittedFiles.RowHeadersVisible = false;
            this.dataGridXmittedFiles.RowTemplate.ReadOnly = true;
            this.dataGridXmittedFiles.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridXmittedFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridXmittedFiles.Size = new System.Drawing.Size(1088, 180);
            this.dataGridXmittedFiles.TabIndex = 120;
            this.dataGridXmittedFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridXmittedFiles_CellContentClick);
            // 
            // cmbShipment
            // 
            this.cmbShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShipment.FormattingEnabled = true;
            this.cmbShipment.Location = new System.Drawing.Point(276, 71);
            this.cmbShipment.Name = "cmbShipment";
            this.cmbShipment.Size = new System.Drawing.Size(222, 26);
            this.cmbShipment.TabIndex = 107;
            // 
            // cmbPISBN
            // 
            this.cmbPISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPISBN.FormattingEnabled = true;
            this.cmbPISBN.Location = new System.Drawing.Point(276, 110);
            this.cmbPISBN.Name = "cmbPISBN";
            this.cmbPISBN.Size = new System.Drawing.Size(222, 26);
            this.cmbPISBN.TabIndex = 108;
            // 
            // lblPISBN
            // 
            this.lblPISBN.AutoSize = true;
            this.lblPISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblPISBN.Location = new System.Drawing.Point(174, 113);
            this.lblPISBN.Name = "lblPISBN";
            this.lblPISBN.Size = new System.Drawing.Size(96, 18);
            this.lblPISBN.TabIndex = 119;
            this.lblPISBN.Text = "Printed ISBN:";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1101, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 43);
            this.btnExit.TabIndex = 114;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label_QRProcess
            // 
            this.label_QRProcess.AutoSize = true;
            this.label_QRProcess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F);
            this.label_QRProcess.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_QRProcess.Location = new System.Drawing.Point(128, 13);
            this.label_QRProcess.Name = "label_QRProcess";
            this.label_QRProcess.Size = new System.Drawing.Size(316, 37);
            this.label_QRProcess.TabIndex = 118;
            this.label_QRProcess.Text = "Feedback Tracking";
            // 
            // btnAddFeedBack
            // 
            this.btnAddFeedBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnAddFeedBack.Location = new System.Drawing.Point(1101, 243);
            this.btnAddFeedBack.Name = "btnAddFeedBack";
            this.btnAddFeedBack.Size = new System.Drawing.Size(142, 43);
            this.btnAddFeedBack.TabIndex = 111;
            this.btnAddFeedBack.Text = "Add Feedback";
            this.btnAddFeedBack.UseVisualStyleBackColor = true;
            this.btnAddFeedBack.Click += new System.EventHandler(this.btnMetadata_Click);
            // 
            // btnModifyFeedback
            // 
            this.btnModifyFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifyFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnModifyFeedback.Location = new System.Drawing.Point(1101, 304);
            this.btnModifyFeedback.Name = "btnModifyFeedback";
            this.btnModifyFeedback.Size = new System.Drawing.Size(142, 43);
            this.btnModifyFeedback.TabIndex = 112;
            this.btnModifyFeedback.Text = "Modify Feedback";
            this.btnModifyFeedback.UseVisualStyleBackColor = true;
            this.btnModifyFeedback.Click += new System.EventHandler(this.btnModifyFeedback_Click);
            // 
            // lblRecivedDate
            // 
            this.lblRecivedDate.AutoSize = true;
            this.lblRecivedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblRecivedDate.Location = new System.Drawing.Point(170, 153);
            this.lblRecivedDate.Name = "lblRecivedDate";
            this.lblRecivedDate.Size = new System.Drawing.Size(100, 18);
            this.lblRecivedDate.TabIndex = 117;
            this.lblRecivedDate.Text = "Recived Date:";
            // 
            // btnFind
            // 
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFind.Location = new System.Drawing.Point(504, 84);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 35);
            this.btnFind.TabIndex = 109;
            this.btnFind.Text = "Find Xmitted";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblShipment
            // 
            this.lblShipment.AutoSize = true;
            this.lblShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblShipment.Location = new System.Drawing.Point(196, 74);
            this.lblShipment.Name = "lblShipment";
            this.lblShipment.Size = new System.Drawing.Size(74, 18);
            this.lblShipment.TabIndex = 115;
            this.lblShipment.Text = "Shipment:";
            // 
            // lblbFormat
            // 
            this.lblbFormat.AutoSize = true;
            this.lblbFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblbFormat.Location = new System.Drawing.Point(852, 113);
            this.lblbFormat.Name = "lblbFormat";
            this.lblbFormat.Size = new System.Drawing.Size(0, 18);
            this.lblbFormat.TabIndex = 134;
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblFormat.Location = new System.Drawing.Point(784, 113);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(60, 18);
            this.lblFormat.TabIndex = 133;
            this.lblFormat.Text = "Format:";
            // 
            // lbldAuditName
            // 
            this.lbldAuditName.AutoSize = true;
            this.lbldAuditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbldAuditName.Location = new System.Drawing.Point(852, 153);
            this.lbldAuditName.Name = "lbldAuditName";
            this.lbldAuditName.Size = new System.Drawing.Size(0, 18);
            this.lbldAuditName.TabIndex = 136;
            // 
            // lblAudiName
            // 
            this.lblAudiName.AutoSize = true;
            this.lblAudiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblAudiName.Location = new System.Drawing.Point(756, 153);
            this.lblAudiName.Name = "lblAudiName";
            this.lblAudiName.Size = new System.Drawing.Size(88, 18);
            this.lblAudiName.TabIndex = 135;
            this.lblAudiName.Text = "Audit Name:";
            // 
            // frm_FeedbackHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1251, 594);
            this.Controls.Add(this.lbldAuditName);
            this.Controls.Add(this.lblAudiName);
            this.Controls.Add(this.lblbFormat);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.btnReturnFile);
            this.Controls.Add(this.dataGridViewFeedbackFile);
            this.Controls.Add(this.lblUTeam);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.lbldRecivedDate);
            this.Controls.Add(this.lbldXmittedDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFeedbackDone);
            this.Controls.Add(this.lblPendingFeedback);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblXmittedDate);
            this.Controls.Add(this.dataGridXmittedFiles);
            this.Controls.Add(this.cmbShipment);
            this.Controls.Add(this.cmbPISBN);
            this.Controls.Add(this.lblPISBN);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label_QRProcess);
            this.Controls.Add(this.btnAddFeedBack);
            this.Controls.Add(this.btnModifyFeedback);
            this.Controls.Add(this.lblRecivedDate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblShipment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_FeedbackHandle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feedback Tracking";
            this.Load += new System.EventHandler(this.frm_FeedbackHandle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFeedbackFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXmittedFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyFiles;
        private System.Windows.Forms.Button btnReturnFile;
        private System.Windows.Forms.DataGridView dataGridViewFeedbackFile;
        private System.Windows.Forms.Label lblUTeam;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lbldRecivedDate;
        private System.Windows.Forms.Label lbldXmittedDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFeedbackDone;
        private System.Windows.Forms.Label lblPendingFeedback;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblXmittedDate;
        private System.Windows.Forms.DataGridView dataGridXmittedFiles;
        private System.Windows.Forms.ComboBox cmbShipment;
        private System.Windows.Forms.ComboBox cmbPISBN;
        private System.Windows.Forms.Label lblPISBN;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label_QRProcess;
        private System.Windows.Forms.Button btnAddFeedBack;
        private System.Windows.Forms.Button btnModifyFeedback;
        private System.Windows.Forms.Label lblRecivedDate;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblShipment;
        private System.Windows.Forms.Label lblbFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lbldAuditName;
        private System.Windows.Forms.Label lblAudiName;
    }
}
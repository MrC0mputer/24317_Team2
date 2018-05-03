﻿namespace MaintenanceTracker
{
    partial class MPGOptionsForm
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
            this.btnEnterMpg = new System.Windows.Forms.Button();
            this.lblOdometer = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.txtbxOdoRead = new System.Windows.Forms.TextBox();
            this.txtbxGallonsRead = new System.Windows.Forms.TextBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.dgTrack = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExitMpg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterMpg
            // 
            this.btnEnterMpg.Location = new System.Drawing.Point(92, 96);
            this.btnEnterMpg.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterMpg.Name = "btnEnterMpg";
            this.btnEnterMpg.Size = new System.Drawing.Size(83, 34);
            this.btnEnterMpg.TabIndex = 0;
            this.btnEnterMpg.Text = "Enter MPG";
            this.btnEnterMpg.UseVisualStyleBackColor = true;
            this.btnEnterMpg.Click += new System.EventHandler(this.btnEnterMpg_Click);
            // 
            // lblOdometer
            // 
            this.lblOdometer.AutoSize = true;
            this.lblOdometer.Location = new System.Drawing.Point(22, 41);
            this.lblOdometer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdometer.Name = "lblOdometer";
            this.lblOdometer.Size = new System.Drawing.Size(91, 13);
            this.lblOdometer.TabIndex = 1;
            this.lblOdometer.Text = "Odometer reading";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(160, 41);
            this.lblGallons.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(66, 13);
            this.lblGallons.TabIndex = 2;
            this.lblGallons.Text = "Gallons filled";
            // 
            // txtbxOdoRead
            // 
            this.txtbxOdoRead.Location = new System.Drawing.Point(24, 62);
            this.txtbxOdoRead.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxOdoRead.Name = "txtbxOdoRead";
            this.txtbxOdoRead.Size = new System.Drawing.Size(85, 20);
            this.txtbxOdoRead.TabIndex = 3;
            // 
            // txtbxGallonsRead
            // 
            this.txtbxGallonsRead.Location = new System.Drawing.Point(150, 61);
            this.txtbxGallonsRead.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxGallonsRead.Name = "txtbxGallonsRead";
            this.txtbxGallonsRead.Size = new System.Drawing.Size(85, 20);
            this.txtbxGallonsRead.TabIndex = 4;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.Location = new System.Drawing.Point(22, 41);
            this.lblAlert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 13);
            this.lblAlert.TabIndex = 10;
            // 
            // dgTrack
            // 
            this.dgTrack.AllowUserToDeleteRows = false;
            this.dgTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgTrack.Location = new System.Drawing.Point(7, 134);
            this.dgTrack.Margin = new System.Windows.Forms.Padding(2);
            this.dgTrack.Name = "dgTrack";
            this.dgTrack.ReadOnly = true;
            this.dgTrack.RowTemplate.Height = 24;
            this.dgTrack.Size = new System.Drawing.Size(254, 244);
            this.dgTrack.TabIndex = 11;
            // 
            // date
            // 
            this.date.HeaderText = "DATE";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.date.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MPG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ODO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GAL";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // btnExitMpg
            // 
            this.btnExitMpg.Location = new System.Drawing.Point(105, 393);
            this.btnExitMpg.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitMpg.Name = "btnExitMpg";
            this.btnExitMpg.Size = new System.Drawing.Size(57, 31);
            this.btnExitMpg.TabIndex = 12;
            this.btnExitMpg.Text = "Exit MPG";
            this.btnExitMpg.UseVisualStyleBackColor = true;
            this.btnExitMpg.Click += new System.EventHandler(this.btnExitMpg_Click);
            // 
            // MPGOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 434);
            this.ControlBox = false;
            this.Controls.Add(this.btnExitMpg);
            this.Controls.Add(this.dgTrack);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.txtbxGallonsRead);
            this.Controls.Add(this.txtbxOdoRead);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblOdometer);
            this.Controls.Add(this.btnEnterMpg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MPGOptionsForm";
            this.Text = "MPGOptionsForm";
            this.Load += new System.EventHandler(this.MPGOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterMpg;
        private System.Windows.Forms.Label lblOdometer;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.TextBox txtbxOdoRead;
        private System.Windows.Forms.TextBox txtbxGallonsRead;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnExitMpg;
        public System.Windows.Forms.DataGridView dgTrack;
    }
}
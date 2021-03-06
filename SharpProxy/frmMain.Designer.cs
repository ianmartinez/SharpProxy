﻿namespace SharpProxy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExternalPort = new System.Windows.Forms.TextBox();
            this.txtInternalPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbIPAddress = new System.Windows.Forms.ComboBox();
            this.chkRewriteHostHeaders = new System.Windows.Forms.CheckBox();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 237);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(188, 237);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(112, 35);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "External Port";
            // 
            // txtExternalPort
            // 
            this.txtExternalPort.Location = new System.Drawing.Point(16, 100);
            this.txtExternalPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtExternalPort.MaxLength = 7;
            this.txtExternalPort.Name = "txtExternalPort";
            this.txtExternalPort.Size = new System.Drawing.Size(282, 26);
            this.txtExternalPort.TabIndex = 3;
            this.txtExternalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorts_KeyPress);
            // 
            // txtInternalPort
            // 
            this.txtInternalPort.Location = new System.Drawing.Point(16, 160);
            this.txtInternalPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInternalPort.MaxLength = 7;
            this.txtInternalPort.Name = "txtInternalPort";
            this.txtInternalPort.Size = new System.Drawing.Size(282, 26);
            this.txtInternalPort.TabIndex = 5;
            this.txtInternalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorts_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Internal Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Your IP Address";
            // 
            // cmbIPAddress
            // 
            this.cmbIPAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIPAddress.FormattingEnabled = true;
            this.cmbIPAddress.Location = new System.Drawing.Point(16, 38);
            this.cmbIPAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIPAddress.Name = "cmbIPAddress";
            this.cmbIPAddress.Size = new System.Drawing.Size(282, 28);
            this.cmbIPAddress.TabIndex = 8;
            this.cmbIPAddress.SelectedIndexChanged += new System.EventHandler(this.cmbIPAddress_SelectedIndexChanged);
            // 
            // chkRewriteHostHeaders
            // 
            this.chkRewriteHostHeaders.AutoSize = true;
            this.chkRewriteHostHeaders.Checked = true;
            this.chkRewriteHostHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRewriteHostHeaders.Location = new System.Drawing.Point(20, 202);
            this.chkRewriteHostHeaders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRewriteHostHeaders.Name = "chkRewriteHostHeaders";
            this.chkRewriteHostHeaders.Size = new System.Drawing.Size(282, 24);
            this.chkRewriteHostHeaders.TabIndex = 9;
            this.chkRewriteHostHeaders.Text = "&Rewrite host headers (IIS Express)";
            this.chkRewriteHostHeaders.UseVisualStyleBackColor = true;
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.Color.White;
            this.picQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRCode.Location = new System.Drawing.Point(324, 38);
            this.picQRCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(196, 200);
            this.picQRCode.TabIndex = 10;
            this.picQRCode.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "QR Code";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.chkRewriteHostHeaders);
            this.Controls.Add(this.cmbIPAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInternalPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExternalPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "SharpProxy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExternalPort;
        private System.Windows.Forms.TextBox txtInternalPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbIPAddress;
        private System.Windows.Forms.CheckBox chkRewriteHostHeaders;
        private System.Windows.Forms.PictureBox picQRCode;
        private System.Windows.Forms.Label label4;
    }
}


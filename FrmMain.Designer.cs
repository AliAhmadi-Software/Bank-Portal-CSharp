namespace KicccIngenicoTestClient
{
    partial class FrmMain
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
            this.gBoxSettings = new System.Windows.Forms.GroupBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.btnInitiate = new System.Windows.Forms.Button();
            this.txtTerminal = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.txtAcceptor = new System.Windows.Forms.TextBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.lblAcceptorId = new System.Windows.Forms.Label();
            this.lblTerminalId = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.gBoxSyncMethods = new System.Windows.Forms.GroupBox();
            this.btnSaleWithPaymentId = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.gBoxAsyncMethods = new System.Windows.Forms.GroupBox();
            this.btnAsyncSaleWithPaymentId = new System.Windows.Forms.Button();
            this.btnAsyncSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymrntId = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gBoxMultiplex = new System.Windows.Forms.GroupBox();
            this.btnRemoveAmount = new System.Windows.Forms.Button();
            this.lstAmounts = new System.Windows.Forms.ListView();
            this.Col01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMultiAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPeriodCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYearCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeqCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrgCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSrvCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMultiPaymentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsyncMultiplexSale = new System.Windows.Forms.Button();
            this.btnAddAmount = new System.Windows.Forms.Button();
            this.btnMultiplexSale = new System.Windows.Forms.Button();
            this.gBoxSettings.SuspendLayout();
            this.gBoxSyncMethods.SuspendLayout();
            this.gBoxAsyncMethods.SuspendLayout();
            this.gBoxMultiplex.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxSettings
            // 
            this.gBoxSettings.Controls.Add(this.cmbCom);
            this.gBoxSettings.Controls.Add(this.btnReset);
            this.gBoxSettings.Controls.Add(this.btnTerminate);
            this.gBoxSettings.Controls.Add(this.btnInitiate);
            this.gBoxSettings.Controls.Add(this.txtTerminal);
            this.gBoxSettings.Controls.Add(this.txtSerial);
            this.gBoxSettings.Controls.Add(this.txtAcceptor);
            this.gBoxSettings.Controls.Add(this.lblComPort);
            this.gBoxSettings.Controls.Add(this.lblAcceptorId);
            this.gBoxSettings.Controls.Add(this.lblTerminalId);
            this.gBoxSettings.Controls.Add(this.lblSerialNo);
            this.gBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.gBoxSettings.Name = "gBoxSettings";
            this.gBoxSettings.Size = new System.Drawing.Size(539, 99);
            this.gBoxSettings.TabIndex = 0;
            this.gBoxSettings.TabStop = false;
            this.gBoxSettings.Text = "Settings";
            // 
            // cmbCom
            // 
            this.cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(353, 39);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(134, 21);
            this.cmbCom.TabIndex = 3;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(371, 65);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(126, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Enabled = false;
            this.btnTerminate.Location = new System.Drawing.Point(239, 65);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(126, 23);
            this.btnTerminate.TabIndex = 0;
            this.btnTerminate.Text = "Terminalte";
            this.btnTerminate.UseVisualStyleBackColor = true;
            // 
            // btnInitiate
            // 
            this.btnInitiate.Location = new System.Drawing.Point(107, 65);
            this.btnInitiate.Name = "btnInitiate";
            this.btnInitiate.Size = new System.Drawing.Size(126, 23);
            this.btnInitiate.TabIndex = 0;
            this.btnInitiate.Text = "Initiate";
            this.btnInitiate.UseVisualStyleBackColor = true;
            // 
            // txtTerminal
            // 
            this.txtTerminal.Location = new System.Drawing.Point(116, 39);
            this.txtTerminal.Name = "txtTerminal";
            this.txtTerminal.Size = new System.Drawing.Size(135, 20);
            this.txtTerminal.TabIndex = 2;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(116, 13);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(135, 20);
            this.txtSerial.TabIndex = 2;
            // 
            // txtAcceptor
            // 
            this.txtAcceptor.Location = new System.Drawing.Point(353, 13);
            this.txtAcceptor.Name = "txtAcceptor";
            this.txtAcceptor.Size = new System.Drawing.Size(134, 20);
            this.txtAcceptor.TabIndex = 2;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(291, 42);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(56, 13);
            this.lblComPort.TabIndex = 1;
            this.lblComPort.Text = "Com Port :";
            // 
            // lblAcceptorId
            // 
            this.lblAcceptorId.AutoSize = true;
            this.lblAcceptorId.Location = new System.Drawing.Point(279, 16);
            this.lblAcceptorId.Name = "lblAcceptorId";
            this.lblAcceptorId.Size = new System.Drawing.Size(68, 13);
            this.lblAcceptorId.TabIndex = 1;
            this.lblAcceptorId.Text = "Acceptor Id :";
            // 
            // lblTerminalId
            // 
            this.lblTerminalId.AutoSize = true;
            this.lblTerminalId.Location = new System.Drawing.Point(45, 42);
            this.lblTerminalId.Name = "lblTerminalId";
            this.lblTerminalId.Size = new System.Drawing.Size(65, 13);
            this.lblTerminalId.TabIndex = 1;
            this.lblTerminalId.Text = "Terminal Id :";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(54, 16);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(56, 13);
            this.lblSerialNo.TabIndex = 0;
            this.lblSerialNo.Text = "Serial No :";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(73, 120);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount :";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(128, 117);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 20);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.Text = "1000";
            // 
            // gBoxSyncMethods
            // 
            this.gBoxSyncMethods.Controls.Add(this.btnSaleWithPaymentId);
            this.gBoxSyncMethods.Controls.Add(this.btnSale);
            this.gBoxSyncMethods.Enabled = false;
            this.gBoxSyncMethods.Location = new System.Drawing.Point(12, 143);
            this.gBoxSyncMethods.Name = "gBoxSyncMethods";
            this.gBoxSyncMethods.Size = new System.Drawing.Size(251, 80);
            this.gBoxSyncMethods.TabIndex = 3;
            this.gBoxSyncMethods.TabStop = false;
            this.gBoxSyncMethods.Text = "Sync Methods";
            // 
            // btnSaleWithPaymentId
            // 
            this.btnSaleWithPaymentId.Location = new System.Drawing.Point(57, 48);
            this.btnSaleWithPaymentId.Name = "btnSaleWithPaymentId";
            this.btnSaleWithPaymentId.Size = new System.Drawing.Size(134, 23);
            this.btnSaleWithPaymentId.TabIndex = 0;
            this.btnSaleWithPaymentId.Text = "Sale With PaymentId";
            this.btnSaleWithPaymentId.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(57, 19);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(134, 23);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // gBoxAsyncMethods
            // 
            this.gBoxAsyncMethods.Controls.Add(this.btnAsyncSaleWithPaymentId);
            this.gBoxAsyncMethods.Controls.Add(this.btnAsyncSale);
            this.gBoxAsyncMethods.Enabled = false;
            this.gBoxAsyncMethods.Location = new System.Drawing.Point(300, 143);
            this.gBoxAsyncMethods.Name = "gBoxAsyncMethods";
            this.gBoxAsyncMethods.Size = new System.Drawing.Size(251, 80);
            this.gBoxAsyncMethods.TabIndex = 3;
            this.gBoxAsyncMethods.TabStop = false;
            this.gBoxAsyncMethods.Text = "Async Methods";
            // 
            // btnAsyncSaleWithPaymentId
            // 
            this.btnAsyncSaleWithPaymentId.Location = new System.Drawing.Point(65, 48);
            this.btnAsyncSaleWithPaymentId.Name = "btnAsyncSaleWithPaymentId";
            this.btnAsyncSaleWithPaymentId.Size = new System.Drawing.Size(126, 23);
            this.btnAsyncSaleWithPaymentId.TabIndex = 0;
            this.btnAsyncSaleWithPaymentId.Text = "Sale With PaymentId";
            this.btnAsyncSaleWithPaymentId.UseVisualStyleBackColor = true;
            // 
            // btnAsyncSale
            // 
            this.btnAsyncSale.Location = new System.Drawing.Point(65, 19);
            this.btnAsyncSale.Name = "btnAsyncSale";
            this.btnAsyncSale.Size = new System.Drawing.Size(126, 23);
            this.btnAsyncSale.TabIndex = 0;
            this.btnAsyncSale.Text = "Sale";
            this.btnAsyncSale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payment Id :";
            // 
            // txtPaymrntId
            // 
            this.txtPaymrntId.Location = new System.Drawing.Point(365, 117);
            this.txtPaymrntId.Name = "txtPaymrntId";
            this.txtPaymrntId.Size = new System.Drawing.Size(135, 20);
            this.txtPaymrntId.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 229);
            this.progressBar1.MarqueeAnimationSpeed = 20;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(539, 25);
            this.progressBar1.TabIndex = 4;
            // 
            // gBoxMultiplex
            // 
            this.gBoxMultiplex.Controls.Add(this.btnRemoveAmount);
            this.gBoxMultiplex.Controls.Add(this.lstAmounts);
            this.gBoxMultiplex.Controls.Add(this.txtMultiAmount);
            this.gBoxMultiplex.Controls.Add(this.label8);
            this.gBoxMultiplex.Controls.Add(this.txtBankCode);
            this.gBoxMultiplex.Controls.Add(this.label9);
            this.gBoxMultiplex.Controls.Add(this.txtPeriodCode);
            this.gBoxMultiplex.Controls.Add(this.label7);
            this.gBoxMultiplex.Controls.Add(this.txtYearCode);
            this.gBoxMultiplex.Controls.Add(this.label6);
            this.gBoxMultiplex.Controls.Add(this.txtSeqCode);
            this.gBoxMultiplex.Controls.Add(this.label5);
            this.gBoxMultiplex.Controls.Add(this.txtOrgCode);
            this.gBoxMultiplex.Controls.Add(this.label4);
            this.gBoxMultiplex.Controls.Add(this.txtSrvCode);
            this.gBoxMultiplex.Controls.Add(this.label3);
            this.gBoxMultiplex.Controls.Add(this.txtMultiPaymentId);
            this.gBoxMultiplex.Controls.Add(this.label2);
            this.gBoxMultiplex.Controls.Add(this.btnAsyncMultiplexSale);
            this.gBoxMultiplex.Controls.Add(this.btnAddAmount);
            this.gBoxMultiplex.Controls.Add(this.btnMultiplexSale);
            this.gBoxMultiplex.Enabled = false;
            this.gBoxMultiplex.Location = new System.Drawing.Point(12, 260);
            this.gBoxMultiplex.Name = "gBoxMultiplex";
            this.gBoxMultiplex.Size = new System.Drawing.Size(539, 268);
            this.gBoxMultiplex.TabIndex = 5;
            this.gBoxMultiplex.TabStop = false;
            this.gBoxMultiplex.Text = "Multiplex Payment";
            // 
            // btnRemoveAmount
            // 
            this.btnRemoveAmount.Location = new System.Drawing.Point(461, 172);
            this.btnRemoveAmount.Name = "btnRemoveAmount";
            this.btnRemoveAmount.Size = new System.Drawing.Size(26, 23);
            this.btnRemoveAmount.TabIndex = 16;
            this.btnRemoveAmount.Text = "-";
            this.btnRemoveAmount.UseVisualStyleBackColor = true;
            // 
            // lstAmounts
            // 
            this.lstAmounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col01,
            this.Col02});
            this.lstAmounts.GridLines = true;
            this.lstAmounts.Location = new System.Drawing.Point(294, 19);
            this.lstAmounts.Name = "lstAmounts";
            this.lstAmounts.Size = new System.Drawing.Size(193, 150);
            this.lstAmounts.TabIndex = 15;
            this.lstAmounts.UseCompatibleStateImageBehavior = false;
            this.lstAmounts.View = System.Windows.Forms.View.Details;
            // 
            // Col01
            // 
            this.Col01.Text = "عنوان";
            // 
            // Col02
            // 
            this.Col02.Text = "مبلغ";
            this.Col02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Col02.Width = 100;
            // 
            // txtMultiAmount
            // 
            this.txtMultiAmount.Location = new System.Drawing.Point(346, 174);
            this.txtMultiAmount.Name = "txtMultiAmount";
            this.txtMultiAmount.Size = new System.Drawing.Size(77, 20);
            this.txtMultiAmount.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Amount :";
            // 
            // txtBankCode
            // 
            this.txtBankCode.Location = new System.Drawing.Point(116, 174);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(135, 20);
            this.txtBankCode.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Bank Code :";
            // 
            // txtPeriodCode
            // 
            this.txtPeriodCode.Location = new System.Drawing.Point(116, 149);
            this.txtPeriodCode.Name = "txtPeriodCode";
            this.txtPeriodCode.Size = new System.Drawing.Size(135, 20);
            this.txtPeriodCode.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fiscal Period :";
            // 
            // txtYearCode
            // 
            this.txtYearCode.Location = new System.Drawing.Point(116, 123);
            this.txtYearCode.Name = "txtYearCode";
            this.txtYearCode.Size = new System.Drawing.Size(135, 20);
            this.txtYearCode.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Financial Year :";
            // 
            // txtSeqCode
            // 
            this.txtSeqCode.Location = new System.Drawing.Point(116, 97);
            this.txtSeqCode.Name = "txtSeqCode";
            this.txtSeqCode.Size = new System.Drawing.Size(135, 20);
            this.txtSeqCode.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sequence Code  :";
            // 
            // txtOrgCode
            // 
            this.txtOrgCode.Location = new System.Drawing.Point(116, 45);
            this.txtOrgCode.Name = "txtOrgCode";
            this.txtOrgCode.Size = new System.Drawing.Size(135, 20);
            this.txtOrgCode.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Organization Code :";
            // 
            // txtSrvCode
            // 
            this.txtSrvCode.Location = new System.Drawing.Point(116, 71);
            this.txtSrvCode.Name = "txtSrvCode";
            this.txtSrvCode.Size = new System.Drawing.Size(135, 20);
            this.txtSrvCode.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ServiceCode :";
            // 
            // txtMultiPaymentId
            // 
            this.txtMultiPaymentId.Location = new System.Drawing.Point(116, 19);
            this.txtMultiPaymentId.Name = "txtMultiPaymentId";
            this.txtMultiPaymentId.Size = new System.Drawing.Size(135, 20);
            this.txtMultiPaymentId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Payment Id :";
            // 
            // btnAsyncMultiplexSale
            // 
            this.btnAsyncMultiplexSale.Location = new System.Drawing.Point(353, 210);
            this.btnAsyncMultiplexSale.Name = "btnAsyncMultiplexSale";
            this.btnAsyncMultiplexSale.Size = new System.Drawing.Size(126, 23);
            this.btnAsyncMultiplexSale.TabIndex = 0;
            this.btnAsyncMultiplexSale.Text = "Async Multiplex Sale";
            this.btnAsyncMultiplexSale.UseVisualStyleBackColor = true;
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.Location = new System.Drawing.Point(429, 172);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(26, 23);
            this.btnAddAmount.TabIndex = 0;
            this.btnAddAmount.Text = "+";
            this.btnAddAmount.UseVisualStyleBackColor = true;
            // 
            // btnMultiplexSale
            // 
            this.btnMultiplexSale.Location = new System.Drawing.Point(353, 239);
            this.btnMultiplexSale.Name = "btnMultiplexSale";
            this.btnMultiplexSale.Size = new System.Drawing.Size(126, 23);
            this.btnMultiplexSale.TabIndex = 0;
            this.btnMultiplexSale.Text = "Multiplex Sale";
            this.btnMultiplexSale.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 540);
            this.Controls.Add(this.gBoxMultiplex);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gBoxAsyncMethods);
            this.Controls.Add(this.gBoxSyncMethods);
            this.Controls.Add(this.txtPaymrntId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.gBoxSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiccc Ingenico Test Client";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gBoxSettings.ResumeLayout(false);
            this.gBoxSettings.PerformLayout();
            this.gBoxSyncMethods.ResumeLayout(false);
            this.gBoxAsyncMethods.ResumeLayout(false);
            this.gBoxMultiplex.ResumeLayout(false);
            this.gBoxMultiplex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxSettings;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.TextBox txtTerminal;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.TextBox txtAcceptor;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Label lblAcceptorId;
        private System.Windows.Forms.Label lblTerminalId;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.GroupBox gBoxSyncMethods;
        private System.Windows.Forms.Button btnSaleWithPaymentId;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.GroupBox gBoxAsyncMethods;
        private System.Windows.Forms.Button btnAsyncSaleWithPaymentId;
        private System.Windows.Forms.Button btnAsyncSale;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Button btnInitiate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaymrntId;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox gBoxMultiplex;
        private System.Windows.Forms.Button btnAsyncMultiplexSale;
        private System.Windows.Forms.Button btnMultiplexSale;
        private System.Windows.Forms.Button btnRemoveAmount;
        private System.Windows.Forms.ListView lstAmounts;
        private System.Windows.Forms.ColumnHeader Col01;
        private System.Windows.Forms.ColumnHeader Col02;
        private System.Windows.Forms.TextBox txtMultiAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeriodCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYearCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeqCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrgCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSrvCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMultiPaymentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAmount;
    }
}


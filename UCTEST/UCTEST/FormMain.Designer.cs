namespace UCTEST
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxOPCServerSettings = new System.Windows.Forms.GroupBox();
            this.buttonOPCSave = new System.Windows.Forms.Button();
            this.labelServerIdentifier = new System.Windows.Forms.Label();
            this.labelPortNumber = new System.Windows.Forms.Label();
            this.labelHostName = new System.Windows.Forms.Label();
            this.textBoxServerIdentifier = new System.Windows.Forms.TextBox();
            this.textBoxPortNumber = new System.Windows.Forms.TextBox();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.buttonOPCConnect = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelOPCConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.OPC4 = new UCTEST.UCOPCIndicator();
            this.OPC3 = new UCTEST.UCOPCIndicator();
            this.OPC2 = new UCTEST.UCOPCIndicator();
            this.OPC1 = new UCTEST.UCOPCIndicator();
            this.ucopcIndicator1 = new UCTEST.UCOPCIndicator();
            this.groupBoxOPCServerSettings.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(507, 439);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 439);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBoxOPCServerSettings
            // 
            this.groupBoxOPCServerSettings.Controls.Add(this.buttonOPCSave);
            this.groupBoxOPCServerSettings.Controls.Add(this.labelServerIdentifier);
            this.groupBoxOPCServerSettings.Controls.Add(this.labelPortNumber);
            this.groupBoxOPCServerSettings.Controls.Add(this.labelHostName);
            this.groupBoxOPCServerSettings.Controls.Add(this.textBoxServerIdentifier);
            this.groupBoxOPCServerSettings.Controls.Add(this.textBoxPortNumber);
            this.groupBoxOPCServerSettings.Controls.Add(this.textBoxHostName);
            this.groupBoxOPCServerSettings.Controls.Add(this.buttonOPCConnect);
            this.groupBoxOPCServerSettings.Location = new System.Drawing.Point(12, 182);
            this.groupBoxOPCServerSettings.Name = "groupBoxOPCServerSettings";
            this.groupBoxOPCServerSettings.Size = new System.Drawing.Size(570, 96);
            this.groupBoxOPCServerSettings.TabIndex = 11;
            this.groupBoxOPCServerSettings.TabStop = false;
            this.groupBoxOPCServerSettings.Text = "OPC Server Settings";
            // 
            // buttonOPCSave
            // 
            this.buttonOPCSave.Location = new System.Drawing.Point(311, 64);
            this.buttonOPCSave.Name = "buttonOPCSave";
            this.buttonOPCSave.Size = new System.Drawing.Size(76, 23);
            this.buttonOPCSave.TabIndex = 8;
            this.buttonOPCSave.Text = "SAVE";
            this.buttonOPCSave.UseVisualStyleBackColor = true;
            this.buttonOPCSave.Click += new System.EventHandler(this.buttonOPCSave_Click);
            // 
            // labelServerIdentifier
            // 
            this.labelServerIdentifier.AutoSize = true;
            this.labelServerIdentifier.Location = new System.Drawing.Point(203, 22);
            this.labelServerIdentifier.Name = "labelServerIdentifier";
            this.labelServerIdentifier.Size = new System.Drawing.Size(81, 13);
            this.labelServerIdentifier.TabIndex = 6;
            this.labelServerIdentifier.Text = "Server Identifier";
            // 
            // labelPortNumber
            // 
            this.labelPortNumber.AutoSize = true;
            this.labelPortNumber.Location = new System.Drawing.Point(122, 22);
            this.labelPortNumber.Name = "labelPortNumber";
            this.labelPortNumber.Size = new System.Drawing.Size(66, 13);
            this.labelPortNumber.TabIndex = 5;
            this.labelPortNumber.Text = "Port Number";
            // 
            // labelHostName
            // 
            this.labelHostName.AutoSize = true;
            this.labelHostName.Location = new System.Drawing.Point(16, 22);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(60, 13);
            this.labelHostName.TabIndex = 4;
            this.labelHostName.Text = "Host Name";
            // 
            // textBoxServerIdentifier
            // 
            this.textBoxServerIdentifier.Location = new System.Drawing.Point(205, 38);
            this.textBoxServerIdentifier.Name = "textBoxServerIdentifier";
            this.textBoxServerIdentifier.Size = new System.Drawing.Size(355, 20);
            this.textBoxServerIdentifier.TabIndex = 3;
            // 
            // textBoxPortNumber
            // 
            this.textBoxPortNumber.Location = new System.Drawing.Point(125, 38);
            this.textBoxPortNumber.Name = "textBoxPortNumber";
            this.textBoxPortNumber.Size = new System.Drawing.Size(75, 20);
            this.textBoxPortNumber.TabIndex = 2;
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Location = new System.Drawing.Point(19, 38);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(100, 20);
            this.textBoxHostName.TabIndex = 1;
            // 
            // buttonOPCConnect
            // 
            this.buttonOPCConnect.Location = new System.Drawing.Point(393, 64);
            this.buttonOPCConnect.Name = "buttonOPCConnect";
            this.buttonOPCConnect.Size = new System.Drawing.Size(167, 23);
            this.buttonOPCConnect.TabIndex = 0;
            this.buttonOPCConnect.Text = "CONNECT";
            this.buttonOPCConnect.UseVisualStyleBackColor = true;
            this.buttonOPCConnect.Click += new System.EventHandler(this.buttonOPCConnect_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelOPCConnection});
            this.statusStripMain.Location = new System.Drawing.Point(0, 488);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(594, 22);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 12;
            this.statusStripMain.Text = "statusStrip1";
            this.statusStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStripMain_ItemClicked);
            // 
            // toolStripStatusLabelOPCConnection
            // 
            this.toolStripStatusLabelOPCConnection.Name = "toolStripStatusLabelOPCConnection";
            this.toolStripStatusLabelOPCConnection.Size = new System.Drawing.Size(99, 17);
            this.toolStripStatusLabelOPCConnection.Text = "OPC: UNKNOWN";
            this.toolStripStatusLabelOPCConnection.Click += new System.EventHandler(this.toolStripStatusLabelOPCConnection_Click);
            // 
            // OPC4
            // 
            this.OPC4.INFO = "";
            this.OPC4.Location = new System.Drawing.Point(393, 15);
            this.OPC4.Name = "OPC4";
            this.OPC4.RAMP = 0D;
            this.OPC4.RAND = 0D;
            this.OPC4.SINE = 0D;
            this.OPC4.Size = new System.Drawing.Size(121, 161);
            this.OPC4.TabIndex = 9;
            // 
            // OPC3
            // 
            this.OPC3.INFO = "";
            this.OPC3.Location = new System.Drawing.Point(266, 12);
            this.OPC3.Name = "OPC3";
            this.OPC3.RAMP = 0D;
            this.OPC3.RAND = 0D;
            this.OPC3.SINE = 0D;
            this.OPC3.Size = new System.Drawing.Size(121, 164);
            this.OPC3.TabIndex = 7;
            // 
            // OPC2
            // 
            this.OPC2.INFO = "";
            this.OPC2.Location = new System.Drawing.Point(139, 12);
            this.OPC2.Name = "OPC2";
            this.OPC2.RAMP = 0D;
            this.OPC2.RAND = 0D;
            this.OPC2.SINE = 0D;
            this.OPC2.Size = new System.Drawing.Size(121, 164);
            this.OPC2.TabIndex = 6;
            // 
            // OPC1
            // 
            this.OPC1.INFO = "";
            this.OPC1.Location = new System.Drawing.Point(12, 12);
            this.OPC1.Name = "OPC1";
            this.OPC1.RAMP = 0D;
            this.OPC1.RAND = 0D;
            this.OPC1.SINE = 0D;
            this.OPC1.Size = new System.Drawing.Size(121, 164);
            this.OPC1.TabIndex = 5;
            this.OPC1.Load += new System.EventHandler(this.OPC1_Load);
            // 
            // ucopcIndicator1
            // 
            this.ucopcIndicator1.INFO = "";
            this.ucopcIndicator1.Location = new System.Drawing.Point(31, 23);
            this.ucopcIndicator1.Name = "ucopcIndicator1";
            this.ucopcIndicator1.RAMP = 0D;
            this.ucopcIndicator1.RAND = 0D;
            this.ucopcIndicator1.SINE = 0D;
            this.ucopcIndicator1.Size = new System.Drawing.Size(8, 8);
            this.ucopcIndicator1.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 510);
            this.Controls.Add(this.ucopcIndicator1);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.groupBoxOPCServerSettings);
            this.Controls.Add(this.OPC4);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.OPC3);
            this.Controls.Add(this.OPC2);
            this.Controls.Add(this.OPC1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormMain";
            this.Text = "UserCompDemo";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxOPCServerSettings.ResumeLayout(false);
            this.groupBoxOPCServerSettings.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private UCOPCIndicator OPC1;
        private UCOPCIndicator OPC2;
        private UCOPCIndicator OPC3;
        private System.Windows.Forms.Button buttonOK;
        private UCOPCIndicator OPC4;
        private System.Windows.Forms.GroupBox groupBoxOPCServerSettings;
        private System.Windows.Forms.Button buttonOPCSave;
        private System.Windows.Forms.Label labelServerIdentifier;
        private System.Windows.Forms.Label labelPortNumber;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.TextBox textBoxServerIdentifier;
        private System.Windows.Forms.TextBox textBoxPortNumber;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.Button buttonOPCConnect;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOPCConnection;
        private UCOPCIndicator ucopcIndicator1;
    }
}


namespace Port_File_Transfer
{
    partial class Port_File_Transfer
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
            this.txtsend = new System.Windows.Forms.TextBox();
            this.lblString = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.panelReceive = new System.Windows.Forms.Panel();
            this.btnReceive = new System.Windows.Forms.Button();
            this.lblRstring = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.panelSend = new System.Windows.Forms.Panel();
            this.lblSend = new System.Windows.Forms.Label();
            this.lblReceive = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.cbrts = new System.Windows.Forms.CheckBox();
            this.cbdtr = new System.Windows.Forms.CheckBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxon = new System.Windows.Forms.CheckBox();
            this.cbrtscts = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStopbits = new System.Windows.Forms.ComboBox();
            this.txtParity = new System.Windows.Forms.ComboBox();
            this.txtDatabits = new System.Windows.Forms.ComboBox();
            this.txtBrate = new System.Windows.Forms.ComboBox();
            this.lblStopbits = new System.Windows.Forms.Label();
            this.lblDatabits = new System.Windows.Forms.Label();
            this.lblParity = new System.Windows.Forms.Label();
            this.lblBrate = new System.Windows.Forms.Label();
            this.txtComports = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.panelReceive.SuspendLayout();
            this.panelSend.SuspendLayout();
            this.panelSetting.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsend
            // 
            this.txtsend.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsend.Location = new System.Drawing.Point(46, 78);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.Size = new System.Drawing.Size(426, 189);
            this.txtsend.TabIndex = 0;
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString.Location = new System.Drawing.Point(43, 17);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(197, 18);
            this.lblString.TabIndex = 1;
            this.lblString.Text = "Enter The Message Here :";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(170, 323);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(177, 35);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panelReceive
            // 
            this.panelReceive.Controls.Add(this.btnReceive);
            this.panelReceive.Controls.Add(this.lblRstring);
            this.panelReceive.Controls.Add(this.txtReceive);
            this.panelReceive.Location = new System.Drawing.Point(2, 38);
            this.panelReceive.Name = "panelReceive";
            this.panelReceive.Size = new System.Drawing.Size(520, 397);
            this.panelReceive.TabIndex = 3;
            // 
            // btnReceive
            // 
            this.btnReceive.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(170, 323);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(177, 35);
            this.btnReceive.TabIndex = 5;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // lblRstring
            // 
            this.lblRstring.AutoSize = true;
            this.lblRstring.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRstring.Location = new System.Drawing.Point(43, 17);
            this.lblRstring.Name = "lblRstring";
            this.lblRstring.Size = new System.Drawing.Size(97, 18);
            this.lblRstring.TabIndex = 4;
            this.lblRstring.Text = "Message Is :";
            // 
            // txtReceive
            // 
            this.txtReceive.Enabled = false;
            this.txtReceive.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceive.Location = new System.Drawing.Point(46, 78);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(426, 189);
            this.txtReceive.TabIndex = 3;
            // 
            // panelSend
            // 
            this.panelSend.Controls.Add(this.btnSend);
            this.panelSend.Controls.Add(this.lblString);
            this.panelSend.Controls.Add(this.txtsend);
            this.panelSend.Location = new System.Drawing.Point(2, 38);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(520, 397);
            this.panelSend.TabIndex = 3;
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSend.Location = new System.Drawing.Point(219, 9);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(67, 23);
            this.lblSend.TabIndex = 4;
            this.lblSend.Text = "To Send";
            this.lblSend.Click += new System.EventHandler(this.lblSend_Click);
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceive.Location = new System.Drawing.Point(312, 9);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(82, 23);
            this.lblReceive.TabIndex = 5;
            this.lblReceive.Text = "To Receive";
            this.lblReceive.Click += new System.EventHandler(this.lblReceive_Click);
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.Location = new System.Drawing.Point(130, 9);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(70, 23);
            this.lblSetting.TabIndex = 6;
            this.lblSetting.Text = "Settings";
            this.lblSetting.Click += new System.EventHandler(this.lblSetting_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.Controls.Add(this.btnCancel);
            this.panelSetting.Controls.Add(this.btnOk);
            this.panelSetting.Controls.Add(this.GroupBox3);
            this.panelSetting.Controls.Add(this.GroupBox2);
            this.panelSetting.Controls.Add(this.GroupBox1);
            this.panelSetting.Location = new System.Drawing.Point(3, 35);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(519, 400);
            this.panelSetting.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(374, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(374, 58);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 25);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.cbrts);
            this.GroupBox3.Controls.Add(this.cbdtr);
            this.GroupBox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(339, 276);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(155, 100);
            this.GroupBox3.TabIndex = 7;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Output Status";
            // 
            // cbrts
            // 
            this.cbrts.AutoSize = true;
            this.cbrts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrts.Location = new System.Drawing.Point(12, 74);
            this.cbrts.Name = "cbrts";
            this.cbrts.Size = new System.Drawing.Size(49, 24);
            this.cbrts.TabIndex = 9;
            this.cbrts.Text = "RTS";
            this.cbrts.UseVisualStyleBackColor = true;
            // 
            // cbdtr
            // 
            this.cbdtr.AutoSize = true;
            this.cbdtr.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdtr.Location = new System.Drawing.Point(12, 33);
            this.cbdtr.Name = "cbdtr";
            this.cbdtr.Size = new System.Drawing.Size(53, 24);
            this.cbdtr.TabIndex = 8;
            this.cbdtr.Text = "DTR";
            this.cbdtr.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.cbxon);
            this.GroupBox2.Controls.Add(this.cbrtscts);
            this.GroupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(24, 276);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(256, 100);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Flow Control";
            // 
            // cbxon
            // 
            this.cbxon.AutoSize = true;
            this.cbxon.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxon.Location = new System.Drawing.Point(12, 74);
            this.cbxon.Name = "cbxon";
            this.cbxon.Size = new System.Drawing.Size(104, 24);
            this.cbxon.TabIndex = 7;
            this.cbxon.Text = "XON/XOFF";
            this.cbxon.UseVisualStyleBackColor = true;
            // 
            // cbrtscts
            // 
            this.cbrtscts.AutoSize = true;
            this.cbrtscts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrtscts.Location = new System.Drawing.Point(12, 33);
            this.cbrtscts.Name = "cbrtscts";
            this.cbrtscts.Size = new System.Drawing.Size(80, 24);
            this.cbrtscts.TabIndex = 6;
            this.cbrtscts.Text = "RTS/CTS";
            this.cbrtscts.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtStopbits);
            this.GroupBox1.Controls.Add(this.txtParity);
            this.GroupBox1.Controls.Add(this.txtDatabits);
            this.GroupBox1.Controls.Add(this.txtBrate);
            this.GroupBox1.Controls.Add(this.lblStopbits);
            this.GroupBox1.Controls.Add(this.lblDatabits);
            this.GroupBox1.Controls.Add(this.lblParity);
            this.GroupBox1.Controls.Add(this.lblBrate);
            this.GroupBox1.Controls.Add(this.txtComports);
            this.GroupBox1.Controls.Add(this.lblPort);
            this.GroupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(24, 31);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(256, 231);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Com Option";
            // 
            // txtStopbits
            // 
            this.txtStopbits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtStopbits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtStopbits.FormattingEnabled = true;
            this.txtStopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.txtStopbits.Location = new System.Drawing.Point(96, 187);
            this.txtStopbits.Name = "txtStopbits";
            this.txtStopbits.Size = new System.Drawing.Size(121, 28);
            this.txtStopbits.TabIndex = 5;
            // 
            // txtParity
            // 
            this.txtParity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtParity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtParity.FormattingEnabled = true;
            this.txtParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.txtParity.Location = new System.Drawing.Point(96, 104);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(121, 28);
            this.txtParity.TabIndex = 3;
            // 
            // txtDatabits
            // 
            this.txtDatabits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDatabits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDatabits.FormattingEnabled = true;
            this.txtDatabits.Items.AddRange(new object[] {
            "4",
            "8",
            "16"});
            this.txtDatabits.Location = new System.Drawing.Point(96, 145);
            this.txtDatabits.Name = "txtDatabits";
            this.txtDatabits.Size = new System.Drawing.Size(121, 28);
            this.txtDatabits.TabIndex = 4;
            // 
            // txtBrate
            // 
            this.txtBrate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBrate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtBrate.FormattingEnabled = true;
            this.txtBrate.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "28400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.txtBrate.Location = new System.Drawing.Point(96, 64);
            this.txtBrate.Name = "txtBrate";
            this.txtBrate.Size = new System.Drawing.Size(121, 28);
            this.txtBrate.TabIndex = 2;
            // 
            // lblStopbits
            // 
            this.lblStopbits.AutoSize = true;
            this.lblStopbits.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopbits.Location = new System.Drawing.Point(9, 190);
            this.lblStopbits.Name = "lblStopbits";
            this.lblStopbits.Size = new System.Drawing.Size(68, 20);
            this.lblStopbits.TabIndex = 500;
            this.lblStopbits.Text = "Stop Bits";
            // 
            // lblDatabits
            // 
            this.lblDatabits.AutoSize = true;
            this.lblDatabits.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabits.Location = new System.Drawing.Point(8, 148);
            this.lblDatabits.Name = "lblDatabits";
            this.lblDatabits.Size = new System.Drawing.Size(72, 20);
            this.lblDatabits.TabIndex = 400;
            this.lblDatabits.Text = "Data Bits";
            // 
            // lblParity
            // 
            this.lblParity.AutoSize = true;
            this.lblParity.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParity.Location = new System.Drawing.Point(9, 104);
            this.lblParity.Name = "lblParity";
            this.lblParity.Size = new System.Drawing.Size(49, 20);
            this.lblParity.TabIndex = 300;
            this.lblParity.Text = "Parity";
            // 
            // lblBrate
            // 
            this.lblBrate.AutoSize = true;
            this.lblBrate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrate.Location = new System.Drawing.Point(9, 67);
            this.lblBrate.Name = "lblBrate";
            this.lblBrate.Size = new System.Drawing.Size(85, 20);
            this.lblBrate.TabIndex = 200;
            this.lblBrate.Text = "Baud Rate";
            // 
            // txtComports
            // 
            this.txtComports.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.txtComports.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtComports.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtComports.FormattingEnabled = true;
            this.txtComports.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.txtComports.Location = new System.Drawing.Point(96, 24);
            this.txtComports.Name = "txtComports";
            this.txtComports.Size = new System.Drawing.Size(121, 28);
            this.txtComports.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(9, 27);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(38, 20);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port";
            // 
            // Port_File_Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 436);
            this.Controls.Add(this.lblSetting);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.panelReceive);
            this.Controls.Add(this.panelSend);
            this.Name = "Port_File_Transfer";
            this.Text = "Port File Transfer";
            this.panelReceive.ResumeLayout(false);
            this.panelReceive.PerformLayout();
            this.panelSend.ResumeLayout(false);
            this.panelSend.PerformLayout();
            this.panelSetting.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panelReceive;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label lblRstring;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Panel panelSetting;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.CheckBox cbrts;
        internal System.Windows.Forms.CheckBox cbdtr;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.CheckBox cbxon;
        internal System.Windows.Forms.CheckBox cbrtscts;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox txtStopbits;
        internal System.Windows.Forms.ComboBox txtParity;
        internal System.Windows.Forms.ComboBox txtDatabits;
        internal System.Windows.Forms.ComboBox txtBrate;
        internal System.Windows.Forms.Label lblStopbits;
        internal System.Windows.Forms.Label lblDatabits;
        internal System.Windows.Forms.Label lblParity;
        internal System.Windows.Forms.Label lblBrate;
        internal System.Windows.Forms.ComboBox txtComports;
        internal System.Windows.Forms.Label lblPort;
    }
}


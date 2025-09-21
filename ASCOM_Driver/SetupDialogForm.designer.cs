namespace ASCOM.DarkSkyGeek
{
    partial class SetupDialogForm
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.comPortOverrideLabel = new System.Windows.Forms.Label();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.picASCOM = new System.Windows.Forms.PictureBox();
            this.chkAutoDetect = new System.Windows.Forms.CheckBox();
            this.comboBoxComPort2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComPortName = new System.Windows.Forms.TextBox();
            this.textBoxComPort2Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxComPort3 = new System.Windows.Forms.ComboBox();
            this.textBoxComPort3Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Image = global::ASCOM.DarkSkyGeek.Properties.Resources.icon_ok_24;
            this.cmdOK.Location = new System.Drawing.Point(380, 140);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.cmdOK.Size = new System.Drawing.Size(76, 35);
            this.cmdOK.TabIndex = 0;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Image = global::ASCOM.DarkSkyGeek.Properties.Resources.icon_cancel_24;
            this.cmdCancel.Location = new System.Drawing.Point(462, 140);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(74, 37);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // comPortOverrideLabel
            // 
            this.comPortOverrideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comPortOverrideLabel.AutoSize = true;
            this.comPortOverrideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comPortOverrideLabel.Location = new System.Drawing.Point(157, 38);
            this.comPortOverrideLabel.Name = "comPortOverrideLabel";
            this.comPortOverrideLabel.Size = new System.Drawing.Size(65, 13);
            this.comPortOverrideLabel.TabIndex = 5;
            this.comPortOverrideLabel.Text = "COM Port 1;";
            // 
            // chkTrace
            // 
            this.chkTrace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTrace.AutoSize = true;
            this.chkTrace.Location = new System.Drawing.Point(160, 121);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(69, 17);
            this.chkTrace.TabIndex = 6;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(238, 35);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(71, 21);
            this.comboBoxComPort.TabIndex = 7;
            // 
            // picASCOM
            // 
            this.picASCOM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picASCOM.Image = global::ASCOM.DarkSkyGeek.Properties.Resources.darkskygeek;
            this.picASCOM.Location = new System.Drawing.Point(12, 9);
            this.picASCOM.Name = "picASCOM";
            this.picASCOM.Size = new System.Drawing.Size(120, 120);
            this.picASCOM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picASCOM.TabIndex = 3;
            this.picASCOM.TabStop = false;
            this.picASCOM.Click += new System.EventHandler(this.BrowseToAscom);
            this.picASCOM.DoubleClick += new System.EventHandler(this.BrowseToAscom);
            // 
            // chkAutoDetect
            // 
            this.chkAutoDetect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoDetect.AutoSize = true;
            this.chkAutoDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutoDetect.Location = new System.Drawing.Point(160, 12);
            this.chkAutoDetect.Name = "chkAutoDetect";
            this.chkAutoDetect.Size = new System.Drawing.Size(131, 17);
            this.chkAutoDetect.TabIndex = 8;
            this.chkAutoDetect.Text = "Auto-Detect COM port";
            this.chkAutoDetect.UseVisualStyleBackColor = true;
            this.chkAutoDetect.CheckedChanged += new System.EventHandler(this.chkAutoDetect_CheckedChanged);
            // 
            // comboBoxComPort2
            // 
            this.comboBoxComPort2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxComPort2.FormattingEnabled = true;
            this.comboBoxComPort2.Location = new System.Drawing.Point(238, 62);
            this.comboBoxComPort2.Name = "comboBoxComPort2";
            this.comboBoxComPort2.Size = new System.Drawing.Size(71, 21);
            this.comboBoxComPort2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM Port 2:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxComPortName
            // 
            this.textBoxComPortName.Location = new System.Drawing.Point(318, 35);
            this.textBoxComPortName.Name = "textBoxComPortName";
            this.textBoxComPortName.Size = new System.Drawing.Size(201, 20);
            this.textBoxComPortName.TabIndex = 9;
            // 
            // textBoxComPort2Name
            // 
            this.textBoxComPort2Name.Location = new System.Drawing.Point(318, 62);
            this.textBoxComPort2Name.Name = "textBoxComPort2Name";
            this.textBoxComPort2Name.Size = new System.Drawing.Size(201, 20);
            this.textBoxComPort2Name.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "COM Port 3:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxComPort3
            // 
            this.comboBoxComPort3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxComPort3.FormattingEnabled = true;
            this.comboBoxComPort3.Location = new System.Drawing.Point(238, 89);
            this.comboBoxComPort3.Name = "comboBoxComPort3";
            this.comboBoxComPort3.Size = new System.Drawing.Size(71, 21);
            this.comboBoxComPort3.TabIndex = 7;
            // 
            // textBoxComPort3Name
            // 
            this.textBoxComPort3Name.Location = new System.Drawing.Point(318, 90);
            this.textBoxComPort3Name.Name = "textBoxComPort3Name";
            this.textBoxComPort3Name.Size = new System.Drawing.Size(201, 20);
            this.textBoxComPort3Name.TabIndex = 9;
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 185);
            this.Controls.Add(this.textBoxComPort3Name);
            this.Controls.Add(this.textBoxComPort2Name);
            this.Controls.Add(this.textBoxComPortName);
            this.Controls.Add(this.chkAutoDetect);
            this.Controls.Add(this.comboBoxComPort3);
            this.Controls.Add(this.comboBoxComPort2);
            this.Controls.Add(this.comboBoxComPort);
            this.Controls.Add(this.chkTrace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comPortOverrideLabel);
            this.Controls.Add(this.picASCOM);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DarkSkyGeek’s Telescope Cover";
            this.Load += new System.EventHandler(this.SetupDialogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picASCOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label comPortOverrideLabel;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.PictureBox picASCOM;
        private System.Windows.Forms.CheckBox chkAutoDetect;
        private System.Windows.Forms.ComboBox comboBoxComPort2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComPortName;
        private System.Windows.Forms.TextBox textBoxComPort2Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxComPort3;
        private System.Windows.Forms.TextBox textBoxComPort3Name;
    }
}
namespace JurisUtilityBase
{
    partial class UtilityBaseMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UtilityBaseMain));
            this.JurisLogoImageBox = new System.Windows.Forms.PictureBox();
            this.LexisNexisLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBoxCompanies = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.OpenFileDialogOpen = new System.Windows.Forms.OpenFileDialog();
            this.buttonReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.radioButtonNum = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBillDateTo = new System.Windows.Forms.TextBox();
            this.labelBillDate = new System.Windows.Forms.Label();
            this.textBoxBillDateFrom = new System.Windows.Forms.TextBox();
            this.textBoxBillNoTo = new System.Windows.Forms.TextBox();
            this.labelBillNo = new System.Windows.Forms.Label();
            this.textBoxBillNoFrom = new System.Windows.Forms.TextBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonCli = new System.Windows.Forms.RadioButton();
            this.radioButtonMat = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllCiMatInv = new System.Windows.Forms.RadioButton();
            this.radioButtonAllInv = new System.Windows.Forms.RadioButton();
            this.radioButtonAllMat = new System.Windows.Forms.RadioButton();
            this.radioButtonAllCli = new System.Windows.Forms.RadioButton();
            this.radioButtonOneFolder = new System.Windows.Forms.RadioButton();
            this.checkBoxAdv = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.JurisLogoImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexisNexisLogoPictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // JurisLogoImageBox
            // 
            this.JurisLogoImageBox.Image = ((System.Drawing.Image)(resources.GetObject("JurisLogoImageBox.Image")));
            this.JurisLogoImageBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("JurisLogoImageBox.InitialImage")));
            this.JurisLogoImageBox.Location = new System.Drawing.Point(0, 1);
            this.JurisLogoImageBox.Name = "JurisLogoImageBox";
            this.JurisLogoImageBox.Size = new System.Drawing.Size(104, 336);
            this.JurisLogoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.JurisLogoImageBox.TabIndex = 0;
            this.JurisLogoImageBox.TabStop = false;
            // 
            // LexisNexisLogoPictureBox
            // 
            this.LexisNexisLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LexisNexisLogoPictureBox.Image")));
            this.LexisNexisLogoPictureBox.Location = new System.Drawing.Point(5, 343);
            this.LexisNexisLogoPictureBox.Name = "LexisNexisLogoPictureBox";
            this.LexisNexisLogoPictureBox.Size = new System.Drawing.Size(96, 28);
            this.LexisNexisLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LexisNexisLogoPictureBox.TabIndex = 1;
            this.LexisNexisLogoPictureBox.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(620, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel.Text = "Status: Ready to Execute";
            // 
            // listBoxCompanies
            // 
            this.listBoxCompanies.FormattingEnabled = true;
            this.listBoxCompanies.Location = new System.Drawing.Point(111, 1);
            this.listBoxCompanies.Name = "listBoxCompanies";
            this.listBoxCompanies.Size = new System.Drawing.Size(262, 69);
            this.listBoxCompanies.TabIndex = 0;
            this.listBoxCompanies.SelectedIndexChanged += new System.EventHandler(this.listBoxCompanies_SelectedIndexChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescription.Location = new System.Drawing.Point(380, 1);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(225, 69);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Extracts some or all of the expense attachments based on bill number, client or m" +
    "atter";
            // 
            // OpenFileDialogOpen
            // 
            this.OpenFileDialogOpen.FileName = "openFileDialog1";
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.LightGray;
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.ForeColor = System.Drawing.Color.MidnightBlue;
            this.buttonReport.Location = new System.Drawing.Point(148, 443);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(148, 38);
            this.buttonReport.TabIndex = 16;
            this.buttonReport.Text = "Exit";
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(447, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonNum
            // 
            this.radioButtonNum.AutoSize = true;
            this.radioButtonNum.Location = new System.Drawing.Point(24, 29);
            this.radioButtonNum.Name = "radioButtonNum";
            this.radioButtonNum.Size = new System.Drawing.Size(78, 17);
            this.radioButtonNum.TabIndex = 18;
            this.radioButtonNum.TabStop = true;
            this.radioButtonNum.Text = "Bill Number";
            this.radioButtonNum.UseVisualStyleBackColor = true;
            this.radioButtonNum.CheckedChanged += new System.EventHandler(this.radioButtonNum_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBillDateTo);
            this.groupBox1.Controls.Add(this.labelBillDate);
            this.groupBox1.Controls.Add(this.textBoxBillDateFrom);
            this.groupBox1.Controls.Add(this.textBoxBillNoTo);
            this.groupBox1.Controls.Add(this.labelBillNo);
            this.groupBox1.Controls.Add(this.textBoxBillNoFrom);
            this.groupBox1.Controls.Add(this.radioButtonAll);
            this.groupBox1.Controls.Add(this.radioButtonCli);
            this.groupBox1.Controls.Add(this.radioButtonMat);
            this.groupBox1.Controls.Add(this.radioButtonDate);
            this.groupBox1.Controls.Add(this.radioButtonNum);
            this.groupBox1.Location = new System.Drawing.Point(124, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 155);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2) Extract Attachments by...";
            this.groupBox1.Visible = false;
            // 
            // textBoxBillDateTo
            // 
            this.textBoxBillDateTo.Location = new System.Drawing.Point(323, 55);
            this.textBoxBillDateTo.Name = "textBoxBillDateTo";
            this.textBoxBillDateTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillDateTo.TabIndex = 28;
            this.textBoxBillDateTo.Visible = false;
            // 
            // labelBillDate
            // 
            this.labelBillDate.AutoSize = true;
            this.labelBillDate.Location = new System.Drawing.Point(287, 57);
            this.labelBillDate.Name = "labelBillDate";
            this.labelBillDate.Size = new System.Drawing.Size(20, 13);
            this.labelBillDate.TabIndex = 27;
            this.labelBillDate.Text = "To";
            this.labelBillDate.Visible = false;
            // 
            // textBoxBillDateFrom
            // 
            this.textBoxBillDateFrom.Location = new System.Drawing.Point(172, 55);
            this.textBoxBillDateFrom.Name = "textBoxBillDateFrom";
            this.textBoxBillDateFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillDateFrom.TabIndex = 26;
            this.textBoxBillDateFrom.Text = "01/01/1900";
            this.textBoxBillDateFrom.Visible = false;
            // 
            // textBoxBillNoTo
            // 
            this.textBoxBillNoTo.Location = new System.Drawing.Point(323, 29);
            this.textBoxBillNoTo.Name = "textBoxBillNoTo";
            this.textBoxBillNoTo.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillNoTo.TabIndex = 25;
            this.textBoxBillNoTo.Text = "99999999";
            this.textBoxBillNoTo.Visible = false;
            // 
            // labelBillNo
            // 
            this.labelBillNo.AutoSize = true;
            this.labelBillNo.Location = new System.Drawing.Point(287, 31);
            this.labelBillNo.Name = "labelBillNo";
            this.labelBillNo.Size = new System.Drawing.Size(20, 13);
            this.labelBillNo.TabIndex = 24;
            this.labelBillNo.Text = "To";
            this.labelBillNo.Visible = false;
            // 
            // textBoxBillNoFrom
            // 
            this.textBoxBillNoFrom.Location = new System.Drawing.Point(172, 29);
            this.textBoxBillNoFrom.Name = "textBoxBillNoFrom";
            this.textBoxBillNoFrom.Size = new System.Drawing.Size(100, 20);
            this.textBoxBillNoFrom.TabIndex = 23;
            this.textBoxBillNoFrom.Text = "1";
            this.textBoxBillNoFrom.Visible = false;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(24, 132);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 22;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // radioButtonCli
            // 
            this.radioButtonCli.AutoSize = true;
            this.radioButtonCli.Location = new System.Drawing.Point(24, 107);
            this.radioButtonCli.Name = "radioButtonCli";
            this.radioButtonCli.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCli.TabIndex = 21;
            this.radioButtonCli.TabStop = true;
            this.radioButtonCli.Text = "Client";
            this.radioButtonCli.UseVisualStyleBackColor = true;
            this.radioButtonCli.CheckedChanged += new System.EventHandler(this.radioButtonCli_CheckedChanged);
            // 
            // radioButtonMat
            // 
            this.radioButtonMat.AutoSize = true;
            this.radioButtonMat.Location = new System.Drawing.Point(24, 82);
            this.radioButtonMat.Name = "radioButtonMat";
            this.radioButtonMat.Size = new System.Drawing.Size(55, 17);
            this.radioButtonMat.TabIndex = 20;
            this.radioButtonMat.TabStop = true;
            this.radioButtonMat.Text = "Matter";
            this.radioButtonMat.UseVisualStyleBackColor = true;
            this.radioButtonMat.CheckedChanged += new System.EventHandler(this.radioButtonMat_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(24, 56);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(64, 17);
            this.radioButtonDate.TabIndex = 19;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "Bill Date";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(19, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Click and select the folder the attachments are to be saved in";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.ForeColor = System.Drawing.Color.Red;
            this.labelPath.Location = new System.Drawing.Point(16, 60);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(35, 13);
            this.labelPath.TabIndex = 22;
            this.labelPath.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelPath);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(124, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 84);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1) Choose your path";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAllCiMatInv);
            this.groupBox3.Controls.Add(this.radioButtonAllInv);
            this.groupBox3.Controls.Add(this.radioButtonAllMat);
            this.groupBox3.Controls.Add(this.radioButtonAllCli);
            this.groupBox3.Controls.Add(this.radioButtonOneFolder);
            this.groupBox3.Location = new System.Drawing.Point(124, 363);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 74);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3) Folder Structure";
            this.groupBox3.Visible = false;
            // 
            // radioButtonAllCiMatInv
            // 
            this.radioButtonAllCiMatInv.AutoSize = true;
            this.radioButtonAllCiMatInv.Location = new System.Drawing.Point(306, 19);
            this.radioButtonAllCiMatInv.Name = "radioButtonAllCiMatInv";
            this.radioButtonAllCiMatInv.Size = new System.Drawing.Size(139, 17);
            this.radioButtonAllCiMatInv.TabIndex = 4;
            this.radioButtonAllCiMatInv.TabStop = true;
            this.radioButtonAllCiMatInv.Text = "By Client-Matter/Invoice";
            this.radioButtonAllCiMatInv.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllInv
            // 
            this.radioButtonAllInv.AutoSize = true;
            this.radioButtonAllInv.Location = new System.Drawing.Point(146, 42);
            this.radioButtonAllInv.Name = "radioButtonAllInv";
            this.radioButtonAllInv.Size = new System.Drawing.Size(115, 17);
            this.radioButtonAllInv.TabIndex = 3;
            this.radioButtonAllInv.TabStop = true;
            this.radioButtonAllInv.Text = "By Invoice Number";
            this.radioButtonAllInv.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllMat
            // 
            this.radioButtonAllMat.AutoSize = true;
            this.radioButtonAllMat.Location = new System.Drawing.Point(146, 19);
            this.radioButtonAllMat.Name = "radioButtonAllMat";
            this.radioButtonAllMat.Size = new System.Drawing.Size(139, 17);
            this.radioButtonAllMat.TabIndex = 2;
            this.radioButtonAllMat.TabStop = true;
            this.radioButtonAllMat.Text = "By Client-Matter Number";
            this.radioButtonAllMat.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllCli
            // 
            this.radioButtonAllCli.AutoSize = true;
            this.radioButtonAllCli.Location = new System.Drawing.Point(14, 42);
            this.radioButtonAllCli.Name = "radioButtonAllCli";
            this.radioButtonAllCli.Size = new System.Drawing.Size(106, 17);
            this.radioButtonAllCli.TabIndex = 1;
            this.radioButtonAllCli.TabStop = true;
            this.radioButtonAllCli.Text = "By Client Number";
            this.radioButtonAllCli.UseVisualStyleBackColor = true;
            // 
            // radioButtonOneFolder
            // 
            this.radioButtonOneFolder.AutoSize = true;
            this.radioButtonOneFolder.Checked = true;
            this.radioButtonOneFolder.Location = new System.Drawing.Point(14, 19);
            this.radioButtonOneFolder.Name = "radioButtonOneFolder";
            this.radioButtonOneFolder.Size = new System.Drawing.Size(56, 17);
            this.radioButtonOneFolder.TabIndex = 0;
            this.radioButtonOneFolder.TabStop = true;
            this.radioButtonOneFolder.Text = "All in 1";
            this.radioButtonOneFolder.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdv
            // 
            this.checkBoxAdv.AutoSize = true;
            this.checkBoxAdv.Location = new System.Drawing.Point(124, 174);
            this.checkBoxAdv.Name = "checkBoxAdv";
            this.checkBoxAdv.Size = new System.Drawing.Size(315, 17);
            this.checkBoxAdv.TabIndex = 25;
            this.checkBoxAdv.Text = "Show Advanced Options (Defaults will be used if unchecked)";
            this.checkBoxAdv.UseVisualStyleBackColor = true;
            this.checkBoxAdv.CheckedChanged += new System.EventHandler(this.checkBoxAdv_CheckedChanged);
            // 
            // UtilityBaseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 511);
            this.Controls.Add(this.checkBoxAdv);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.listBoxCompanies);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.LexisNexisLogoPictureBox);
            this.Controls.Add(this.JurisLogoImageBox);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UtilityBaseMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JPS - Expense Attachment Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JurisLogoImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LexisNexisLogoPictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox JurisLogoImageBox;
        private System.Windows.Forms.PictureBox LexisNexisLogoPictureBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ListBox listBoxCompanies;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogOpen;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton radioButtonNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBillDateTo;
        private System.Windows.Forms.Label labelBillDate;
        private System.Windows.Forms.TextBox textBoxBillDateFrom;
        private System.Windows.Forms.TextBox textBoxBillNoTo;
        private System.Windows.Forms.Label labelBillNo;
        private System.Windows.Forms.TextBox textBoxBillNoFrom;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonCli;
        private System.Windows.Forms.RadioButton radioButtonMat;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonAllCiMatInv;
        private System.Windows.Forms.RadioButton radioButtonAllInv;
        private System.Windows.Forms.RadioButton radioButtonAllMat;
        private System.Windows.Forms.RadioButton radioButtonAllCli;
        private System.Windows.Forms.RadioButton radioButtonOneFolder;
        private System.Windows.Forms.CheckBox checkBoxAdv;
    }
}


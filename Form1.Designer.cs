namespace AnalyseHugeTextFiles
{
    partial class Form1
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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.btnOpenFile = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.tsStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.label1 = new System.Windows.Forms.Label();
      this.lblFileNameHeader = new System.Windows.Forms.Label();
      this.lblLineLength = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblRowCount = new System.Windows.Forms.Label();
      this.lstWarnings = new System.Windows.Forms.ListBox();
      this.contextMenuWarnings = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
      this.lblDelimiterCaption = new System.Windows.Forms.Label();
      this.cbxDelimiter = new System.Windows.Forms.ComboBox();
      this.btnStart = new System.Windows.Forms.Button();
      this.txtFilePath = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabWarnings = new System.Windows.Forms.TabPage();
      this.tabDataItems = new System.Windows.Forms.TabPage();
      this.gridView = new System.Windows.Forms.DataGridView();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnClose = new System.Windows.Forms.Button();
      this.chkFirstLineIsHeader = new System.Windows.Forms.CheckBox();
      this.statusStrip1.SuspendLayout();
      this.contextMenuWarnings.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabWarnings.SuspendLayout();
      this.tabDataItems.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // btnOpenFile
      // 
      this.btnOpenFile.Location = new System.Drawing.Point(426, 38);
      this.btnOpenFile.Name = "btnOpenFile";
      this.btnOpenFile.Size = new System.Drawing.Size(25, 23);
      this.btnOpenFile.TabIndex = 0;
      this.btnOpenFile.Text = "...";
      this.btnOpenFile.UseVisualStyleBackColor = true;
      this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 440);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(689, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip";
      // 
      // tsStatusLabel
      // 
      this.tsStatusLabel.Name = "tsStatusLabel";
      this.tsStatusLabel.Size = new System.Drawing.Size(39, 17);
      this.tsStatusLabel.Text = "Ready";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(115, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Line Length (min/max):";
      // 
      // lblFileNameHeader
      // 
      this.lblFileNameHeader.AutoSize = true;
      this.lblFileNameHeader.Location = new System.Drawing.Point(14, 22);
      this.lblFileNameHeader.Name = "lblFileNameHeader";
      this.lblFileNameHeader.Size = new System.Drawing.Size(57, 13);
      this.lblFileNameHeader.TabIndex = 4;
      this.lblFileNameHeader.Text = "File Name:";
      // 
      // lblLineLength
      // 
      this.lblLineLength.AutoSize = true;
      this.lblLineLength.Location = new System.Drawing.Point(124, 10);
      this.lblLineLength.Name = "lblLineLength";
      this.lblLineLength.Size = new System.Drawing.Size(13, 13);
      this.lblLineLength.TabIndex = 5;
      this.lblLineLength.Text = "0";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(251, 10);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Row Count:";
      // 
      // lblRowCount
      // 
      this.lblRowCount.AutoSize = true;
      this.lblRowCount.Location = new System.Drawing.Point(320, 10);
      this.lblRowCount.Name = "lblRowCount";
      this.lblRowCount.Size = new System.Drawing.Size(13, 13);
      this.lblRowCount.TabIndex = 8;
      this.lblRowCount.Text = "0";
      // 
      // lstWarnings
      // 
      this.lstWarnings.ContextMenuStrip = this.contextMenuWarnings;
      this.lstWarnings.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstWarnings.FormattingEnabled = true;
      this.lstWarnings.Location = new System.Drawing.Point(3, 3);
      this.lstWarnings.Name = "lstWarnings";
      this.lstWarnings.Size = new System.Drawing.Size(663, 243);
      this.lstWarnings.TabIndex = 11;
      // 
      // contextMenuWarnings
      // 
      this.contextMenuWarnings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
      this.contextMenuWarnings.Name = "contextMenuWarnings";
      this.contextMenuWarnings.Size = new System.Drawing.Size(161, 29);
      // 
      // toolStripTextBox
      // 
      this.toolStripTextBox.Name = "toolStripTextBox";
      this.toolStripTextBox.Size = new System.Drawing.Size(100, 23);
      this.toolStripTextBox.Text = "Save to file";
      this.toolStripTextBox.Click += new System.EventHandler(this.toolStripTextBox_Click);
      // 
      // lblDelimiterCaption
      // 
      this.lblDelimiterCaption.AutoSize = true;
      this.lblDelimiterCaption.Location = new System.Drawing.Point(465, 22);
      this.lblDelimiterCaption.Name = "lblDelimiterCaption";
      this.lblDelimiterCaption.Size = new System.Drawing.Size(50, 13);
      this.lblDelimiterCaption.TabIndex = 13;
      this.lblDelimiterCaption.Text = "Delimiter:";
      // 
      // cbxDelimiter
      // 
      this.cbxDelimiter.FormattingEnabled = true;
      this.cbxDelimiter.Location = new System.Drawing.Point(468, 38);
      this.cbxDelimiter.Name = "cbxDelimiter";
      this.cbxDelimiter.Size = new System.Drawing.Size(121, 21);
      this.cbxDelimiter.TabIndex = 14;
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(612, 64);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(59, 23);
      this.btnStart.TabIndex = 15;
      this.btnStart.Text = "&Start";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // txtFilePath
      // 
      this.txtFilePath.Location = new System.Drawing.Point(17, 40);
      this.txtFilePath.Name = "txtFilePath";
      this.txtFilePath.Size = new System.Drawing.Size(410, 20);
      this.txtFilePath.TabIndex = 16;
      this.txtFilePath.Text = "C:\\Projects\\DataStage\\test.TXT";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.tabControl1);
      this.groupBox1.Location = new System.Drawing.Point(0, 102);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(689, 335);
      this.groupBox1.TabIndex = 18;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Result";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.lblRowCount);
      this.panel1.Controls.Add(this.lblLineLength);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 16);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(683, 32);
      this.panel1.TabIndex = 13;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tabWarnings);
      this.tabControl1.Controls.Add(this.tabDataItems);
      this.tabControl1.Location = new System.Drawing.Point(6, 54);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(677, 275);
      this.tabControl1.TabIndex = 12;
      // 
      // tabWarnings
      // 
      this.tabWarnings.Controls.Add(this.lstWarnings);
      this.tabWarnings.Location = new System.Drawing.Point(4, 22);
      this.tabWarnings.Name = "tabWarnings";
      this.tabWarnings.Padding = new System.Windows.Forms.Padding(3);
      this.tabWarnings.Size = new System.Drawing.Size(669, 249);
      this.tabWarnings.TabIndex = 0;
      this.tabWarnings.Text = "Warnings";
      this.tabWarnings.UseVisualStyleBackColor = true;
      // 
      // tabDataItems
      // 
      this.tabDataItems.Controls.Add(this.gridView);
      this.tabDataItems.Location = new System.Drawing.Point(4, 22);
      this.tabDataItems.Name = "tabDataItems";
      this.tabDataItems.Padding = new System.Windows.Forms.Padding(3);
      this.tabDataItems.Size = new System.Drawing.Size(664, 249);
      this.tabDataItems.TabIndex = 1;
      this.tabDataItems.Text = "Data Item Lengths";
      this.tabDataItems.UseVisualStyleBackColor = true;
      // 
      // gridView
      // 
      this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridView.Location = new System.Drawing.Point(3, 3);
      this.gridView.Name = "gridView";
      this.gridView.Size = new System.Drawing.Size(658, 243);
      this.gridView.TabIndex = 20;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.btnClose);
      this.groupBox2.Controls.Add(this.chkFirstLineIsHeader);
      this.groupBox2.Controls.Add(this.lblDelimiterCaption);
      this.groupBox2.Controls.Add(this.txtFilePath);
      this.groupBox2.Controls.Add(this.btnOpenFile);
      this.groupBox2.Controls.Add(this.cbxDelimiter);
      this.groupBox2.Controls.Add(this.btnStart);
      this.groupBox2.Controls.Add(this.lblFileNameHeader);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(689, 96);
      this.groupBox2.TabIndex = 19;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Parameters";
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(613, 17);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(59, 23);
      this.btnClose.TabIndex = 18;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // chkFirstLineIsHeader
      // 
      this.chkFirstLineIsHeader.AutoSize = true;
      this.chkFirstLineIsHeader.Location = new System.Drawing.Point(17, 70);
      this.chkFirstLineIsHeader.Name = "chkFirstLineIsHeader";
      this.chkFirstLineIsHeader.Size = new System.Drawing.Size(116, 17);
      this.chkFirstLineIsHeader.TabIndex = 17;
      this.chkFirstLineIsHeader.Text = "First Line is Header";
      this.chkFirstLineIsHeader.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(689, 462);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.statusStrip1);
      this.MinimumSize = new System.Drawing.Size(700, 500);
      this.Name = "Form1";
      this.Text = "Text File Scanner";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.contextMenuWarnings.ResumeLayout(false);
      this.contextMenuWarnings.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabWarnings.ResumeLayout(false);
      this.tabDataItems.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileNameHeader;
        private System.Windows.Forms.Label lblLineLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.ListBox lstWarnings;
        private System.Windows.Forms.Label lblDelimiterCaption;
        private System.Windows.Forms.ComboBox cbxDelimiter;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabWarnings;
        private System.Windows.Forms.TabPage tabDataItems;
        private System.Windows.Forms.CheckBox chkFirstLineIsHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuWarnings;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
        private System.Windows.Forms.Button btnClose;
    }
}


namespace KontrolnyVykaz
{
    partial class frmVatChecker
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
            this.btnTest = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTester = new System.Windows.Forms.TabPage();
            this.tabDbHelper = new System.Windows.Forms.TabPage();
            this.btnClearWin = new System.Windows.Forms.Button();
            this.btnExecNonQ = new System.Windows.Forms.Button();
            this.btnExecQuery = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblQuerySelCount = new System.Windows.Forms.Label();
            this.lblQueryResCount = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblQueryCountlbl = new System.Windows.Forms.Label();
            this.btnQuery5 = new System.Windows.Forms.Button();
            this.btnQuery4 = new System.Windows.Forms.Button();
            this.btnQuery3 = new System.Windows.Forms.Button();
            this.btnQuery2 = new System.Windows.Forms.Button();
            this.btnQuery1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExecNonQuery = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.btnExportQuery = new System.Windows.Forms.Button();
            this.lblQueryInfo = new System.Windows.Forms.Label();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabTester.SuspendLayout();
            this.tabDbHelper.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(3, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Validuj";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(84, 6);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(746, 544);
            this.txtLog.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabTester);
            this.tabControl1.Controls.Add(this.tabDbHelper);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 590);
            this.tabControl1.TabIndex = 2;
            // 
            // tabTester
            // 
            this.tabTester.Controls.Add(this.btnTest);
            this.tabTester.Controls.Add(this.txtLog);
            this.tabTester.Location = new System.Drawing.Point(4, 22);
            this.tabTester.Name = "tabTester";
            this.tabTester.Padding = new System.Windows.Forms.Padding(3);
            this.tabTester.Size = new System.Drawing.Size(836, 556);
            this.tabTester.TabIndex = 0;
            this.tabTester.Text = "Tests";
            this.tabTester.UseVisualStyleBackColor = true;
            // 
            // tabDbHelper
            // 
            this.tabDbHelper.Controls.Add(this.gridResults);
            this.tabDbHelper.Controls.Add(this.btnClearWin);
            this.tabDbHelper.Controls.Add(this.btnExecNonQ);
            this.tabDbHelper.Controls.Add(this.btnExecQuery);
            this.tabDbHelper.Controls.Add(this.textBox1);
            this.tabDbHelper.Location = new System.Drawing.Point(4, 22);
            this.tabDbHelper.Name = "tabDbHelper";
            this.tabDbHelper.Padding = new System.Windows.Forms.Padding(3);
            this.tabDbHelper.Size = new System.Drawing.Size(833, 564);
            this.tabDbHelper.TabIndex = 1;
            this.tabDbHelper.Text = "DB helper";
            this.tabDbHelper.UseVisualStyleBackColor = true;
            // 
            // btnClearWin
            // 
            this.btnClearWin.Location = new System.Drawing.Point(6, 94);
            this.btnClearWin.Name = "btnClearWin";
            this.btnClearWin.Size = new System.Drawing.Size(161, 38);
            this.btnClearWin.TabIndex = 12;
            this.btnClearWin.Text = "&Clear query window";
            this.btnClearWin.UseVisualStyleBackColor = true;
            this.btnClearWin.Click += new System.EventHandler(this.btnClearWin_Click);
            // 
            // btnExecNonQ
            // 
            this.btnExecNonQ.Location = new System.Drawing.Point(6, 50);
            this.btnExecNonQ.Name = "btnExecNonQ";
            this.btnExecNonQ.Size = new System.Drawing.Size(161, 38);
            this.btnExecNonQ.TabIndex = 11;
            this.btnExecNonQ.Text = "E&xecute non-query";
            this.btnExecNonQ.UseVisualStyleBackColor = true;
            this.btnExecNonQ.Click += new System.EventHandler(this.btnExecNonQ_Click);
            // 
            // btnExecQuery
            // 
            this.btnExecQuery.Location = new System.Drawing.Point(6, 6);
            this.btnExecQuery.Name = "btnExecQuery";
            this.btnExecQuery.Size = new System.Drawing.Size(161, 38);
            this.btnExecQuery.TabIndex = 10;
            this.btnExecQuery.Text = "Execute &query";
            this.btnExecQuery.UseVisualStyleBackColor = true;
            this.btnExecQuery.Click += new System.EventHandler(this.btnExecQuery_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Location = new System.Drawing.Point(173, 6);
            this.textBox1.MaxLength = 65535;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(654, 211);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "select * from sqlite_master order by code desc;";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.lblQuerySelCount);
            this.groupBox7.Controls.Add(this.lblQueryResCount);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.lblQueryCountlbl);
            this.groupBox7.Location = new System.Drawing.Point(3, 588);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1128, 40);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Items";
            // 
            // lblQuerySelCount
            // 
            this.lblQuerySelCount.AutoSize = true;
            this.lblQuerySelCount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQuerySelCount.Location = new System.Drawing.Point(196, 16);
            this.lblQuerySelCount.Name = "lblQuerySelCount";
            this.lblQuerySelCount.Size = new System.Drawing.Size(13, 13);
            this.lblQuerySelCount.TabIndex = 3;
            this.lblQuerySelCount.Text = "0";
            // 
            // lblQueryResCount
            // 
            this.lblQueryResCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQueryResCount.AutoSize = true;
            this.lblQueryResCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblQueryResCount.Location = new System.Drawing.Point(63, 16);
            this.lblQueryResCount.Name = "lblQueryResCount";
            this.lblQueryResCount.Size = new System.Drawing.Size(13, 13);
            this.lblQueryResCount.TabIndex = 16;
            this.lblQueryResCount.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(108, 16);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(82, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Selected items: ";
            // 
            // lblQueryCountlbl
            // 
            this.lblQueryCountlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQueryCountlbl.AutoSize = true;
            this.lblQueryCountlbl.Location = new System.Drawing.Point(6, 16);
            this.lblQueryCountlbl.Name = "lblQueryCountlbl";
            this.lblQueryCountlbl.Size = new System.Drawing.Size(51, 13);
            this.lblQueryCountlbl.TabIndex = 15;
            this.lblQueryCountlbl.Text = "All items: ";
            // 
            // btnQuery5
            // 
            this.btnQuery5.Enabled = false;
            this.btnQuery5.Location = new System.Drawing.Point(494, 6);
            this.btnQuery5.Name = "btnQuery5";
            this.btnQuery5.Size = new System.Drawing.Size(75, 23);
            this.btnQuery5.TabIndex = 13;
            this.btnQuery5.Text = "-";
            this.btnQuery5.UseVisualStyleBackColor = true;
            // 
            // btnQuery4
            // 
            this.btnQuery4.Enabled = false;
            this.btnQuery4.Location = new System.Drawing.Point(413, 6);
            this.btnQuery4.Name = "btnQuery4";
            this.btnQuery4.Size = new System.Drawing.Size(75, 23);
            this.btnQuery4.TabIndex = 12;
            this.btnQuery4.Text = "-";
            this.btnQuery4.UseVisualStyleBackColor = true;
            // 
            // btnQuery3
            // 
            this.btnQuery3.Enabled = false;
            this.btnQuery3.Location = new System.Drawing.Point(332, 6);
            this.btnQuery3.Name = "btnQuery3";
            this.btnQuery3.Size = new System.Drawing.Size(75, 23);
            this.btnQuery3.TabIndex = 11;
            this.btnQuery3.Text = "-";
            this.btnQuery3.UseVisualStyleBackColor = true;
            // 
            // btnQuery2
            // 
            this.btnQuery2.Enabled = false;
            this.btnQuery2.Location = new System.Drawing.Point(251, 6);
            this.btnQuery2.Name = "btnQuery2";
            this.btnQuery2.Size = new System.Drawing.Size(75, 23);
            this.btnQuery2.TabIndex = 10;
            this.btnQuery2.Text = "-";
            this.btnQuery2.UseVisualStyleBackColor = true;
            // 
            // btnQuery1
            // 
            this.btnQuery1.Enabled = false;
            this.btnQuery1.Location = new System.Drawing.Point(170, 6);
            this.btnQuery1.Name = "btnQuery1";
            this.btnQuery1.Size = new System.Drawing.Size(75, 23);
            this.btnQuery1.TabIndex = 9;
            this.btnQuery1.Text = "-";
            this.btnQuery1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(3, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 38);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "&Clear query window";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExecNonQuery
            // 
            this.btnExecNonQuery.Location = new System.Drawing.Point(3, 179);
            this.btnExecNonQuery.Name = "btnExecNonQuery";
            this.btnExecNonQuery.Size = new System.Drawing.Size(161, 38);
            this.btnExecNonQuery.TabIndex = 7;
            this.btnExecNonQuery.Text = "E&xecute non-query";
            this.btnExecNonQuery.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(3, 135);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(161, 38);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute &query";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuery.Location = new System.Drawing.Point(170, 35);
            this.txtQuery.MaxLength = 65535;
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtQuery.Size = new System.Drawing.Size(1083, 226);
            this.txtQuery.TabIndex = 3;
            this.txtQuery.Text = "select * from sqlite_master order by code desc;";
            // 
            // btnExportQuery
            // 
            this.btnExportQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportQuery.Location = new System.Drawing.Point(1137, 588);
            this.btnExportQuery.Name = "btnExportQuery";
            this.btnExportQuery.Size = new System.Drawing.Size(116, 58);
            this.btnExportQuery.TabIndex = 14;
            this.btnExportQuery.Text = "&Export";
            this.btnExportQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportQuery.UseVisualStyleBackColor = true;
            // 
            // lblQueryInfo
            // 
            this.lblQueryInfo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQueryInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQueryInfo.Location = new System.Drawing.Point(7, 6);
            this.lblQueryInfo.Name = "lblQueryInfo";
            this.lblQueryInfo.Size = new System.Drawing.Size(157, 97);
            this.lblQueryInfo.TabIndex = 6;
            this.lblQueryInfo.Text = "Select query or command from text window and hit \'Execute query\' or shortcut Alt+" +
                "Q";
            this.lblQueryInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Location = new System.Drawing.Point(6, 223);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.Size = new System.Drawing.Size(821, 335);
            this.gridResults.TabIndex = 13;
            // 
            // frmVatChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 614);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVatChecker";
            this.Text = "Kontrolný výkaz";
            this.tabControl1.ResumeLayout(false);
            this.tabTester.ResumeLayout(false);
            this.tabTester.PerformLayout();
            this.tabDbHelper.ResumeLayout(false);
            this.tabDbHelper.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTester;
        private System.Windows.Forms.TabPage tabDbHelper;
        private System.Windows.Forms.Button btnClearWin;
        private System.Windows.Forms.Button btnExecNonQ;
        private System.Windows.Forms.Button btnExecQuery;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblQuerySelCount;
        private System.Windows.Forms.Label lblQueryResCount;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblQueryCountlbl;
        private System.Windows.Forms.Button btnQuery5;
        private System.Windows.Forms.Button btnQuery4;
        private System.Windows.Forms.Button btnQuery3;
        private System.Windows.Forms.Button btnQuery2;
        private System.Windows.Forms.Button btnQuery1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExecNonQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExportQuery;
        private System.Windows.Forms.Label lblQueryInfo;
        private System.Windows.Forms.DataGridView gridResults;
    }
}

